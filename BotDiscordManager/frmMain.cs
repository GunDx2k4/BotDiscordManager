using BotDiscordManager.Core.Bot;
using BotDiscordManager.Utils;
using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Windows.Forms;

namespace BotDiscordManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void loadServers()
        {
            MessageBox.Show(ResourcesForm.WATTING_LOAD, ResourcesForm.MESSAGE_BOX_NOTIFY);
            while (!BotDiscord.gI().isStarted)
            {
                Thread.Sleep(1000);
            }

            socketGuildBindingSource.DataSource = BotDiscord.gI().clientBot.Guilds;

            loadInfoServer();
        }

        private void loadInfoServer()
        {
            grpServers.Text = $"Server [{cboServers.Text}]";

            SocketGuild guild = (SocketGuild)socketGuildBindingSource[cboServers.SelectedIndex];

            var voiceChannels = guild.Channels.ToList().FindAll(c => c.GetChannelType() is ChannelType.Voice);
            var textChannels = guild.Channels.ToList().FindAll(c => c.GetChannelType() is ChannelType.Text);

            socketGuildUserBindingSource.DataSource = guild.Users;
            socketRoleBindingSource.DataSource = guild.Roles;
            socketVoiceChannelBindingSource.DataSource = voiceChannels;
            socketTextChannelBindingSource.DataSource = textChannels;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            VietnameseForm.load();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text))
            {
                MessageBox.Show(ResourcesForm.TOKEN_PRECONDITION, ResourcesForm.MESSAGE_BOX_NOTIFY);
                return;
            }

            Config.TOKEN_BOT = txtToken.Text;
            if (BotDiscord.gI().isStarted)
            {
                BotDiscord.gI().DisconnectBotAsync().GetAwaiter();
                return;
            }
            BotDiscord.gI().ConnectBotAsync().GetAwaiter();

            loadServers();
        }

        private void cboServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServers.SelectedIndex == -1)
                return;
            loadInfoServer();
        }

        private void cboVoiceChannels_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboVoiceChannels.SelectedIndex == -1)
                return;
            SocketGuildChannel channel = (SocketGuildChannel)socketVoiceChannelBindingSource[cboVoiceChannels.SelectedIndex];
            SocketRole roleEveryone = ((IReadOnlyCollection<SocketRole>)socketRoleBindingSource.DataSource).ToList().Find(r => r.IsEveryone);
            chkLockVoiceChannel.Checked = channel.PermissionOverwrites.ToList().Exists(p => p.TargetId.Equals(roleEveryone.Id) && p.Permissions.Connect == PermValue.Deny && p.Permissions.ViewChannel == PermValue.Deny);
        }

        private void cboTextChannels_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTextChannels.SelectedIndex == -1)
                return;
            SocketGuildChannel channel = (SocketGuildChannel)socketTextChannelBindingSource[cboTextChannels.SelectedIndex];
            SocketRole roleEveryone = ((IReadOnlyCollection<SocketRole>)socketRoleBindingSource.DataSource).ToList().Find(r => r.IsEveryone);
            chkLockTextChannel.Checked = channel.PermissionOverwrites.ToList().Exists(p => p.TargetId.Equals(roleEveryone.Id) && p.Permissions.SendMessages == PermValue.Deny && p.Permissions.ViewChannel == PermValue.Deny);
        }

        private void chkLockVoiceChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (cboVoiceChannels.SelectedIndex == -1)
                return;
            SocketGuildChannel channel = (SocketGuildChannel)socketVoiceChannelBindingSource[cboVoiceChannels.SelectedIndex];
            SocketRole roleEveryone = ((IReadOnlyCollection<SocketRole>)socketRoleBindingSource.DataSource).ToList().Find(r => r.IsEveryone);

            var permissions = chkLockVoiceChannel.Checked ? PermValue.Deny : PermValue.Allow;
            if (channel.PermissionOverwrites.ToList().Exists(p => p.TargetId.Equals(roleEveryone.Id) && p.Permissions.SendMessages != permissions))
            {
                channel.AddPermissionOverwriteAsync(roleEveryone, new OverwritePermissions(viewChannel: permissions, connect: permissions));
            }
        }

        private void chkLockTextChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (cboTextChannels.SelectedIndex == -1)
                return;
            SocketGuildChannel channel = (SocketGuildChannel)socketTextChannelBindingSource[cboTextChannels.SelectedIndex];
            SocketRole roleEveryone = ((IReadOnlyCollection<SocketRole>)socketRoleBindingSource.DataSource).ToList().Find(r => r.IsEveryone);

            var permissions = chkLockTextChannel.Checked ? PermValue.Deny : PermValue.Allow;
            if (channel.PermissionOverwrites.ToList().Exists(p => p.TargetId.Equals(roleEveryone.Id) && p.Permissions.SendMessages != permissions))
            {
                channel.AddPermissionOverwriteAsync(roleEveryone, new OverwritePermissions(viewChannel: permissions, sendMessages: permissions));
            }
        }

        private async void btnBan_Click(object sender, EventArgs e)
        {
            if (cboUsers.SelectedIndex == -1) 
                return;
            SocketGuildUser user = (SocketGuildUser)socketGuildUserBindingSource[cboUsers.SelectedIndex];
            await user.BanAsync(options: new RequestOptions() { AuditLogReason = txtReason.Text });
            MessageBox.Show(string.Format(ResourcesForm.COMPLETED_BAN_USER, user.Username, user.Id, user.Guild.Name), ResourcesForm.MESSAGE_BOX_NOTIFY);
        }

        private async void btnTimeout_Click(object sender, EventArgs e)
        {
            if (cboUsers.SelectedIndex == -1)
                return;

            TimeSpan span = UtilsForm.ConvertToTimeSpan(txtDurationTimeout.Text);

            if (span == TimeSpan.Zero)
            {
                MessageBox.Show(ResourcesForm.ERROR_TIMESPAN, ResourcesForm.MESSAGE_BOX_NOTIFY);
                return;
            }

            SocketGuildUser user = (SocketGuildUser)socketGuildUserBindingSource[cboUsers.SelectedIndex];
            await user.SetTimeOutAsync(span: span, options: new RequestOptions() { AuditLogReason = txtReason.Text });

            MessageBox.Show(string.Format(ResourcesForm.COMPETED_TIMEOUT_USER, user.Username, user.Id, user.Guild.Name, txtDurationTimeout.Text), ResourcesForm.MESSAGE_BOX_NOTIFY);
        }

        private async void btnCreateRole_Click(object sender, EventArgs e)
        {
            if (cboServers.SelectedIndex == -1)
                return;
            if (string.IsNullOrEmpty(txtNameRole.Text))
            {
                MessageBox.Show(ResourcesForm.ERROR_TIMESPAN, ResourcesForm.MESSAGE_BOX_NOTIFY);
                return;
            }
            SocketGuild guild = (SocketGuild)socketGuildBindingSource[cboServers.SelectedIndex];
            await guild.CreateRoleAsync()
        }
    }
}
