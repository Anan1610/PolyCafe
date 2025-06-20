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
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmTKDoanhThuTheoNhanVien : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public frmTKDoanhThuTheoNhanVien()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maLoai = cboNhanVien.SelectedValue.ToString();
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDenNgay.Value;

            var data = busThongKe.GetDoanhThuTheoNhanVien(maLoai, tuNgay, denNgay);
            dgvDanhSachThongKe.DataSource = data;
        }

        private void frmTKDoanhThuTheoNhanVien_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtpTuNgay.Value = firstDayOfMonth;
            LoadNhanVien();
            btnThongKe_Click(sender, e);
        }
        private void LoadNhanVien()
        {
            try
            {
                BUS_NhanVien busNhanVien = new BUS_NhanVien();
                List<NhanVien> dsNhanVien = busNhanVien.GetNhanVienList();

                // Thêm mục "--Tất Cả--"
                dsNhanVien.Insert(0, new NhanVien { MaNhanVien = "", HoTen = "--Tất Cả--" });

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.ValueMember = "MaNhanVien";
                cboNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void dgvDanhSachThongKe_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachThongKe.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvDanhSachThongKe.Columns["HoTen"].HeaderText = "Tên nhân viên";
            dgvDanhSachThongKe.Columns["SoLy"].HeaderText = "Số ly";
            dgvDanhSachThongKe.Columns["SoLuongPhieu"].HeaderText = "Số lượng phiếu";
            dgvDanhSachThongKe.Columns["NgayBan"].HeaderText = "Ngày bán";
            dgvDanhSachThongKe.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvDanhSachThongKe.Columns["DaThanhToan"].HeaderText = "Đã thanh toán";
        }
    }
}
