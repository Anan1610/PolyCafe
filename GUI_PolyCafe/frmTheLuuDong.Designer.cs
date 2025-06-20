namespace GUI_PolyCafe
{
    partial class frmTheLuuDong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLamMoi = new Button();
            groupBox2 = new GroupBox();
            dgvDanhSachThe = new Guna.UI2.WinForms.Guna2DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox1 = new GroupBox();
            chkAction = new Guna.UI2.WinForms.Guna2CheckBox();
            txtChuSoHuu = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaThe = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(1452, 669);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(117, 41);
            btnLamMoi.TabIndex = 29;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachThe);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(37, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1378, 521);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dgvDanhSachThe
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDanhSachThe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSachThe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachThe.ColumnHeadersHeight = 4;
            dgvDanhSachThe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSachThe.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachThe.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachThe.Location = new Point(25, 127);
            dgvDanhSachThe.Name = "dgvDanhSachThe";
            dgvDanhSachThe.RowHeadersVisible = false;
            dgvDanhSachThe.RowHeadersWidth = 51;
            dgvDanhSachThe.Size = new Size(1301, 372);
            dgvDanhSachThe.TabIndex = 8;
            dgvDanhSachThe.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDanhSachThe.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDanhSachThe.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDanhSachThe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDanhSachThe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDanhSachThe.ThemeStyle.BackColor = Color.White;
            dgvDanhSachThe.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachThe.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDanhSachThe.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSachThe.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F);
            dgvDanhSachThe.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDanhSachThe.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDanhSachThe.ThemeStyle.HeaderStyle.Height = 4;
            dgvDanhSachThe.ThemeStyle.ReadOnly = false;
            dgvDanhSachThe.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDanhSachThe.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachThe.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F);
            dgvDanhSachThe.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSachThe.ThemeStyle.RowsStyle.Height = 29;
            dgvDanhSachThe.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachThe.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSachThe.CellClick += dgvDanhSachThe_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1216, 57);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 46);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderThickness = 2;
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 12F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(832, 57);
            txtTimKiem.Margin = new Padding(4, 6, 4, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(347, 46);
            txtTimKiem.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAction);
            groupBox1.Controls.Add(txtChuSoHuu);
            groupBox1.Controls.Add(txtMaThe);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1532, 127);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // chkAction
            // 
            chkAction.AutoSize = true;
            chkAction.Checked = true;
            chkAction.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkAction.CheckedState.BorderRadius = 0;
            chkAction.CheckedState.BorderThickness = 0;
            chkAction.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkAction.CheckState = CheckState.Checked;
            chkAction.Location = new Point(1265, 53);
            chkAction.Name = "chkAction";
            chkAction.Size = new Size(129, 32);
            chkAction.TabIndex = 5;
            chkAction.Text = "Hoạt động";
            chkAction.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkAction.UncheckedState.BorderRadius = 0;
            chkAction.UncheckedState.BorderThickness = 0;
            chkAction.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.BorderRadius = 10;
            txtChuSoHuu.BorderThickness = 2;
            txtChuSoHuu.CustomizableEdges = customizableEdges3;
            txtChuSoHuu.DefaultText = "";
            txtChuSoHuu.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtChuSoHuu.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtChuSoHuu.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtChuSoHuu.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtChuSoHuu.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChuSoHuu.Font = new Font("Segoe UI", 12F);
            txtChuSoHuu.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChuSoHuu.Location = new Point(679, 48);
            txtChuSoHuu.Margin = new Padding(4, 6, 4, 6);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.PasswordChar = '\0';
            txtChuSoHuu.PlaceholderText = "";
            txtChuSoHuu.SelectedText = "";
            txtChuSoHuu.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtChuSoHuu.Size = new Size(382, 46);
            txtChuSoHuu.TabIndex = 4;
            // 
            // txtMaThe
            // 
            txtMaThe.BorderRadius = 10;
            txtMaThe.BorderThickness = 2;
            txtMaThe.CustomizableEdges = customizableEdges5;
            txtMaThe.DefaultText = "";
            txtMaThe.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaThe.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaThe.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaThe.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaThe.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaThe.Font = new Font("Segoe UI", 12F);
            txtMaThe.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaThe.Location = new Point(106, 48);
            txtMaThe.Margin = new Padding(4, 6, 4, 6);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.PasswordChar = '\0';
            txtMaThe.PlaceholderText = "";
            txtMaThe.ReadOnly = true;
            txtMaThe.SelectedText = "";
            txtMaThe.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMaThe.Size = new Size(372, 46);
            txtMaThe.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1141, 57);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 57);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Chủ sở hữu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã thẻ";
            // 
            // btnThem
            // 
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(1452, 199);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 41);
            btnThem.TabIndex = 26;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(1452, 504);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 41);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(1452, 350);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 41);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1605, 731);
            Controls.Add(btnLamMoi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmTheLuuDong";
            Text = "frmTheLuuDong";
            Load += frmTheLuuDong_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLamMoi;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachThe;
        private Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtChuSoHuu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaThe;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Guna.UI2.WinForms.Guna2CheckBox chkAction;
    }
}