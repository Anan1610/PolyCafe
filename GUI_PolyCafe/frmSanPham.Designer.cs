namespace GUI_PolyCafe
{
    partial class frmSanPham
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            btnChonAnh = new Button();
            label6 = new Label();
            picHinhAnh = new PictureBox();
            rdoDeActive = new RadioButton();
            rdoActive = new RadioButton();
            txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            cboLoaiSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            txtMaSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvDanhSachSP = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox3 = new GroupBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(rdoDeActive);
            groupBox1.Controls.Add(rdoActive);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 693);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnChonAnh
            // 
            btnChonAnh.ForeColor = Color.Black;
            btnChonAnh.Location = new Point(300, 635);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(117, 41);
            btnChonAnh.TabIndex = 15;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(25, 454);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 14;
            label6.Text = "Hình ảnh";
            // 
            // picHinhAnh
            // 
            picHinhAnh.BackgroundImageLayout = ImageLayout.None;
            picHinhAnh.Location = new Point(182, 454);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(368, 175);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 13;
            picHinhAnh.TabStop = false;
            // 
            // rdoDeActive
            // 
            rdoDeActive.AutoSize = true;
            rdoDeActive.ForeColor = Color.Black;
            rdoDeActive.Location = new Point(401, 377);
            rdoDeActive.Name = "rdoDeActive";
            rdoDeActive.Size = new Size(133, 32);
            rdoDeActive.TabIndex = 12;
            rdoDeActive.Text = "Ngưng bán";
            rdoDeActive.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            rdoActive.AutoSize = true;
            rdoActive.Checked = true;
            rdoActive.ForeColor = Color.Black;
            rdoActive.Location = new Point(182, 377);
            rdoActive.Name = "rdoActive";
            rdoActive.Size = new Size(128, 32);
            rdoActive.TabIndex = 11;
            rdoActive.TabStop = true;
            rdoActive.Text = "Hoạt động";
            rdoActive.UseVisualStyleBackColor = true;
            // 
            // txtDonGia
            // 
            txtDonGia.BorderRadius = 10;
            txtDonGia.BorderThickness = 2;
            txtDonGia.CustomizableEdges = customizableEdges1;
            txtDonGia.DefaultText = "";
            txtDonGia.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDonGia.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDonGia.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDonGia.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDonGia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDonGia.Location = new Point(182, 211);
            txtDonGia.Margin = new Padding(4, 6, 4, 6);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PasswordChar = '\0';
            txtDonGia.PlaceholderText = "";
            txtDonGia.SelectedText = "";
            txtDonGia.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtDonGia.Size = new Size(368, 42);
            txtDonGia.TabIndex = 10;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.BorderRadius = 10;
            txtTenSanPham.BorderThickness = 2;
            txtTenSanPham.CustomizableEdges = customizableEdges3;
            txtTenSanPham.DefaultText = "";
            txtTenSanPham.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenSanPham.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenSanPham.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenSanPham.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenSanPham.Font = new Font("Segoe UI", 12F);
            txtTenSanPham.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenSanPham.Location = new Point(183, 138);
            txtTenSanPham.Margin = new Padding(4, 6, 4, 6);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.PasswordChar = '\0';
            txtTenSanPham.PlaceholderText = "";
            txtTenSanPham.SelectedText = "";
            txtTenSanPham.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenSanPham.Size = new Size(368, 42);
            txtTenSanPham.TabIndex = 9;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.BackColor = Color.Transparent;
            cboLoaiSanPham.BorderRadius = 10;
            cboLoaiSanPham.BorderThickness = 2;
            cboLoaiSanPham.CustomizableEdges = customizableEdges5;
            cboLoaiSanPham.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiSanPham.Font = new Font("Segoe UI", 12F);
            cboLoaiSanPham.ForeColor = Color.FromArgb(68, 88, 112);
            cboLoaiSanPham.ItemHeight = 30;
            cboLoaiSanPham.Location = new Point(182, 295);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboLoaiSanPham.Size = new Size(368, 36);
            cboLoaiSanPham.TabIndex = 8;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.BorderRadius = 10;
            txtMaSanPham.BorderThickness = 2;
            txtMaSanPham.CustomizableEdges = customizableEdges7;
            txtMaSanPham.DefaultText = "";
            txtMaSanPham.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaSanPham.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaSanPham.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaSanPham.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaSanPham.Font = new Font("Segoe UI", 12F);
            txtMaSanPham.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaSanPham.Location = new Point(182, 71);
            txtMaSanPham.Margin = new Padding(4, 6, 4, 6);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.PasswordChar = '\0';
            txtMaSanPham.PlaceholderText = "";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.SelectedText = "";
            txtMaSanPham.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtMaSanPham.Size = new Size(368, 42);
            txtMaSanPham.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 377);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 302);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 3;
            label4.Text = "Loại sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 225);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 152);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 85);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachSP);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(644, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1256, 824);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvDanhSachSP
            // 
            dgvDanhSachSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSP.Location = new Point(28, 142);
            dgvDanhSachSP.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachSP.Name = "dgvDanhSachSP";
            dgvDanhSachSP.ReadOnly = true;
            dgvDanhSachSP.RowHeadersWidth = 51;
            dgvDanhSachSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachSP.Size = new Size(1206, 652);
            dgvDanhSachSP.TabIndex = 19;
            dgvDanhSachSP.CellClick += dgvDanhSachSP_CellClick;
            dgvDanhSachSP.CellDoubleClick += dgvDanhSachSP_CellDoubleClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(1087, 71);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 42);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderThickness = 2;
            txtTimKiem.CustomizableEdges = customizableEdges9;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 12F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(690, 71);
            txtTimKiem.Margin = new Padding(4, 6, 4, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTimKiem.Size = new Size(368, 42);
            txtTimKiem.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(12, 799);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(589, 111);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // btnLamMoi
            // 
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(455, 43);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(117, 41);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(317, 43);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 41);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(168, 43);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 41);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(26, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 41);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 30F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(771, 9);
            label7.Name = "label7";
            label7.Size = new Size(248, 67);
            label7.TabIndex = 3;
            label7.Text = "Sản phẩm";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1924, 959);
            Controls.Add(label7);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.Transparent;
            Margin = new Padding(4);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSanPham;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdoDeActive;
        private RadioButton rdoActive;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSanPham;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSanPham;
        private Button btnChonAnh;
        private Label label6;
        private PictureBox picHinhAnh;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Label label7;
        private DataGridView dgvDanhSachSP;
    }
}