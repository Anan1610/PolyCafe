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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public NhanVien DangNhap (string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            return dalNhanVien.getNhanVien1(username, password);
        }
        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                dalNhanVien.ResetMatKhau(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<NhanVien> GetNhanVienList()
        {
            return dalNhanVien.selectAll();
        }
        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                nv.MaNhanVien = dalNhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }
                if (dalNhanVien.checkEmailExists(nv.Email))
                {
                    return "Email đã tồn tại.";
                }
                dalNhanVien.insertNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdateNhanVien(NhanVien nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalNhanVien.updateNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string DeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalNhanVien.deleteNhanVien(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<NhanVien> TimKiemNhanVien(string tuKhoa)
        {
            List<NhanVien> danhSach = new List<NhanVien>();
            string connectionString = @"Data Source=PHAMTRANANAN\SQLEXPRESS01;Initial Catalog=PolyCafe1;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhanVien WHERE MaNhanVien LIKE @tuKhoa OR HoTen LIKE @tuKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        VaiTro = Convert.ToBoolean(reader["VaiTro"]),
                        TrangThai = Convert.ToBoolean(reader["TrangThai"])
                    };
                    danhSach.Add(nv);
                }
                reader.Close();
            }

            return danhSach;
        }

    }
}
