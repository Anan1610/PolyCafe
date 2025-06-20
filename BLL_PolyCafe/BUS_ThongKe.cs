using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace BLL_PolyCafe
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dal = new DAL_ThongKe();

        public List<TKDoanhThuTheoLoaiSP> GetDoanhThuTheoLoai(string maLoai, DateTime tuNgay, DateTime denNgay)
        {
            return dal.LayDoanhThuTheoLoai(maLoai, tuNgay, denNgay);
        }
        public List<TKDoanhThuTheoNhanVien> GetDoanhThuTheoNhanVien(string maLoai, DateTime tuNgay, DateTime denNgay)
        {
            return dal.LayDoanhThuTheoNhanVien(maLoai, tuNgay, denNgay);
        }
    }
}
