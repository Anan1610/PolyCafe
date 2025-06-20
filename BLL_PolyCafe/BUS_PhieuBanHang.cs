using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace BLL_PolyCafe
{
    public class BUS_PhieuBanHang
    {
        DAL_PhieuBanHang dalPhieuBanHang = new DAL_PhieuBanHang();
        public List<PhieuBanHang> GetListPhieuBanHang(string maThe)
        {
            return dalPhieuBanHang.selectAll(maThe);
        }
        public List<NhanVien> getAllNhanVien()
        {
            String sql = "SELECT * FROM NhanVien";
            List<NhanVien> danhSach = new List<NhanVien>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, new List<Object>());
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien()
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString()
                    };
                    danhSach.Add(nv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
            return danhSach;
        }

        public string InsertPhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                pbh.MaPhieu = dalPhieuBanHang.generateMaPhieu();
                if (string.IsNullOrEmpty(pbh.MaPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.insertPhieuBanHang(pbh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdatePhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                if (string.IsNullOrEmpty(pbh.MaPhieu))
                {
                    return "Mã phiếu không hợp lệ.";
                }

                dalPhieuBanHang.updatePhieuBanHang(pbh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeletePhieuBanHang(string maPhieu)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.deletePhieuBanHang(maPhieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
