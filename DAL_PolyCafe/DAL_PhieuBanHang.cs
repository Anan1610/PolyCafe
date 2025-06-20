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
    public class DAL_PhieuBanHang
    {
        public string generateMaPhieu()
        {
            string prefix = "PBH";
            string sql = "SELECT MAX(MaPhieu) FROM PhieuBanHang";
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

        public void insertPhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                string sql = @"INSERT INTO PhieuBanHang (MaPhieu, MaThe, MaNhanVien, NgayTao, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>();
                thamSo.Add(pbh.MaPhieu);
                thamSo.Add(pbh.MaThe);
                thamSo.Add(pbh.MaNhanVien);
                thamSo.Add(pbh.NgayTao);
                thamSo.Add(pbh.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void updatePhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                string sql = @"UPDATE PhieuBanHang 
                   SET MaThe = @1, MaNhanVien = @2, NgayTao = @3, TrangThai = @4 
                   WHERE MaPhieu = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(pbh.MaPhieu);
                thamSo.Add(pbh.MaThe);
                thamSo.Add(pbh.MaNhanVien);
                thamSo.Add(pbh.NgayTao);
                thamSo.Add(pbh.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public void deletePhieuBanHang(string maPhieu)
        {
            try
            {
                string sql = "DELETE FROM PhieuBanHang WHERE MaPhieu = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maPhieu);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public bool hasChiTietPhieu(string maPhieu)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietPhieu WHERE MaPhieu = @0";
            List<object> thamSo = new List<object> { maPhieu };
            try
            {
                object result = DBUtil.ScalarQuery(sql, thamSo);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public bool exists(string maPhieu)
        {
            string sql = "SELECT COUNT(*) FROM PhieuBanHang WHERE MaPhieu = @0";
            List<object> args = new List<object> { maPhieu };
            int count = (int)DBUtil.ScalarQuery(sql, args);
            return count > 0;
        }
        public bool GetTrangThai(string maPhieu)
        {
            string query = "SELECT TrangThai FROM PhieuBanHang WHERE MaPhieu = @0";
            var result = DBUtil.ScalarQuery(query, new List<object> { maPhieu });
            return result != null && Convert.ToBoolean(result);
        }
        public List<PhieuBanHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhieuBanHang> list = new List<PhieuBanHang>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    PhieuBanHang entity = new PhieuBanHang();
                    entity.MaPhieu = reader.GetString("MaPhieu");
                    entity.MaThe = reader.GetString("MaThe");
                    entity.ChuSoHuu = reader.GetString("ChuSoHuu");
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.HoTen = reader.GetString("HoTen");
                    entity.NgayTao = reader.GetDateTime("NgayTao");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<PhieuBanHang> selectAll(string maThe)
        {
            //String sql = "SELECT * FROM PhieuBanHang";
            List<object> param = new List<object>();
            string sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
                "FROM PhieuBanHang phieu INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
                "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe";
            if (!string.IsNullOrEmpty(maThe))
            {
                sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
               "FROM PhieuBanHang phieu INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
               "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe " +
               "WHERE the.MaThe = @0";
                param.Add(maThe);
            }
            return SelectBySql(sql, param);
        }
        public PhieuBanHang getPhieuByMa(string maPhieu)
        {
            string sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
                "FROM PhieuBanHang phieu " +
                "INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
                "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe " +
                "WHERE phieu.MaPhieu = @0";
            List<object> param = new List<object> { maPhieu };
            return SelectBySql(sql, param).FirstOrDefault();
        }
    }
}
