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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PolyCafe
{
    public partial class frmPhieuBanHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        private DAL_PhieuBanHang dalPhieuBanHang = new DAL_PhieuBanHang();
        private DAL_ChiTietPhieu dalChiTietPhieu = new DAL_ChiTietPhieu();
        private DAL_SanPham dalSanPham = new DAL_SanPham();
        private DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NhanVien nhanVien;
        private List<NhanVien> lstNhanVien;
        private List<TheLuuDong> lstThe;
        private List<PhieuBanHang> lstPhieu;
        private List<ChiTietPhieu> lstChiTiet;
        private List<SanPham> lstSanPham;
        bool isActive = true;
        public frmPhieuBanHang()
        {
            InitializeComponent();
        }
        private void LoadPhieuBanHang()
        {
            dgvPhieuBanHang.DataSource = dalPhieuBanHang.selectAll("");
        }
        private void LoadChiTietPhieu(string maPhieu)
        {
            List<ChiTietPhieu> chiTietList =
                dalChiTietPhieu.SelectBySql("SELECT * FROM ChiTietPhieu WHERE MaPhieu = @0",
                new List<object> { maPhieu });
            //dgvChiTietPhieu.DataSource = chiTietList;
        }
        private void LoadSanPham()
        {
            try
            {
                List<SanPham> ds = dalSanPham.selectAll(); // hoặc BUS_SanPham nếu dùng
                cboSanPham.DataSource = ds;
                cboSanPham.DisplayMember = "TenSanPham";
                cboSanPham.ValueMember = "MaSanPham";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load sản phẩm: " + ex.Message);
            }
        }

        private void LoadNhanVien()
        {
            try
            {
                BUS_NhanVien busNhanVien = new BUS_NhanVien();
                List<NhanVien> dsLoai = busNhanVien.GetNhanVienList();
                if (AuthUtil.user.VaiTro)
                {
                    dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cboNhanVien.Enabled = false;
                }
                cboNhanVien.DataSource = dsLoai;
                cboNhanVien.ValueMember = "MaNhanVien";
                cboNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BUS_TheLuuDong busTheLuuDong = new BUS_TheLuuDong();
            List<TheLuuDong> lst = busTheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cboMaThe.DataSource = lst;
            cboMaThe.ValueMember = "MaThe";
            cboMaThe.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }

        private void LoadDanhSachPhieu(string maThe)
        {
            BUS_PhieuBanHang busPhieuBanHang = new BUS_PhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUtil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cboNhanVien.Enabled = false;
            }
            dgvPhieuBanHang.DataSource = lst;
            dgvPhieuBanHang.Columns["MaPhieu"].HeaderText = "Mã Phiếu Bán Hàng";
            dgvPhieuBanHang.Columns["MaThe"].HeaderText = "Mã Thẻ Lưu Động";
            dgvPhieuBanHang.Columns["ChuSoHuu"].HeaderText = "Chủ Sở Hữu";
            dgvPhieuBanHang.Columns["HoTen"].HeaderText = "Tên Nhân Viên";
            dgvPhieuBanHang.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvPhieuBanHang.Columns["NgayTao"].HeaderText = "Ngày Tạo Phiếu";
            dgvPhieuBanHang.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvPhieuBanHang.Columns["TrangThai"].DefaultCellStyle.Format = "Trạng Thái";
            dgvPhieuBanHang.Columns["TrangThai"].DefaultCellStyle.NullValue = "Chưa Thanh Toán";


            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.Name = "ThanhToan";
            buttonColumn.HeaderText = "Thanh Toán";
            //buttonColumn.Text = "Thanh Toán";
            //buttonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản lên nút
            //buttonColumn.Image = Properties.Resources.pay;
            buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;

            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            if (!dgvPhieuBanHang.Columns.Contains("ThanhToan"))
            {
                dgvPhieuBanHang.Columns.Add(buttonColumn);
            }
            dgvPhieuBanHang.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvPhieuBanHang.RowTemplate.Height = 50;

            dgvPhieuBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ClearPhieuBanHang(string msThe)
        {
            //txtMaPhieu.Clear();
            cboMaThe.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            dtpNgayTao.Value = DateTime.Now;
            rdoConfirmation.Checked = true;
            btnThemPhieu.Enabled = true;
            btnSuaPhieu.Enabled = false;
            btnXoaPhieu.Enabled = false;
            cboNhanVien.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdoConfirmation.Enabled = true;
            rdoPaid.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdoConfirmation.Checked = true;
        }
        private void ClearChiTietPhieu()
        {
            cboSanPham.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
        }
        private void frmPhieuBanHang1_Load(object sender, EventArgs e)
        {
            ClearPhieuBanHang("");
            ClearChiTietPhieu();
            LoadPhieuBanHang();
            LoadNhanVien();
            LoadTheLuuDong();
            LoadSanPham();
            LoadDanhSachPhieu(string.Empty);
            LoadChiTietPhieu(string.Empty);
        }
        private void dgvPhieuBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isLoadingTheLuuDongData = true;
                DataGridViewRow row = dgvPhieuBanHang.Rows[e.RowIndex];
                cboMaThe.SelectedValue = row.Cells["MaThe"].Value.ToString();
                cboNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
                dtpNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
                txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();
                btnThemPhieu.Enabled = false;
                btnSuaPhieu.Enabled = true;
                btnXoaPhieu.Enabled = true;

                bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                rdoPaid.Checked = trangThai;
                rdoConfirmation.Checked = !trangThai;
                // Khóa nút Xóa nếu đã thanh toán
                btnXoaPhieu.Enabled = !trangThai;
                //btnSuaPhieu.Enabled = !trangThai;

                // Khóa nút Thêm Chi Tiết nếu đã thanh toán
                btnThemChiTiet.Enabled = !trangThai;
            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMaThe.SelectedValue?.ToString()) || cboMaThe.SelectedValue.ToString() == "--Tất Cả--")
            {
                MessageBox.Show("Vui lòng chọn Mã thẻ hợp lệ!");
                return;
            }
            string maPhieu = dalPhieuBanHang.generateMaPhieu();
            PhieuBanHang phieu = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = cboMaThe.SelectedValue.ToString(),
                MaNhanVien = cboNhanVien.SelectedValue.ToString(),
                NgayTao = DateTime.Now,
                TrangThai = false
            };
            dalPhieuBanHang.insertPhieuBanHang(phieu);
            LoadPhieuBanHang();
            LoadNhanVien();
            LoadTheLuuDong();
            LoadSanPham();
            LoadDanhSachPhieu(string.Empty);
            ClearPhieuBanHang("");
            ClearChiTietPhieu();
            MessageBox.Show("Thêm phiếu bán hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            string maThe = cboMaThe.SelectedValue?.ToString();
            string maPhieu = txtMaPhieu.Text;
            string maNhanVien = cboNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = dtpNgayTao.Value;

            bool trangThai = rdoPaid.Checked;
            if (rdoConfirmation.Checked)
            {
                trangThai = false;
            }
            else
            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
            string result = bus.UpdatePhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearPhieuBanHang(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                cboMaThe.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = cboMaThe.SelectedValue?.ToString();
            string chuSoHuu = cboMaThe.Text;
            if (string.IsNullOrEmpty(maPhieu))
            {
                if (dgvPhieuBanHang.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPhieuBanHang.SelectedRows[0];
                    maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin phiếu bán hàng cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bán hàng {maPhieu} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
                string kq = bus.DeletePhieuBanHang(maPhieu);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin phiếu bán hàng {maPhieu} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPhieuBanHang(maThe);
                    LoadTheLuuDong();
                    LoadNhanVien();
                    LoadDanhSachPhieu("");

                    cboMaThe.SelectedValue = maThe;
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearPhieuBanHang("");
            ClearChiTietPhieu();
            LoadPhieuBanHang();
            LoadNhanVien();
            LoadTheLuuDong();
            LoadSanPham();
            LoadDanhSachPhieu(string.Empty);
            //LoadChiTietPhieu(string.Empty);
        }
        private void TinhThanhTien()
        {
            try
            {
                decimal donGia = string.IsNullOrEmpty(txtDonGia.Text) ? 0 : Convert.ToDecimal(txtDonGia.Text);
                int soLuong = string.IsNullOrEmpty(txtSoLuong.Text) ? 0 : Convert.ToInt32(txtSoLuong.Text);
                decimal thanhTien = donGia * soLuong;
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            catch
            {
                txtThanhTien.Text = "0";
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                string maSanPham = cboSanPham.SelectedValue.ToString();
                decimal donGia = dalSanPham.getDonGiaByMaSanPham(maSanPham);
                txtDonGia.Text = donGia.ToString("N0");
                TinhThanhTien();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void dgvPhieuBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = dgvPhieuBanHang.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = dgvPhieuBanHang.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNV = dgvPhieuBanHang.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)dgvPhieuBanHang.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in cboMaThe.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }

            foreach (NhanVien item in cboNhanVien.Items)
            {
                if (item.MaNhanVien == maNV)
                {
                    nv = item;
                    break;
                }
            }
            frmChiTietPhieu frmChiTiet = new frmChiTietPhieu(the, phieu, nv);
            frmChiTiet.ShowDialog();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu bán hàng trước khi thêm chi tiết.");
                return;
            }

            PhieuBanHang phieu = dalPhieuBanHang.getPhieuByMa(txtMaPhieu.Text);
            if (phieu != null && phieu.TrangThai == true)
            {
                MessageBox.Show("Phiếu bán hàng đã thanh toán, không thể thêm chi tiết!");
                return;
            }

            if (cboSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }

            ChiTietPhieu chiTiet = new ChiTietPhieu
            {
                MaChiTiet = dalChiTietPhieu.generateChiTietID(), // thêm dòng này
                MaPhieu = txtMaPhieu.Text,
                MaSanPham = cboSanPham.SelectedValue.ToString(),
                SoLuong = soLuong,
                DonGia = donGia
            };

            dalChiTietPhieu.insertChiTiet(chiTiet);
            MessageBox.Show("Thêm chi tiết phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //LoadChiTietPhieu(txtMaPhieu.Text);
            ClearChiTietPhieu();
        }
        public bool CheckChiTietSanPham(string maPhieu)
        {
            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Mã phiếu rỗng, vui lòng chọn phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = "SELECT COUNT(*) FROM ChiTietPhieu WHERE MaPhieu = @0";

            try
            {
                var result = DBUtil.ScalarQuery(query, new List<object> { maPhieu });

                if (result == null || result == DBNull.Value)
                {
                    MessageBox.Show("Dữ liệu trống hoặc lỗi kết nối database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                int count = 0;
                if (int.TryParse(result.ToString(), out count))
                {
                    if (count > 0)
                        return true;

                    MessageBox.Show("Không tìm thấy chi tiết phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi khi chuyển đổi dữ liệu số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        public bool UpdateTrangThai(string maPhieu, bool trangThai)
        {
            if (trangThai && !CheckChiTietSanPham(maPhieu))
            {
                MessageBox.Show("Không thể thanh toán vì không có chi tiết sản phẩm nào trong phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string query = "UPDATE PhieuBanHang SET TrangThai = @0 WHERE MaPhieu = @1";
            DBUtil.Update(query, new List<object> { trangThai, maPhieu });
            return true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu bán hàng trước khi thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maPhieu = txtMaPhieu.Text.Trim();
            DAL_PhieuBanHang dal = new DAL_PhieuBanHang();
            bool trangThaiHienTai = dal.GetTrangThai(maPhieu);
            if (trangThaiHienTai)
            {
                MessageBox.Show("Phiếu bán hàng đã được thanh toán trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!CheckChiTietSanPham(maPhieu))
            {
                MessageBox.Show("Không thể thanh toán vì không có chi tiết sản phẩm nào trong phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UpdateTrangThai(maPhieu, true))
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuBanHang();
                LoadChiTietPhieu(maPhieu);
                if (rdoPaid != null && rdoConfirmation != null)
                {
                    rdoPaid.Checked = true;
                    rdoConfirmation.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
