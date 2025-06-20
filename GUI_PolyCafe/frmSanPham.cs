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
using GUI_PolyCafe.Helper;

namespace GUI_PolyCafe
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }
        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            rdoActive.Checked = true;
            picHinhAnh.Image = null;
        }

        private void LoadLoaiSanPham()
        {
            try
            {
                BUS_LoaiSanPham bUSLoaiSanPham = new BUS_LoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();
                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.ValueMember = "MaLoai";
                cboLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            BUS_SanPham bUSSanPham = new BUS_SanPham();
            dgvDanhSachSP.DataSource = null;
            List<SanPham> lstSP = bUSSanPham.GetSanPhamList();
            dgvDanhSachSP.DataSource = lstSP;
            dgvDanhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSP.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSachSP.DefaultCellStyle.BackColor = Color.White;
            dgvDanhSachSP.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvDanhSachSP.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvDanhSachSP.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvDanhSachSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvDanhSachSP.Columns["TenLoai"].HeaderText = "Tên Loại";
            dgvDanhSachSP.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            dgvDanhSachSP.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachSP.Rows[e.RowIndex];
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            cboLoaiSanPham.SelectedValue = row.Cells["MaLoai"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);

            if (row.Cells["HinhAnh"].Value != null && !string.IsNullOrEmpty(row.Cells["HinhAnh"].Value.ToString()))
            {
                picHinhAnh.ImageLocation = row.Cells["HinhAnh"].Value.ToString();
            }
            if (trangThai)
            {
                rdoActive.Checked = true;
            }
            else
            {
                rdoDeActive.Checked = true;
            }
            string path = Path.Combine(Application.StartupPath, row.Cells["HinhAnh"].Value.ToString());
            picHinhAnh.Image = ImageUtil.LoadImage(path);
            picHinhAnh.Tag = path;
            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void dgvDanhSachSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dgvDanhSachSP.Rows[e.RowIndex];
            //string path = Path.Combine(Application.StartupPath, row.Cells["HinhAnh"].Value.ToString());
            //picHinhAnh.Image = ImageUtil.LoadImage(path);
            //picHinhAnh.Tag = path;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdoActive.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string savePath = ImageUtil.SaveImage(picHinhAnh.Image, "Uploads");
                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = savePath
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUS_SanPham bUSSanPham = new BUS_SanPham();
                bUSSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSanPham.Text = "";
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (dgvDanhSachSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachSP.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txtTenSanPham.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_SanPham bus = new BUS_SanPham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {
                    if(picHinhAnh.Image != null)
                    {
                        picHinhAnh.Image.Dispose();
                        picHinhAnh.Image = null;
                    }
                    string path = Path.Combine(Application.StartupPath, hinhAnh);
                    ImageUtil.DeleteImage(path);

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = cboLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rdoActive.Checked;
                string maSP = txtMaSanPham.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string savePath = ImageUtil.SaveImage(picHinhAnh.Image, "Uploads");
                // Tạo đối tượng sản phẩm
                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = savePath
                };

                // Cập nhật vào cơ sở dữ liệu
                BUS_SanPham bUSSanPham = new BUS_SanPham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            BUS_SanPham bus = new BUS_SanPham();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvDanhSachSP.DataSource = null;
                dgvDanhSachSP.DataSource = bus.GetSanPhamList();
                return;
            }

            var ketQua = bus.TimKiemSanPham(tuKhoa);

            if (ketQua.Count > 0)
            {
                dgvDanhSachSP.DataSource = null;
                dgvDanhSachSP.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm phù hợp.");
                dgvDanhSachSP.DataSource = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }

        }
    }
}
