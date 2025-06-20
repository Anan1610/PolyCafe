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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            ClearForm();
        }
        private void LoadDanhSachNhanVien()
        {
            BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
            dgvDanhSachNV.DataSource = null;
            dgvDanhSachNV.DataSource = bUS_NhanVien.GetNhanVienList();
        }
        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMK.Clear();
            rdoNhanVien.Checked = true;
            rdoActive.Checked = true;
        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachNV.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txtXacNhanMK.Text = row.Cells["MatKhau"].Value.ToString();

            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rdoNhanVien.Checked = true;
            }
            else
            {
                rdoQuanLy.Checked = true;
            }
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai == false)
            {
                rdoDeActive.Checked = true;
            }
            else
            {
                rdoActive.Checked = true;
            }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMK = txtXacNhanMK.Text.Trim();
            bool vaiTro;

            if (rdoNhanVien.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rdoActive.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            if (!matKhau.Equals(xacNhanMK))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUS_NhanVien bus = new BUS_NhanVien();
            string result = bus.InsertNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNV.Text.Trim();
            string name = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                if (dgvDanhSachNV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDanhSachNV.SelectedRows[0];
                    maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    name = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNhanVien} - {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_NhanVien bus = new BUS_NhanVien();
                string kq = bus.DeleteNhanVien(maNhanVien);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNhanVien} - {name} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMK = txtXacNhanMK.Text.Trim();
            bool vaiTro;

            if (rdoQuanLy.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rdoActive.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            if (!matKhau.Equals(xacNhanMK))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUS_NhanVien bus = new BUS_NhanVien();
            string result = bus.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            BUS_NhanVien bus = new BUS_NhanVien();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu không nhập từ khóa, hiển thị toàn bộ danh sách
                dgvDanhSachNV.DataSource = null;
                dgvDanhSachNV.DataSource = bus.GetNhanVienList();
                return;
            }

            var ketQua = bus.TimKiemNhanVien(tuKhoa);

            if (ketQua.Count > 0)
            {
                dgvDanhSachNV.DataSource = null;
                dgvDanhSachNV.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp.");
                dgvDanhSachNV.DataSource = null;
            }
        }
    }
}
