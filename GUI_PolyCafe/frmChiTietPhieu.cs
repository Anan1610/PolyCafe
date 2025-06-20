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
    public partial class frmChiTietPhieu : Form
    {
        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NhanVien nhanVien;
        private List<ChiTietPhieu> lstChiTiet;
        private List<SanPham> lstSanPham;
        bool isActive = true;
        public frmChiTietPhieu(TheLuuDong the, PhieuBanHang phieu, NhanVien nv)
        {
            InitializeComponent();
            theLuuDong = the;
            phieuBanHang = phieu;
            nhanVien = nv;
            lstChiTiet = new List<ChiTietPhieu>();
            lstSanPham = new List<SanPham>();
            isActive = phieu.TrangThai;
        }
        private void activeTranfer()
        {
            if (isActive)
            {
                btnThemChiTiet.Enabled = false;
                btnXoaChiTiet.Enabled = false;
                //txtPhanTram.Enabled = false;
            }
        }

        private void LoadInfo()
        {
            lbChuSoHuu.Text = $"{theLuuDong.MaThe} - {theLuuDong.ChuSoHuu}";
            lbMaPhieu.Text = phieuBanHang.MaPhieu;
            lbNgayLap.Text = phieuBanHang.NgayTao.ToString("dd/MM/yyyy");
        }
        private void loadSanPham()
        {
            BUS_SanPham sp = new BUS_SanPham();
            lstSanPham = sp.GetSanPhamList(1);
            dgvSanPham.DataSource = lstSanPham;
            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvSanPham.Columns["TenLoai"].HeaderText = "Loại Sản Phẩm";
            dgvSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";


            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadChiTietPhieu(string maPhieu)
        {
            BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
            lstChiTiet = bus.GetChiTietPhieuList(maPhieu);
            dgvChiTietPhieu.DataSource = lstChiTiet;
            dgvChiTietPhieu.Columns["MaChiTiet"].Visible = false;
            dgvChiTietPhieu.Columns["MaPhieu"].Visible = false;
            dgvChiTietPhieu.Columns["MaSanPham"].Visible = false;
            dgvChiTietPhieu.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            dgvChiTietPhieu.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTietPhieu.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvChiTietPhieu.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvChiTietPhieu.Columns["SoLuong"].ReadOnly = false;

            dgvChiTietPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dgvChiTietPhieu.Columns)
            {
                col.ReadOnly = true;
            }
            dgvChiTietPhieu.Columns["SoLuong"].ReadOnly = false;
        }
        private void loadThanhToan()
        {
            // Tính tổng tiền từ danh sách ChiTietPhieu
            decimal tong = lstChiTiet.Sum(ct => ct.ThanhTien);
            txtTong.Text = tong.ToString("N0");

            // Lấy phần trăm giảm giá
            decimal phanTramGiam = 0;
            decimal.TryParse(txtPhanTram.Text, out phanTramGiam);

            // Tính số tiền giảm
            decimal tienGiam = tong * phanTramGiam / 100;
            txtGiamGia.Text = tienGiam.ToString("N0");

            // Lấy phí dịch vụ
            decimal phiDichVu = 0;
            decimal.TryParse(txtDichVu.Text, out phiDichVu);

            // Tính thành tiền cuối cùng
            decimal thanhTien = tong - tienGiam + phiDichVu;
            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        private void frmChiTietPhieu_Load(object sender, EventArgs e)
        {
            loadThanhToan();
            LoadInfo();
            loadSanPham();
            loadChiTietPhieu(phieuBanHang.MaPhieu);
            activeTranfer();
        }
        private void transfer(SanPham sp, int soLuong = 1)
        {
            if (isActive)
            {
                return;
            }
            if (sp != null)
            {
                BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                ChiTietPhieu existingItem = lstChiTiet.FirstOrDefault(item => item.MaSanPham == sp.MaSanPham);
                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    string result = bus.UpdateChiTietPhieu(existingItem);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ChiTietPhieu ct = new ChiTietPhieu()
                    {
                        MaPhieu = phieuBanHang.MaPhieu,
                        MaSanPham = sp.MaSanPham,
                        SoLuong = soLuong,
                        DonGia = sp.DonGia,
                    };
                    string result = bus.InsertChiTietPhieu(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadChiTietPhieu(phieuBanHang.MaPhieu);
            }
        }
        private void deleteChiTiet()
        {
            if (dgvChiTietPhieu.CurrentRow != null)
            {
                string id = Convert.ToString(dgvChiTietPhieu.CurrentRow.Cells["MaChiTiet"].Value);
                string name = Convert.ToString(dgvChiTietPhieu.CurrentRow.Cells["TenSanPham"].Value);
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phầm {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                    string kq = bus.DeleteChiTiet(id); ;
                    if (string.IsNullOrEmpty(kq))
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }
                }
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                // Tạo đối tượng từ dữ liệu hàng
                SanPham sanPham = new SanPham
                {
                    MaSanPham = row.Cells["MaSanPham"].Value.ToString(),
                    TenSanPham = row.Cells["TenSanPham"].Value.ToString(),
                    DonGia = Convert.ToInt32(row.Cells["DonGia"].Value)
                };

                transfer(sanPham);
            }
        }

        private void dgvChiTietPhieu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                ChiTietPhieu ct = lstChiTiet[e.RowIndex];
                int newQuantity;
                if (int.TryParse(dgvChiTietPhieu.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString(), out newQuantity))
                {
                    ct.SoLuong = newQuantity;
                    string result = bus.UpdateChiTietPhieu(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Đảm bảo ko lỗi khi đang edit mà chuyển ô
                    this.BeginInvoke((Action)(() =>
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (dgvSanPham.CurrentRow != null)
            {
                string id = Convert.ToString(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);
                string ten = Convert.ToString(dgvSanPham.CurrentRow.Cells["TenSanPham"].Value);
                decimal dongia = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["DonGia"].Value);
                SanPham sanPham = new SanPham
                {
                    MaSanPham = id,
                    TenSanPham = ten,
                    DonGia = dongia
                };

                transfer(sanPham);
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            deleteChiTiet();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            loadThanhToan();
        }
    }
}
