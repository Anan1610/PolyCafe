namespace GUI_PolyCafe
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            rdoDeActive = new RadioButton();
            label7 = new Label();
            rdoActive = new RadioButton();
            rdoQuanLy = new RadioButton();
            rdoNhanVien = new RadioButton();
            label8 = new Label();
            txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            txtXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dgvDanhSachNV = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(687, 18);
            label1.Name = "label1";
            label1.Size = new Size(161, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(rdoQuanLy);
            groupBox1.Controls.Add(rdoNhanVien);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtXacNhanMK);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1900, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoDeActive);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(rdoActive);
            panel1.Location = new Point(1368, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 58);
            panel1.TabIndex = 16;
            // 
            // rdoDeActive
            // 
            rdoDeActive.AutoSize = true;
            rdoDeActive.Location = new Point(365, 10);
            rdoDeActive.Name = "rdoDeActive";
            rdoDeActive.Size = new Size(133, 32);
            rdoDeActive.TabIndex = 15;
            rdoDeActive.Text = "Tạm ngưng";
            rdoDeActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 12);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 10;
            label7.Text = "Trạng thái";
            // 
            // rdoActive
            // 
            rdoActive.AutoSize = true;
            rdoActive.Checked = true;
            rdoActive.Location = new Point(135, 8);
            rdoActive.Name = "rdoActive";
            rdoActive.Size = new Size(177, 32);
            rdoActive.TabIndex = 12;
            rdoActive.TabStop = true;
            rdoActive.Text = "Đang hoạt động";
            rdoActive.UseVisualStyleBackColor = true;
            // 
            // rdoQuanLy
            // 
            rdoQuanLy.AutoSize = true;
            rdoQuanLy.Location = new Point(1733, 37);
            rdoQuanLy.Name = "rdoQuanLy";
            rdoQuanLy.Size = new Size(100, 32);
            rdoQuanLy.TabIndex = 14;
            rdoQuanLy.Text = "Quản lý";
            rdoQuanLy.UseVisualStyleBackColor = true;
            // 
            // rdoNhanVien
            // 
            rdoNhanVien.AutoSize = true;
            rdoNhanVien.Checked = true;
            rdoNhanVien.Location = new Point(1503, 37);
            rdoNhanVien.Name = "rdoNhanVien";
            rdoNhanVien.Size = new Size(121, 32);
            rdoNhanVien.TabIndex = 13;
            rdoNhanVien.TabStop = true;
            rdoNhanVien.Text = "Nhân viên";
            rdoNhanVien.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1368, 39);
            label8.Name = "label8";
            label8.Size = new Size(69, 28);
            label8.TabIndex = 11;
            label8.Text = "Vai trò";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderRadius = 10;
            txtMatKhau.BorderThickness = 2;
            txtMatKhau.CustomizableEdges = customizableEdges21;
            txtMatKhau.DefaultText = "";
            txtMatKhau.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMatKhau.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMatKhau.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Location = new Point(875, 34);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '\0';
            txtMatKhau.PlaceholderText = "";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtMatKhau.Size = new Size(396, 41);
            txtMatKhau.TabIndex = 9;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.BorderRadius = 10;
            txtXacNhanMK.BorderThickness = 2;
            txtXacNhanMK.CustomizableEdges = customizableEdges23;
            txtXacNhanMK.DefaultText = "";
            txtXacNhanMK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtXacNhanMK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtXacNhanMK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtXacNhanMK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtXacNhanMK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtXacNhanMK.Font = new Font("Segoe UI", 9F);
            txtXacNhanMK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtXacNhanMK.Location = new Point(875, 89);
            txtXacNhanMK.Margin = new Padding(3, 4, 3, 4);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '\0';
            txtXacNhanMK.PlaceholderText = "";
            txtXacNhanMK.SelectedText = "";
            txtXacNhanMK.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtXacNhanMK.Size = new Size(396, 41);
            txtXacNhanMK.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(692, 89);
            label6.Name = "label6";
            label6.Size = new Size(177, 28);
            label6.TabIndex = 7;
            label6.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(692, 39);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 6;
            label5.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.BorderThickness = 2;
            txtEmail.CustomizableEdges = customizableEdges25;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(173, 140);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txtEmail.Size = new Size(416, 41);
            txtEmail.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderRadius = 10;
            txtHoTen.BorderThickness = 2;
            txtHoTen.CustomizableEdges = customizableEdges27;
            txtHoTen.DefaultText = "";
            txtHoTen.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtHoTen.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHoTen.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHoTen.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHoTen.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHoTen.Location = new Point(173, 89);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PasswordChar = '\0';
            txtHoTen.PlaceholderText = "";
            txtHoTen.SelectedText = "";
            txtHoTen.ShadowDecoration.CustomizableEdges = customizableEdges28;
            txtHoTen.Size = new Size(416, 41);
            txtHoTen.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 10;
            txtMaNV.BorderThickness = 2;
            txtMaNV.CustomizableEdges = customizableEdges29;
            txtMaNV.DefaultText = "";
            txtMaNV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaNV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaNV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaNV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaNV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaNV.Location = new Point(173, 34);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PasswordChar = '\0';
            txtMaNV.PlaceholderText = "";
            txtMaNV.ReadOnly = true;
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges30;
            txtMaNV.Size = new Size(416, 41);
            txtMaNV.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 140);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 89);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 39);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.PaleTurquoise;
            btnLamMoi.Location = new Point(1791, 588);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 40);
            btnLamMoi.TabIndex = 27;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.InactiveCaption;
            btnSua.Location = new Point(1791, 499);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(121, 40);
            btnSua.TabIndex = 26;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.GradientActiveCaption;
            btnXoa.Location = new Point(1791, 390);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 40);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.Location = new Point(1791, 295);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 40);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachNV);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(12, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1741, 344);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSachNV
            // 
            dgvDanhSachNV.AllowUserToAddRows = false;
            dgvDanhSachNV.AllowUserToDeleteRows = false;
            dgvDanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNV.Location = new Point(24, 83);
            dgvDanhSachNV.Name = "dgvDanhSachNV";
            dgvDanhSachNV.ReadOnly = true;
            dgvDanhSachNV.RowHeadersWidth = 51;
            dgvDanhSachNV.Size = new Size(1674, 237);
            dgvDanhSachNV.TabIndex = 18;
            dgvDanhSachNV.CellClick += dgvDanhSachNV_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.AppWorkspace;
            btnTimKiem.Location = new Point(1597, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 40);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1325, 40);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(258, 34);
            txtTimKiem.TabIndex = 16;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1924, 683);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private RadioButton rdoDeActive;
        private Label label7;
        private RadioButton rdoActive;
        private RadioButton rdoQuanLy;
        private RadioButton rdoNhanVien;
        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMK;
        private Label label6;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dgvDanhSachNV;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}