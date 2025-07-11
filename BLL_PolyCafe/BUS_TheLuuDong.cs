﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace BLL_PolyCafe
{
    public class BUS_TheLuuDong
    {
        DAL_TheLuuDong dalTheLuuDong = new DAL_TheLuuDong();

        public List<TheLuuDong> GetTheLuuDongList()
        {
            return dalTheLuuDong.selectAll();
        }


        public string InsertTheLuuDong(TheLuuDong the)
        {
            try
            {
                the.MaThe = dalTheLuuDong.generateMaTheLuuDong();
                if (string.IsNullOrEmpty(the.MaThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dalTheLuuDong.insertTheLuuDong(the);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateTheLuuDong(TheLuuDong nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dalTheLuuDong.updateTheLuuDong(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteTheLuuDong(string maThe)
        {
            try
            {
                if (string.IsNullOrEmpty(maThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dalTheLuuDong.deleteTheLuuDong(maThe);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public List<TheLuuDong> TimKiemTheLuuDong(string tuKhoa)
        {
            List<TheLuuDong> danhSach = new List<TheLuuDong>();
            string connectionString = @"Data Source=PHAMTRANANAN\SQLEXPRESS01;Initial Catalog=PolyCafe1;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TheLuuDong WHERE MaThe LIKE @tuKhoa OR ChuSoHuu LIKE @tuKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TheLuuDong lsp = new TheLuuDong
                    {
                        MaThe = reader["MaThe"].ToString(),
                        ChuSoHuu = reader["ChuSoHuu"].ToString(),
                        TrangThai = reader.GetBoolean(reader.GetOrdinal("TrangThai"))
                    };
                    danhSach.Add(lsp);
                }
                reader.Close();
            }

            return danhSach;
        }
    }
}
