using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class TKDoanhThuTheoNhanVien
    {
        public string? MaNhanVien { get; set; }
        public string? HoTen { get; set; }
        public int SoLy { get; set; }            // ✅ Được hiểu là tổng số ly (tổng số lượng bán)
        public string NgayBan { get; set; } = string.Empty;
        public int SoLuongPhieu { get; set; }
        public string TongTien { get; set; } = string.Empty;
        public string DaThanhToan { get; set; } = string.Empty;
    }
}
