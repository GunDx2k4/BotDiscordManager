using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDiscordManager.Core.Locales
{
    public class Vietnamese
    {
        public static void load()
        {
            Resources.UNMET_PERCONDITON = "Bạn không đủ điều kiện:";
            Resources.UNKNOW_COMMAND = "Lệnh không xác định.";
            Resources.BAD_ARGS = "Số hoặc tham số không hợp lệ.";
            Resources.EXCEPTION = "Lệnh ngoại lệ:";
            Resources.UNSUCCESSFULL = "Lệnh Không thể thực thi.";
            Resources.UNKNOW_ERROR = "Lỗi không xác định:";
            Resources.NOT_GUILD_ERROR_MESSAGE = "Lệnh phải được dùng trong kênh guild.";
            Resources.NOT_PERMISSION_USER = "Bạn không có quyền ";
            Resources.NOT_PERMISSION_BOT = "Bot không có quyền ";
            Resources.USER_NOT_PERMISSION_CHANNEL = "Bạn không có quyền truy cập kênh ";
            Resources.BOT_NOT_PERMISSION_CHANNEL = "Bot không có quyền truy cập kênh ";
        }
    }
}
