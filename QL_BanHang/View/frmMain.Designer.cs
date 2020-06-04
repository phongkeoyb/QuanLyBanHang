namespace QL_BanHang
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MnStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripND = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripDX = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripKH = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripSp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripLSP = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStripHeThong,
            this.MnStripNhanVien,
            this.MnStripKH,
            this.MnStripLSP,
            this.MnStripSp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(603, 32);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MnStripHeThong
            // 
            this.MnStripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStripND,
            this.MnStripDX,
            this.MnStripThoat});
            this.MnStripHeThong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripHeThong.Name = "MnStripHeThong";
            this.MnStripHeThong.Size = new System.Drawing.Size(103, 26);
            this.MnStripHeThong.Text = "Hệ Thống";
            this.MnStripHeThong.Click += new System.EventHandler(this.MnStripHeThong_Click);
            // 
            // MnStripND
            // 
            this.MnStripND.Name = "MnStripND";
            this.MnStripND.Size = new System.Drawing.Size(256, 26);
            this.MnStripND.Text = "Quản Lý Người Dùng";
            this.MnStripND.Click += new System.EventHandler(this.MnStripND_Click);
            // 
            // MnStripDX
            // 
            this.MnStripDX.Name = "MnStripDX";
            this.MnStripDX.Size = new System.Drawing.Size(256, 26);
            this.MnStripDX.Text = "Đăng Xuất";
            this.MnStripDX.Click += new System.EventHandler(this.MnStripDX_Click);
            // 
            // MnStripThoat
            // 
            this.MnStripThoat.Name = "MnStripThoat";
            this.MnStripThoat.Size = new System.Drawing.Size(256, 26);
            this.MnStripThoat.Text = "Thoát";
            this.MnStripThoat.Click += new System.EventHandler(this.MnStripThoat_Click);
            // 
            // MnStripNhanVien
            // 
            this.MnStripNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripNhanVien.Name = "MnStripNhanVien";
            this.MnStripNhanVien.Size = new System.Drawing.Size(107, 26);
            this.MnStripNhanVien.Text = "Nhân Viên";
            this.MnStripNhanVien.Click += new System.EventHandler(this.MnStripNhanVien_Click);
            // 
            // MnStripKH
            // 
            this.MnStripKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripKH.Name = "MnStripKH";
            this.MnStripKH.Size = new System.Drawing.Size(124, 26);
            this.MnStripKH.Text = "Khách Hàng";
            this.MnStripKH.Click += new System.EventHandler(this.MnStripKH_Click);
            // 
            // MnStripSp
            // 
            this.MnStripSp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripSp.Name = "MnStripSp";
            this.MnStripSp.Size = new System.Drawing.Size(105, 26);
            this.MnStripSp.Text = "Sản Phẩm";
            this.MnStripSp.Click += new System.EventHandler(this.MnStripSp_Click);
            // 
            // MnStripLSP
            // 
            this.MnStripLSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnStripLSP.Name = "MnStripLSP";
            this.MnStripLSP.Size = new System.Drawing.Size(142, 26);
            this.MnStripLSP.Text = "Loại sản phẩm";
            this.MnStripLSP.Click += new System.EventHandler(this.MnStripLSP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QL_BanHang.Properties.Resources.ban_hang;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 446);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lập hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MnStripHD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM CHÍNH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MnStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem MnStripND;
        private System.Windows.Forms.ToolStripMenuItem MnStripDX;
        private System.Windows.Forms.ToolStripMenuItem MnStripThoat;
        private System.Windows.Forms.ToolStripMenuItem MnStripNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MnStripKH;
        private System.Windows.Forms.ToolStripMenuItem MnStripSp;
        private System.Windows.Forms.ToolStripMenuItem MnStripLSP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

