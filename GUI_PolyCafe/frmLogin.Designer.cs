namespace GUI_PolyCafe
{
    partial class frmLogin
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
            btnExit = new Button();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            QuenMK = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkSalmon;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(109, 529);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(366, 60);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(109, 437);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(366, 60);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.Maroon;
            chkShowPassword.Location = new Point(108, 349);
            chkShowPassword.Margin = new Padding(3, 4, 3, 4);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(148, 24);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.Text = "Hiển thị mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(109, 285);
            txtPassword.Margin = new Padding(7, 8, 7, 8);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(366, 36);
            txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.Location = new Point(108, 179);
            txtUsername.Margin = new Padding(7, 8, 7, 8);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(366, 36);
            txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(108, 256);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(104, 143);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(164, 53);
            label3.Name = "label3";
            label3.Size = new Size(259, 35);
            label3.TabIndex = 13;
            label3.Text = "Đăng Nhập Hệ Thống";
            // 
            // QuenMK
            // 
            QuenMK.AutoSize = true;
            QuenMK.BackColor = Color.Transparent;
            QuenMK.Font = new Font("Segoe UI", 9F);
            QuenMK.ForeColor = Color.Maroon;
            QuenMK.Location = new Point(365, 350);
            QuenMK.Name = "QuenMK";
            QuenMK.Size = new Size(109, 20);
            QuenMK.TabIndex = 14;
            QuenMK.Text = "Quên mật khẩu";
            QuenMK.Click += QuenMK_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 630);
            Controls.Add(QuenMK);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "Đăng nhập";
            FormClosing += frmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label QuenMK;
    }
}