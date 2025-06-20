using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTIL_PolyCafe
{
    public static class DateUtil
    {
        // Chuyển đổi chuỗi thành DateTime với định dạng cụ thể
        public static DateTime ToDateTime(string dateStr, string format)
        {
            return DateTime.ParseExact(dateStr, format, CultureInfo.InvariantCulture);
        }

        // Chuyển DateTime thành chuỗi theo định dạng cụ thể
        public static string ToString(DateTime date, string format)
        {
            return date.ToString(format);
        }

        // Hàm kiểm tra chuỗi có phải định dạng ngày hay không
        public static bool IsValidDate(string dateStr, string format)
        {
            return DateTime.TryParseExact(dateStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        // Trả về ngày hiện tại dạng chuỗi
        public static string GetTodayString(string format = "dd/MM/yyyy")
        {
            return DateTime.Now.ToString(format);
        }
    }
}
