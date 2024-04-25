using System;
using System.Windows.Forms;

namespace BotDiscordManager
{
    internal static class Program
    {
        public static frmMain frm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frm = new frmMain());
        }
    }
}
