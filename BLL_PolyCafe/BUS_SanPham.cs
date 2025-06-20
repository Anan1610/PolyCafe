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
    public class BUS_SanPham
    {
        DAL_SanPham dalSanPham = new DAL_SanPham();

        public List<SanPham> GetSanPhamList(int trangThai = -1)
        {
            return dalSanPham.selectAll(trangThai);
        }


        public string InsertSanPham(SanPham sp)
        {
            try
            {
                sp.MaSanPham = dalSanPham.generateMaSanPham();
                if (string.IsNullOrEmpty(sp.MaSanPham))
                {
                    return "Mã sản phẩm không hợp lệ.";
                }

                dalSanPham.insertSanPham(sp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateSanPham(SanPham sp)
        {
            try
            {
                if (string.IsNullOrEmpty(sp.MaSanPham))
                {
                    return "Mã sản phẩm không hợp lệ.";
                }

                if (sp.HinhAnh == null)
                {
                    sp.HinhAnh = "";
                }

                dalSanPham.updateSanPham(sp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteSanPham(string maSP)
        {
            try
            {
                if (string.IsNullOrEmpty(maSP))
                {
                    return "Mã sản phẩm không hợp lệ.";
                }

                dalSanPham.deleteSanPham(maSP);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<SanPham> TimKiemSanPham(string tuKhoa)
        {
            List<SanPham> danhSach = new List<SanPham>();
            string connectionString = @"Data Source=PHAMTRANANAN\SQLEXPRESS01;Initial Catalog=PolyCafe1;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham WHERE MaSanPham LIKE @tuKhoa OR TenSanPham LIKE @tuKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham
                    {
                        MaSanPham = reader["MaSanPham"].ToString(),
                        TenSanPham = reader["TenSanPham"].ToString(),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        MaLoai = reader["MaLoai"].ToString(),
                        HinhAnh = reader["HinhAnh"].ToString(),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    };
                    danhSach.Add(sp);
                }
                reader.Close();
            }
            return danhSach;
        }
    }
}
