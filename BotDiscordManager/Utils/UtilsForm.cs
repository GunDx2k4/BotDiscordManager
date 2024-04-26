using System;

namespace BotDiscordManager.Utils
{
    public class UtilsForm
    {
        public static TimeSpan ConvertToTimeSpan(string timeSpan)
        {
            var l = timeSpan.Length - 1;
            var value = timeSpan.Substring(0, l);
            var type = timeSpan.Substring(l, 1);

            switch (type)
            {
                case "s": return TimeSpan.FromSeconds(double.Parse(value));
                case "m": return TimeSpan.FromMinutes(double.Parse(value));
                case "h": return TimeSpan.FromHours(double.Parse(value));
                case "d": return TimeSpan.FromDays(double.Parse(value));
                case "w": return TimeSpan.FromDays(double.Parse(value) * 7);
            }
            return TimeSpan.Zero;
        }

        public static uint ConvertToUInt(string colorHex)
        {
            if(!colorHex.StartsWith("#")) return 0;
            return Convert.ToUInt32(colorHex.Replace("#", ""), 16);
        }
    }
}
