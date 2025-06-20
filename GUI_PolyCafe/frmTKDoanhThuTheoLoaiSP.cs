using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DAL_PolyCafe;
using DTO_PolyCafe;
using UTIL_PolyCafe;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Data.SqlClient;

namespace GUI_PolyCafe
{
    public partial class frmTKDoanhThuTheoLoaiSP : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public frmTKDoanhThuTheoLoaiSP()
        {
            InitializeComponent();
        }
        private void frmTKDoanhThuTheoLoaiSP_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtpTuNgay.Value = firstDayOfMonth;
            LoadLoaiSanPham();
            btnThongKe_Click(sender, e);
        }
        private void LoadLoaiSanPham()
        {
            try
            {
                BUS_LoaiSanPham busLoaiSanPham = new BUS_LoaiSanPham();
                List<LoaiSanPham> dsLoai = busLoaiSanPham.GetLoaiSanPhamList();

                // Thêm mục "Tất cả"
                dsLoai.Insert(0, new LoaiSanPham { MaLoai = string.Empty, TenLoai = "--Tất Cả--", GhiChu = "" });

                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.ValueMember = "MaLoai";
                cboLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại sản phẩm: " + ex.Message);
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maLoai = cboLoaiSanPham.SelectedValue.ToString();
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDenNgay.Value;

            var data = busThongKe.GetDoanhThuTheoLoai(maLoai, tuNgay, denNgay);
            dgvDanhSachThongKe.DataSource = data;
        }

        private void dgvDanhSachThongKe_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachThongKe.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvDanhSachThongKe.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvDanhSachThongKe.Columns["SoLy"].HeaderText = "Số ly";
            dgvDanhSachThongKe.Columns["SoLuongPhieu"].HeaderText = "Số lượng phiếu";
            dgvDanhSachThongKe.Columns["NgayBan"].HeaderText = "Ngày bán";
            dgvDanhSachThongKe.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvDanhSachThongKe.Columns["DaThanhToan"].HeaderText = "Đã thanh toán";
        }
    }
}
