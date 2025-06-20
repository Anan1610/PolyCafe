namespace GUI_PolyCafe
{
    partial class frmTKDoanhThuTheoLoaiSP
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
            label1 = new Label();
            panel1 = new Panel();
            cboLoaiSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnThongKe = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvDanhSachThongKe = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(547, 43);
            label1.Name = "label1";
            label1.Size = new Size(785, 46);
            label1.TabIndex = 5;
            label1.Text = "THỐNG KÊ DOANH THU THEO LOẠI SẢN PHẨM";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 118);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 81);
            panel1.TabIndex = 6;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.BackColor = Color.Transparent;
            cboLoaiSanPham.CustomizableEdges = customizableEdges1;
            cboLoaiSanPham.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiSanPham.Font = new Font("Segoe UI", 10F);
            cboLoaiSanPham.ForeColor = Color.FromArgb(68, 88, 112);
            cboLoaiSanPham.ItemHeight = 30;
            cboLoaiSanPham.Location = new Point(177, 24);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboLoaiSanPham.Size = new Size(346, 36);
            cboLoaiSanPham.TabIndex = 7;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Checked = true;
            dtpDenNgay.CustomizableEdges = customizableEdges3;
            dtpDenNgay.FillColor = Color.White;
            dtpDenNgay.Font = new Font("Segoe UI", 12F);
            dtpDenNgay.Format = DateTimePickerFormat.Long;
            dtpDenNgay.Location = new Point(1296, 24);
            dtpDenNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpDenNgay.Size = new Size(364, 36);
            dtpDenNgay.TabIndex = 7;
            dtpDenNgay.Value = new DateTime(2025, 6, 2, 22, 35, 51, 47);
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Checked = true;
            dtpTuNgay.CustomizableEdges = customizableEdges5;
            dtpTuNgay.FillColor = Color.White;
            dtpTuNgay.Font = new Font("Segoe UI", 12F);
            dtpTuNgay.Format = DateTimePickerFormat.Long;
            dtpTuNgay.Location = new Point(681, 24);
            dtpTuNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTuNgay.Size = new Size(403, 36);
            dtpTuNgay.TabIndex = 6;
            dtpTuNgay.Value = new DateTime(2025, 6, 2, 22, 34, 48, 453);
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.White;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.Maroon;
            btnThongKe.Location = new Point(1743, 13);
            btnThongKe.Margin = new Padding(3, 4, 3, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(136, 52);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(1177, 32);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "Đến Ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(562, 32);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 3;
            label3.Text = "Từ Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(17, 32);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 1;
            label2.Text = "Loại Sản Phẩm";
            // 
            // dgvDanhSachThongKe
            // 
            dgvDanhSachThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSachThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThongKe.Location = new Point(12, 222);
            dgvDanhSachThongKe.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachThongKe.Name = "dgvDanhSachThongKe";
            dgvDanhSachThongKe.ReadOnly = true;
            dgvDanhSachThongKe.RowHeadersWidth = 51;
            dgvDanhSachThongKe.Size = new Size(1900, 398);
            dgvDanhSachThongKe.TabIndex = 7;
            dgvDanhSachThongKe.DataBindingComplete += dgvDanhSachThongKe_DataBindingComplete;
            // 
            // frmTKDoanhThuTheoLoaiSP
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1924, 633);
            Controls.Add(dgvDanhSachThongKe);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmTKDoanhThuTheoLoaiSP";
            Text = "frmTKDoanhThuTheoLoaiSP";
            Load += frmTKDoanhThuTheoLoaiSP_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnThongKe;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSanPham;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
        private DataGridView dgvDanhSachThongKe;
    }
}