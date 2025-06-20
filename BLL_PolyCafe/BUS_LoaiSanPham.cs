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
    public class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dalLoaiSanPham = new DAL_LoaiSanPham();

        public List<LoaiSanPham> GetLoaiSanPhamList()
        {
            return dalLoaiSanPham.selectAll();
        }


        public string InsertLoaiSanPham(LoaiSanPham loaiSP)
        {
            try
            {
                loaiSP.MaLoai = dalLoaiSanPham.generateMaLoaiSanPham();
                if (string.IsNullOrEmpty(loaiSP.MaLoai))
                {
                    return "Mã loại sản phẩm không hợp lệ.";
                }

                dalLoaiSanPham.insertLoaiSanPham(loaiSP);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateLoaiSanPham(LoaiSanPham loaiSP)
        {
            try
            {
                if (string.IsNullOrEmpty(loaiSP.MaLoai))
                {
                    return "Mã loại sản phẩm không hợp lệ.";
                }

                dalLoaiSanPham.updateLoaiSanPham(loaiSP);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteLoaiSanPham(string maloaiSP)
        {
            try
            {
                if (string.IsNullOrEmpty(maloaiSP))
                {
                    return "Mã loại sản phẩm không hợp lệ.";
                }

                dalLoaiSanPham.deleteLoaiSanPham(maloaiSP);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<LoaiSanPham> TimKiemLoaiSanPham(string tuKhoa)
        {
            List<LoaiSanPham> danhSach = new List<LoaiSanPham>();
            string connectionString = @"Data Source=PHAMTRANANAN\SQLEXPRESS01;Initial Catalog=PolyCafe1;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LoaiSanPham WHERE MaLoai LIKE @tuKhoa OR TenLoai LIKE @tuKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LoaiSanPham lsp = new LoaiSanPham
                    {
                        MaLoai = reader["MaLoai"].ToString(),
                        TenLoai = reader["TenLoai"].ToString(),
                        GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "" : reader.GetString(reader.GetOrdinal("GhiChu"))
                    };
                    danhSach.Add(lsp);
                }
                reader.Close();
            }

            return danhSach;
        }
    }
}
