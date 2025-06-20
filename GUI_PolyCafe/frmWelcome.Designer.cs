namespace GUI_PolyCafe
{
    partial class frmWelcome
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
            progressBar = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 418);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(861, 47);
            progressBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_XÀI_TẠM_01;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(20, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(861, 358);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 490);
            Controls.Add(progressBar);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "frmWelcome";
            Text = "frmWelcome";
            FormClosing += frmWelcome_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar progressBar;
        private PictureBox pictureBox1;
    }
}