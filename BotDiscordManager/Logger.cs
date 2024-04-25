using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotDiscordManager
{
    public class Logger
    {
        private static void SetColorForLine(string line, Color color)
        {
            Program.frm.rtxtLog.BeginInvoke((MethodInvoker)delegate ()
            {
                Program.frm.rtxtLog.SelectionStart = Program.frm.rtxtLog.TextLength;
                Program.frm.rtxtLog.SelectionLength = 0;

                Program.frm.rtxtLog.SelectionColor = color;
                Program.frm.rtxtLog.AppendText($"[{DateTime.Now.ToString("dd/MM/yyyy h:mm tt")}] " + line + "\n\n");
                Program.frm.rtxtLog.SelectionColor = Program.frm.rtxtLog.ForeColor;
            });
        }

        public static void Debug(string log)
        {
            SetColorForLine(log, Color.Green);
        }

        public static void Warning(string log)
        {
            SetColorForLine(log, Color.Yellow);
        }

        public static void Error(string log)
        {
            SetColorForLine(log, Color.Red);
        }

        public static void Info(string log)
        {
            SetColorForLine(log, Program.frm.rtxtLog.ForeColor);
        }
    }
}
