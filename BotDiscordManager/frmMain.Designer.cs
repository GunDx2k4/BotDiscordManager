namespace BotDiscordManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpServers = new System.Windows.Forms.GroupBox();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.txtColorRole = new System.Windows.Forms.TextBox();
            this.lblColorRole = new System.Windows.Forms.Label();
            this.lblNameRole = new System.Windows.Forms.Label();
            this.txtNameRole = new System.Windows.Forms.TextBox();
            this.btnTimeout = new System.Windows.Forms.Button();
            this.lblReason = new System.Windows.Forms.Label();
            this.chkLockTextChannel = new System.Windows.Forms.CheckBox();
            this.chkLockVoiceChannel = new System.Windows.Forms.CheckBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnBan = new System.Windows.Forms.Button();
            this.cboTextChannels = new System.Windows.Forms.ComboBox();
            this.socketTextChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.socketRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTextChannels = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.socketGuildUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUsers = new System.Windows.Forms.Label();
            this.cboVoiceChannels = new System.Windows.Forms.ComboBox();
            this.socketVoiceChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVoiceChannels = new System.Windows.Forms.Label();
            this.cboServers = new System.Windows.Forms.ComboBox();
            this.socketGuildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblServers = new System.Windows.Forms.Label();
            this.txtDurationTimeout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socketTextChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketGuildUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketVoiceChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketGuildBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(13, 12);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(38, 13);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(57, 9);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(358, 20);
            this.txtToken.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(421, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start bot";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpServers
            // 
            this.grpServers.Controls.Add(this.label1);
            this.grpServers.Controls.Add(this.txtDurationTimeout);
            this.grpServers.Controls.Add(this.btnCreateRole);
            this.grpServers.Controls.Add(this.txtColorRole);
            this.grpServers.Controls.Add(this.lblColorRole);
            this.grpServers.Controls.Add(this.lblNameRole);
            this.grpServers.Controls.Add(this.txtNameRole);
            this.grpServers.Controls.Add(this.btnTimeout);
            this.grpServers.Controls.Add(this.lblReason);
            this.grpServers.Controls.Add(this.chkLockTextChannel);
            this.grpServers.Controls.Add(this.chkLockVoiceChannel);
            this.grpServers.Controls.Add(this.txtReason);
            this.grpServers.Controls.Add(this.btnBan);
            this.grpServers.Controls.Add(this.cboTextChannels);
            this.grpServers.Controls.Add(this.cboRoles);
            this.grpServers.Controls.Add(this.lblTextChannels);
            this.grpServers.Controls.Add(this.lblRoles);
            this.grpServers.Controls.Add(this.cboUsers);
            this.grpServers.Controls.Add(this.lblUsers);
            this.grpServers.Controls.Add(this.cboVoiceChannels);
            this.grpServers.Controls.Add(this.lblVoiceChannels);
            this.grpServers.Location = new System.Drawing.Point(12, 62);
            this.grpServers.Name = "grpServers";
            this.grpServers.Size = new System.Drawing.Size(760, 210);
            this.grpServers.TabIndex = 4;
            this.grpServers.TabStop = false;
            this.grpServers.Text = "Server [name]";
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(520, 71);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRole.TabIndex = 15;
            this.btnCreateRole.Text = "Create role";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // txtColorRole
            // 
            this.txtColorRole.Location = new System.Drawing.Point(429, 73);
            this.txtColorRole.Name = "txtColorRole";
            this.txtColorRole.Size = new System.Drawing.Size(85, 20);
            this.txtColorRole.TabIndex = 14;
            // 
            // lblColorRole
            // 
            this.lblColorRole.AutoSize = true;
            this.lblColorRole.Location = new System.Drawing.Point(372, 76);
            this.lblColorRole.Name = "lblColorRole";
            this.lblColorRole.Size = new System.Drawing.Size(51, 13);
            this.lblColorRole.TabIndex = 13;
            this.lblColorRole.Text = "Color role";
            // 
            // lblNameRole
            // 
            this.lblNameRole.AutoSize = true;
            this.lblNameRole.Location = new System.Drawing.Point(220, 76);
            this.lblNameRole.Name = "lblNameRole";
            this.lblNameRole.Size = new System.Drawing.Size(55, 13);
            this.lblNameRole.TabIndex = 11;
            this.lblNameRole.Text = "Name role";
            // 
            // txtNameRole
            // 
            this.txtNameRole.Location = new System.Drawing.Point(281, 73);
            this.txtNameRole.Name = "txtNameRole";
            this.txtNameRole.Size = new System.Drawing.Size(85, 20);
            this.txtNameRole.TabIndex = 12;
            // 
            // btnTimeout
            // 
            this.btnTimeout.Location = new System.Drawing.Point(654, 44);
            this.btnTimeout.Name = "btnTimeout";
            this.btnTimeout.Size = new System.Drawing.Size(80, 23);
            this.btnTimeout.TabIndex = 10;
            this.btnTimeout.Text = "Timeout user";
            this.btnTimeout.UseVisualStyleBackColor = true;
            this.btnTimeout.Click += new System.EventHandler(this.btnTimeout_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(231, 51);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Reason";
            // 
            // chkLockTextChannel
            // 
            this.chkLockTextChannel.AutoSize = true;
            this.chkLockTextChannel.Location = new System.Drawing.Point(554, 21);
            this.chkLockTextChannel.Name = "chkLockTextChannel";
            this.chkLockTextChannel.Size = new System.Drawing.Size(111, 17);
            this.chkLockTextChannel.TabIndex = 9;
            this.chkLockTextChannel.Text = "Lock text channel";
            this.chkLockTextChannel.UseVisualStyleBackColor = true;
            this.chkLockTextChannel.CheckedChanged += new System.EventHandler(this.chkLockTextChannel_CheckedChanged);
            // 
            // chkLockVoiceChannel
            // 
            this.chkLockVoiceChannel.AutoSize = true;
            this.chkLockVoiceChannel.Location = new System.Drawing.Point(220, 21);
            this.chkLockVoiceChannel.Name = "chkLockVoiceChannel";
            this.chkLockVoiceChannel.Size = new System.Drawing.Size(120, 17);
            this.chkLockVoiceChannel.TabIndex = 8;
            this.chkLockVoiceChannel.Text = "Lock voice channel";
            this.chkLockVoiceChannel.UseVisualStyleBackColor = true;
            this.chkLockVoiceChannel.CheckedChanged += new System.EventHandler(this.chkLockVoiceChannel_CheckedChanged);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(281, 48);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(173, 20);
            this.txtReason.TabIndex = 7;
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(460, 46);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(75, 23);
            this.btnBan.TabIndex = 5;
            this.btnBan.Text = "Ban user";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // cboTextChannels
            // 
            this.cboTextChannels.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.socketTextChannelBindingSource, "Id", true));
            this.cboTextChannels.DataSource = this.socketTextChannelBindingSource;
            this.cboTextChannels.DisplayMember = "Name";
            this.cboTextChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTextChannels.FormattingEnabled = true;
            this.cboTextChannels.Location = new System.Drawing.Point(427, 19);
            this.cboTextChannels.Name = "cboTextChannels";
            this.cboTextChannels.Size = new System.Drawing.Size(121, 21);
            this.cboTextChannels.TabIndex = 6;
            this.cboTextChannels.ValueMember = "Id";
            this.cboTextChannels.SelectedValueChanged += new System.EventHandler(this.cboTextChannels_SelectedValueChanged);
            // 
            // socketTextChannelBindingSource
            // 
            this.socketTextChannelBindingSource.DataSource = typeof(Discord.WebSocket.SocketTextChannel);
            // 
            // cboRoles
            // 
            this.cboRoles.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.socketRoleBindingSource, "Id", true));
            this.cboRoles.DataSource = this.socketRoleBindingSource;
            this.cboRoles.DisplayMember = "Name";
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(93, 73);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(121, 21);
            this.cboRoles.TabIndex = 5;
            this.cboRoles.ValueMember = "Id";
            // 
            // socketRoleBindingSource
            // 
            this.socketRoleBindingSource.DataSource = typeof(Discord.WebSocket.SocketRole);
            // 
            // lblTextChannels
            // 
            this.lblTextChannels.AutoSize = true;
            this.lblTextChannels.Location = new System.Drawing.Point(346, 22);
            this.lblTextChannels.Name = "lblTextChannels";
            this.lblTextChannels.Size = new System.Drawing.Size(75, 13);
            this.lblTextChannels.TabIndex = 5;
            this.lblTextChannels.Text = "Text Channels";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(53, 76);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(34, 13);
            this.lblRoles.TabIndex = 4;
            this.lblRoles.Text = "Roles";
            // 
            // cboUsers
            // 
            this.cboUsers.DataSource = this.socketGuildUserBindingSource;
            this.cboUsers.DisplayMember = "Username";
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(93, 46);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(121, 21);
            this.cboUsers.TabIndex = 3;
            this.cboUsers.ValueMember = "Id";
            // 
            // socketGuildUserBindingSource
            // 
            this.socketGuildUserBindingSource.DataSource = typeof(Discord.WebSocket.SocketGuildUser);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(53, 51);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(34, 13);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Users";
            // 
            // cboVoiceChannels
            // 
            this.cboVoiceChannels.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.socketVoiceChannelBindingSource, "Id", true));
            this.cboVoiceChannels.DataSource = this.socketVoiceChannelBindingSource;
            this.cboVoiceChannels.DisplayMember = "Name";
            this.cboVoiceChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoiceChannels.FormattingEnabled = true;
            this.cboVoiceChannels.Location = new System.Drawing.Point(93, 19);
            this.cboVoiceChannels.Name = "cboVoiceChannels";
            this.cboVoiceChannels.Size = new System.Drawing.Size(121, 21);
            this.cboVoiceChannels.TabIndex = 1;
            this.cboVoiceChannels.ValueMember = "Id";
            this.cboVoiceChannels.SelectedValueChanged += new System.EventHandler(this.cboVoiceChannels_SelectedValueChanged);
            // 
            // socketVoiceChannelBindingSource
            // 
            this.socketVoiceChannelBindingSource.DataSource = typeof(Discord.WebSocket.SocketVoiceChannel);
            // 
            // lblVoiceChannels
            // 
            this.lblVoiceChannels.AutoSize = true;
            this.lblVoiceChannels.Location = new System.Drawing.Point(6, 22);
            this.lblVoiceChannels.Name = "lblVoiceChannels";
            this.lblVoiceChannels.Size = new System.Drawing.Size(81, 13);
            this.lblVoiceChannels.TabIndex = 0;
            this.lblVoiceChannels.Text = "Voice Channels";
            // 
            // cboServers
            // 
            this.cboServers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.socketGuildBindingSource, "Id", true));
            this.cboServers.DataSource = this.socketGuildBindingSource;
            this.cboServers.DisplayMember = "Name";
            this.cboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServers.FormattingEnabled = true;
            this.cboServers.Location = new System.Drawing.Point(57, 35);
            this.cboServers.Name = "cboServers";
            this.cboServers.Size = new System.Drawing.Size(121, 21);
            this.cboServers.TabIndex = 3;
            this.cboServers.ValueMember = "Id";
            this.cboServers.SelectedIndexChanged += new System.EventHandler(this.cboServers_SelectedIndexChanged);
            // 
            // socketGuildBindingSource
            // 
            this.socketGuildBindingSource.DataSource = typeof(Discord.WebSocket.SocketGuild);
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Location = new System.Drawing.Point(8, 38);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(43, 13);
            this.lblServers.TabIndex = 2;
            this.lblServers.Text = "Servers";
            // 
            // txtDurationTimeout
            // 
            this.txtDurationTimeout.Location = new System.Drawing.Point(594, 46);
            this.txtDurationTimeout.Name = "txtDurationTimeout";
            this.txtDurationTimeout.Size = new System.Drawing.Size(54, 20);
            this.txtDurationTimeout.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Duration";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cboServers);
            this.Controls.Add(this.grpServers);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lblToken);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Bot Discord Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpServers.ResumeLayout(false);
            this.grpServers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socketTextChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketGuildUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketVoiceChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketGuildBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpServers;
        private System.Windows.Forms.ComboBox cboVoiceChannels;
        private System.Windows.Forms.Label lblVoiceChannels;
        private System.Windows.Forms.ComboBox cboServers;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.BindingSource socketGuildBindingSource;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.ComboBox cboTextChannels;
        private System.Windows.Forms.Label lblTextChannels;
        private System.Windows.Forms.BindingSource socketTextChannelBindingSource;
        private System.Windows.Forms.BindingSource socketRoleBindingSource;
        private System.Windows.Forms.BindingSource socketGuildUserBindingSource;
        private System.Windows.Forms.BindingSource socketVoiceChannelBindingSource;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.CheckBox chkLockVoiceChannel;
        private System.Windows.Forms.CheckBox chkLockTextChannel;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnTimeout;
        private System.Windows.Forms.Label lblNameRole;
        private System.Windows.Forms.TextBox txtNameRole;
        private System.Windows.Forms.TextBox txtColorRole;
        private System.Windows.Forms.Label lblColorRole;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDurationTimeout;
    }
}

