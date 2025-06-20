using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PolyCafe;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CheckPermission();
        }
        private Form currentFormChild;
        private void VaiTroNhanVien()
        {
            danhMucToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;
        }
        private void CheckPermission()
        {
            if (AuthUtil.IsLogin())
            {
                toolStripUserName.Text = AuthUtil.user.HoTen;
                danhMucToolStripMenuItem.Visible = true;
                banHangToolStripMenuItem.Visible = true;
                nhanVienToolStripMenuItem.Visible = true;
                doanhThuToolStripMenuItem.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                heThongToolStripMenuItem.Visible = true; // Xác định xem điều khiển có hiển thị trên giao diện hay không.
                dangXuatToolStripMenuItem.Enabled = false; // Xác định xem điều khiển có thể tương tác hay không.
                //thongTinTaiKhoanToolStripMenuItem.Enabled = false;
                danhMucToolStripMenuItem.Visible = false;
                banHangToolStripMenuItem.Visible = false;
                nhanVienToolStripMenuItem.Visible = false;
                doanhThuToolStripMenuItem.Visible = false;
            }
        }
        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassword reset = new frmResetPassword();
            reset.Show();
            this.Hide();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhMucToolStripMenuItem.Visible = false;
            banHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;

            this.Hide();
            AuthUtil.user = null;
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSanPham());
        }

        private void theLuuDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheLuuDong());
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBanHang());
        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTKDoanhThuTheoLoaiSP());
        }

        private void tkNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTKDoanhThuTheoNhanVien());
        }

        private void hdSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHuongDan());
        }

        private void gioiThieuPhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGioiThieuPhanMem());
        }

        
    }
}
