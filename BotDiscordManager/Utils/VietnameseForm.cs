using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDiscordManager.Utils
{
    public class VietnameseForm
    {
        public static void load()
        {
            ResourcesForm.MESSAGE_BOX_NOTIFY = "Thông báo";
            ResourcesForm.WATTING_LOAD = "Đợi chút lát, đang tải dữ liệu ....";
            ResourcesForm.TOKEN_PRECONDITION = "Chưa điền token bot !";
            ResourcesForm.COMPLETED_BAN_USER = "Đã ban {0}[{1}] tại server {2} !";
            ResourcesForm.ERROR_TIMESPAN = "Điền thời gian không hợp lệ, điền theo dạng (1s: 1 giây, 1m: 1 phút, 1d: 1 ngày, 1w: 1 tuần) !";
            ResourcesForm.COMPETED_TIMEOUT_USER = "Đã timeout {0}[{1}] tại server {2} với thời gian {3} !";
            ResourcesForm.NAME_ROLE_PRECONDITION = "Chưa điền tên role cần tạo !";
            ResourcesForm.COMPETED_CREATE_ROLE = "Đã thên role {0} tại server {1} !";
        }
    }
}
