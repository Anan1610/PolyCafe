using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe
{
    public class DAL_ChiTietPhieu
    {
        public string generateChiTietID()
        {
            string prefix = "CTP";
            string sql = "SELECT MAX(MaChiTiet) FROM ChiTietPhieu";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(3);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public List<ChiTietPhieu> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<ChiTietPhieu> list = new List<ChiTietPhieu>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    ChiTietPhieu entity = new ChiTietPhieu
                    {
                        MaChiTiet = reader["MaChiTiet"].ToString(),
                        MaPhieu = reader["MaPhieu"].ToString(),
                        MaSanPham = reader["MaSanPham"].ToString(),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGia"])
                    };

                    // Kiểm tra xem cột "TenSanPham" có tồn tại không
                    if (reader.GetSchemaTable().Rows.Cast<DataRow>().Any(r => r["ColumnName"].ToString() == "TenSanPham"))
                    {
                        entity.TenSanPham = reader["TenSanPham"].ToString();
                    }

                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }


        public List<ChiTietPhieu> selectChiTietByMaPhieu(string maPhieu)
        {
            string sql = @"SELECT ct.MaChiTiet, ct.MaPhieu, ct.MaSanPham, ct.SoLuong, ct.DonGia, sp.TenSanPham
               FROM ChiTietPhieu ct
               INNER JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
               WHERE ct.MaPhieu = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(maPhieu);
            return SelectBySql(sql, thamSo);
        }
        public bool exists(int id)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietPhieu WHERE MaChiTietPhieu = @0";
            List<object> parameters = new List<object> { id };
            object result = DBUtil.ScalarQuery(sql, parameters);

            int count = Convert.ToInt32(result);
            return count > 0;
        }


        public void insertChiTiet(ChiTietPhieu ct)
        {
            try
            {
                string sql = @"INSERT INTO ChiTietPhieu (MaChiTiet, MaPhieu, MaSanPham, SoLuong, DonGia) VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>();
                thamSo.Add(ct.MaChiTiet);
                thamSo.Add(ct.MaPhieu);
                thamSo.Add(ct.MaSanPham);
                thamSo.Add(ct.SoLuong);
                thamSo.Add(ct.DonGia);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void insertListChiTiet(List<ChiTietPhieu> lstChiTiet)
        {
            try
            {
                foreach (ChiTietPhieu item in lstChiTiet)
                {
                    insertChiTiet(item);
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateChiTietPhieu(ChiTietPhieu ct)
        {
            try
            {
                string sql = @"UPDATE ChiTietPhieu 
                   SET SoLuong = @1 
                   WHERE MaChiTiet = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(ct.MaChiTiet);
                thamSo.Add(ct.SoLuong);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void deleteChiTietPhieu(string Id)
        {
            try
            {
                string sql = "DELETE FROM ChiTietPhieu WHERE MaChiTiet = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(Id);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
