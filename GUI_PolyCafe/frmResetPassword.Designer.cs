namespace GUI_PolyCafe
{
    partial class frmResetPassword
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
            btnThoat = new Button();
            btnDoiMatKhau = new Button();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            txtTenNV = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMaNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            chkHienThi = new CheckBox();
            chkHienThi2 = new CheckBox();
            chkHienThi1 = new CheckBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkSalmon;
            btnThoat.Font = new Font("Segoe UI", 11F);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(545, 490);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(202, 49);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = SystemColors.MenuHighlight;
            btnDoiMatKhau.Font = new Font("Segoe UI", 11F);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(335, 490);
            btnDoiMatKhau.Margin = new Padding(3, 4, 3, 4);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(202, 49);
            btnDoiMatKhau.TabIndex = 17;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            txtMatKhauCu.Location = new Point(265, 275);
            txtMatKhauCu.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(633, 34);
            txtMatKhauCu.TabIndex = 16;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            txtMatKhauMoi.Location = new Point(264, 347);
            txtMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(634, 34);
            txtMatKhauMoi.TabIndex = 15;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F);
            txtXacNhanMatKhau.Location = new Point(265, 418);
            txtXacNhanMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(633, 34);
            txtXacNhanMatKhau.TabIndex = 14;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 12F);
            txtTenNV.Location = new Point(265, 197);
            txtTenNV.Margin = new Padding(3, 4, 3, 4);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.ReadOnly = true;
            txtTenNV.Size = new Size(633, 34);
            txtTenNV.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(77, 275);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 10;
            label5.Text = "Mật khẩu cũ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(77, 347);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 9;
            label6.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(78, 424);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 8;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(77, 197);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 7;
            label3.Text = "Tên Nhân Viên";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 12F);
            txtMaNV.Location = new Point(265, 115);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(633, 34);
            txtMaNV.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(78, 121);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 11;
            label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(437, 53);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 6;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // chkHienThi
            // 
            chkHienThi.AutoSize = true;
            chkHienThi.Location = new Point(932, 415);
            chkHienThi.Margin = new Padding(3, 4, 3, 4);
            chkHienThi.Name = "chkHienThi";
            chkHienThi.Size = new Size(102, 32);
            chkHienThi.TabIndex = 21;
            chkHienThi.Text = "Hiển thị";
            chkHienThi.UseVisualStyleBackColor = true;
            chkHienThi.CheckedChanged += chkHienThi_CheckedChanged;
            // 
            // chkHienThi2
            // 
            chkHienThi2.AutoSize = true;
            chkHienThi2.Location = new Point(932, 347);
            chkHienThi2.Margin = new Padding(3, 4, 3, 4);
            chkHienThi2.Name = "chkHienThi2";
            chkHienThi2.Size = new Size(102, 32);
            chkHienThi2.TabIndex = 20;
            chkHienThi2.Text = "Hiển thị";
            chkHienThi2.UseVisualStyleBackColor = true;
            chkHienThi2.CheckedChanged += chkHienThi2_CheckedChanged;
            // 
            // chkHienThi1
            // 
            chkHienThi1.AutoSize = true;
            chkHienThi1.Location = new Point(932, 275);
            chkHienThi1.Margin = new Padding(3, 4, 3, 4);
            chkHienThi1.Name = "chkHienThi1";
            chkHienThi1.Size = new Size(102, 32);
            chkHienThi1.TabIndex = 19;
            chkHienThi1.Text = "Hiển thị";
            chkHienThi1.UseVisualStyleBackColor = true;
            chkHienThi1.CheckedChanged += chkHienThi1_CheckedChanged;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(chkHienThi);
            Controls.Add(chkHienThi2);
            Controls.Add(chkHienThi1);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtTenNV);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMaNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmResetPassword";
            Text = "frmResetPassword";
            Load += frmResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnDoiMatKhau;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtTenNV;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtMaNV;
        private Label label2;
        private Label label1;
        private CheckBox chkHienThi;
        private CheckBox chkHienThi2;
        private CheckBox chkHienThi1;
    }
}