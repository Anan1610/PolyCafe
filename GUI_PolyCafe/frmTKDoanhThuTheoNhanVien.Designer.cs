namespace GUI_PolyCafe
{
    partial class frmTKDoanhThuTheoNhanVien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            dtpDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnThongKe = new Button();
            label4 = new Label();
            label3 = new Label();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgvDanhSachThongKe = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboNhanVien);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 90);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1812, 84);
            panel1.TabIndex = 11;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Checked = true;
            dtpDenNgay.CustomizableEdges = customizableEdges5;
            dtpDenNgay.FillColor = Color.White;
            dtpDenNgay.Font = new Font("Segoe UI", 12F);
            dtpDenNgay.Format = DateTimePickerFormat.Long;
            dtpDenNgay.Location = new Point(1242, 16);
            dtpDenNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpDenNgay.Size = new Size(318, 52);
            dtpDenNgay.TabIndex = 13;
            dtpDenNgay.Value = new DateTime(2025, 6, 5, 11, 11, 12, 719);
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Checked = true;
            dtpTuNgay.CustomizableEdges = customizableEdges7;
            dtpTuNgay.FillColor = Color.White;
            dtpTuNgay.Font = new Font("Segoe UI", 12F);
            dtpTuNgay.Format = DateTimePickerFormat.Long;
            dtpTuNgay.Location = new Point(696, 16);
            dtpTuNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpTuNgay.Size = new Size(341, 52);
            dtpTuNgay.TabIndex = 13;
            dtpTuNgay.Value = new DateTime(2025, 6, 5, 11, 10, 26, 746);
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.White;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.Maroon;
            btnThongKe.Location = new Point(1654, 16);
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
            label4.Location = new Point(1125, 37);
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
            label3.Location = new Point(586, 40);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 3;
            label3.Text = "Từ Ngày";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Font = new Font("Segoe UI", 12F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(119, 29);
            cboNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(380, 36);
            cboNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(15, 32);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Nhân Viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(476, 11);
            label1.Name = "label1";
            label1.Size = new Size(708, 46);
            label1.TabIndex = 10;
            label1.Text = "THỐNG KÊ DOANH THU THEO NHÂN VIÊN";
            // 
            // dgvDanhSachThongKe
            // 
            dgvDanhSachThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSachThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThongKe.Location = new Point(23, 208);
            dgvDanhSachThongKe.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachThongKe.Name = "dgvDanhSachThongKe";
            dgvDanhSachThongKe.ReadOnly = true;
            dgvDanhSachThongKe.RowHeadersWidth = 51;
            dgvDanhSachThongKe.Size = new Size(1812, 408);
            dgvDanhSachThongKe.TabIndex = 12;
            dgvDanhSachThongKe.DataBindingComplete += dgvDanhSachThongKe_DataBindingComplete;
            // 
            // frmTKDoanhThuTheoNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1866, 629);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvDanhSachThongKe);
            Name = "frmTKDoanhThuTheoNhanVien";
            Text = "frmTKDoanhThuTheoNhanVien";
            Load += frmTKDoanhThuTheoNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnThongKe;
        private Label label4;
        private Label label3;
        private ComboBox cboNhanVien;
        private Label label2;
        private Label label1;
        private DataGridView dgvDanhSachThongKe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTuNgay;
    }
}