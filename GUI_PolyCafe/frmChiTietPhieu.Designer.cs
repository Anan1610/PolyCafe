namespace GUI_PolyCafe
{
    partial class frmChiTietPhieu
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
            btnXoaChiTiet = new Button();
            btnThemChiTiet = new Button();
            dgvSanPham = new DataGridView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtPhanTram = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtDichVu = new TextBox();
            txtTong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvChiTietPhieu = new DataGridView();
            lbNgayLap = new Label();
            label4 = new Label();
            lbMaPhieu = new Label();
            label3 = new Label();
            lbChuSoHuu = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTinhTien = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).BeginInit();
            SuspendLayout();
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.Location = new Point(672, 375);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(61, 45);
            btnXoaChiTiet.TabIndex = 18;
            btnXoaChiTiet.Text = ">>";
            btnXoaChiTiet.UseVisualStyleBackColor = true;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Location = new Point(674, 277);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(61, 40);
            btnThemChiTiet.TabIndex = 19;
            btnThemChiTiet.Text = "<<";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(753, 124);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1137, 608);
            dgvSanPham.TabIndex = 17;
            dgvSanPham.CellDoubleClick += dgvSanPham_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhanTram);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtDichVu);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(30, 541);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 191);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thanh Toán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(198, 101);
            label9.Name = "label9";
            label9.Size = new Size(28, 28);
            label9.TabIndex = 3;
            label9.Text = "%";
            // 
            // txtPhanTram
            // 
            txtPhanTram.Location = new Point(138, 97);
            txtPhanTram.Name = "txtPhanTram";
            txtPhanTram.Size = new Size(52, 34);
            txtPhanTram.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(138, 143);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(432, 34);
            txtThanhTien.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(268, 94);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.ReadOnly = true;
            txtGiamGia.Size = new Size(302, 34);
            txtGiamGia.TabIndex = 1;
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(420, 49);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.Size = new Size(150, 34);
            txtDichVu.TabIndex = 1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(103, 49);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(183, 34);
            txtTong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 146);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 0;
            label8.Text = "Thành Tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 97);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 0;
            label7.Text = "Giảm Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 48);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 0;
            label6.Text = "Dịch Vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 45);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 0;
            label5.Text = "Tổng :";
            // 
            // dgvChiTietPhieu
            // 
            dgvChiTietPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieu.Location = new Point(30, 124);
            dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            dgvChiTietPhieu.RowHeadersWidth = 51;
            dgvChiTietPhieu.Size = new Size(624, 399);
            dgvChiTietPhieu.TabIndex = 15;
            dgvChiTietPhieu.CellEndEdit += dgvChiTietPhieu_CellEndEdit;
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Segoe UI", 11F);
            lbNgayLap.ForeColor = Color.Maroon;
            lbNgayLap.Location = new Point(1430, 82);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(24, 25);
            lbNgayLap.TabIndex = 9;
            lbNgayLap.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(1328, 82);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 10;
            label4.Text = "Ngày Lập:";
            // 
            // lbMaPhieu
            // 
            lbMaPhieu.AutoSize = true;
            lbMaPhieu.Font = new Font("Segoe UI", 11F);
            lbMaPhieu.ForeColor = Color.Maroon;
            lbMaPhieu.Location = new Point(1062, 82);
            lbMaPhieu.Name = "lbMaPhieu";
            lbMaPhieu.Size = new Size(24, 25);
            lbMaPhieu.TabIndex = 11;
            lbMaPhieu.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(960, 82);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 12;
            label3.Text = "Mã Phiếu:";
            // 
            // lbChuSoHuu
            // 
            lbChuSoHuu.AutoSize = true;
            lbChuSoHuu.Font = new Font("Segoe UI", 11F);
            lbChuSoHuu.ForeColor = Color.Maroon;
            lbChuSoHuu.Location = new Point(658, 82);
            lbChuSoHuu.Name = "lbChuSoHuu";
            lbChuSoHuu.Size = new Size(24, 25);
            lbChuSoHuu.TabIndex = 13;
            lbChuSoHuu.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(536, 82);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 14;
            label2.Text = "Chủ Sở Hữu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(818, 19);
            label1.Name = "label1";
            label1.Size = new Size(458, 46);
            label1.TabIndex = 8;
            label1.Text = "CHI TIẾT PHIẾU BÁN HÀNG";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(627, 687);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(120, 45);
            btnTinhTien.TabIndex = 20;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // frmChiTietPhieu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1898, 752);
            Controls.Add(btnTinhTien);
            Controls.Add(btnXoaChiTiet);
            Controls.Add(btnThemChiTiet);
            Controls.Add(dgvSanPham);
            Controls.Add(groupBox1);
            Controls.Add(dgvChiTietPhieu);
            Controls.Add(lbNgayLap);
            Controls.Add(label4);
            Controls.Add(lbMaPhieu);
            Controls.Add(label3);
            Controls.Add(lbChuSoHuu);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmChiTietPhieu";
            Text = "frmChiTietPhieu";
            Load += frmChiTietPhieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoaChiTiet;
        private Button btnThemChiTiet;
        private DataGridView dgvSanPham;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtPhanTram;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtDichVu;
        private TextBox txtTong;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvChiTietPhieu;
        private Label lbNgayLap;
        private Label label4;
        private Label lbMaPhieu;
        private Label label3;
        private Label lbChuSoHuu;
        private Label label2;
        private Label label1;
        private Button btnTinhTien;
    }
}