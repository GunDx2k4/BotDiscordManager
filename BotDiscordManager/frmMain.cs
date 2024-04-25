using BotDiscordManager.Core.Bot;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BotDiscordManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtToken.Text))
            {
                MessageBox.Show("Chưa điền token bot !", "Thông báo");
                return;
            }

            Config.TOKEN_BOT = txtToken.Text;
            if(BotDiscord.gI().isStarted)
            {
                BotDiscord.gI().DisconnectBotAsync().GetAwaiter();
                return;
            }
            BotDiscord.gI().ConnectBotAsync().GetAwaiter();
        }
    }
}
