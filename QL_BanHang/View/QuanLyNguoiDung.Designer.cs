namespace QL_BanHang.View
{
    partial class QuanLyNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.BtXoaND = new System.Windows.Forms.Button();
            this.btSuaND = new System.Windows.Forms.Button();
            this.btThemND = new System.Windows.Forms.Button();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmk1 = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dsNguoiDung = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bthuy);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.BtXoaND);
            this.groupBox1.Controls.Add(this.btSuaND);
            this.groupBox1.Controls.Add(this.btThemND);
            this.groupBox1.Controls.Add(this.cbQuyen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmk1);
            this.groupBox1.Controls.Add(this.txtTk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(781, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Ký Thông tin Người Dùng";
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Location = new System.Drawing.Point(626, 150);
            this.bthuy.Margin = new System.Windows.Forms.Padding(2);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(98, 37);
            this.bthuy.TabIndex = 22;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Location = new System.Drawing.Point(484, 150);
            this.btluu.Margin = new System.Windows.Forms.Padding(2);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(98, 37);
            this.btluu.TabIndex = 21;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // BtXoaND
            // 
            this.BtXoaND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtXoaND.Location = new System.Drawing.Point(337, 150);
            this.BtXoaND.Margin = new System.Windows.Forms.Padding(2);
            this.BtXoaND.Name = "BtXoaND";
            this.BtXoaND.Size = new System.Drawing.Size(98, 37);
            this.BtXoaND.TabIndex = 20;
            this.BtXoaND.Text = "Xóa";
            this.BtXoaND.UseVisualStyleBackColor = true;
            this.BtXoaND.Click += new System.EventHandler(this.BtXoaND_Click);
            // 
            // btSuaND
            // 
            this.btSuaND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaND.Location = new System.Drawing.Point(195, 150);
            this.btSuaND.Margin = new System.Windows.Forms.Padding(2);
            this.btSuaND.Name = "btSuaND";
            this.btSuaND.Size = new System.Drawing.Size(98, 37);
            this.btSuaND.TabIndex = 19;
            this.btSuaND.Text = "Sữa";
            this.btSuaND.UseVisualStyleBackColor = true;
            this.btSuaND.Click += new System.EventHandler(this.btSuaND_Click);
            // 
            // btThemND
            // 
            this.btThemND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemND.Location = new System.Drawing.Point(37, 150);
            this.btThemND.Margin = new System.Windows.Forms.Padding(2);
            this.btThemND.Name = "btThemND";
            this.btThemND.Size = new System.Drawing.Size(98, 37);
            this.btThemND.TabIndex = 18;
            this.btThemND.Text = "Thêm";
            this.btThemND.UseVisualStyleBackColor = true;
            this.btThemND.Click += new System.EventHandler(this.btThemND_Click);
            // 
            // cbQuyen
            // 
            this.cbQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cbQuyen.Location = new System.Drawing.Point(337, 101);
            this.cbQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(203, 23);
            this.cbQuyen.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quyền";
            // 
            // txtmk1
            // 
            this.txtmk1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmk1.Location = new System.Drawing.Point(547, 44);
            this.txtmk1.Margin = new System.Windows.Forms.Padding(2);
            this.txtmk1.Name = "txtmk1";
            this.txtmk1.Size = new System.Drawing.Size(203, 21);
            this.txtmk1.TabIndex = 7;
            // 
            // txtTk
            // 
            this.txtTk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTk.Location = new System.Drawing.Point(176, 45);
            this.txtTk.Margin = new System.Windows.Forms.Padding(2);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(203, 21);
            this.txtTk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dsNguoiDung);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(781, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dành Sách Người Dùng";
            // 
            // dsNguoiDung
            // 
            this.dsNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsNguoiDung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MatKhau,
            this.Quen});
            this.dsNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsNguoiDung.Location = new System.Drawing.Point(2, 18);
            this.dsNguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.dsNguoiDung.Name = "dsNguoiDung";
            this.dsNguoiDung.RowTemplate.Height = 24;
            this.dsNguoiDung.Size = new System.Drawing.Size(777, 210);
            this.dsNguoiDung.TabIndex = 0;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // Quen
            // 
            this.Quen.DataPropertyName = "PhanQuyen";
            this.Quen.HeaderText = "Quyền truy cập";
            this.Quen.Name = "Quen";
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyNguoiDung";
            this.Text = "QuanLyNguoiDung";
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmk1;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Button BtXoaND;
        private System.Windows.Forms.Button btSuaND;
        private System.Windows.Forms.Button btThemND;
        private System.Windows.Forms.DataGridView dsNguoiDung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quen;
    }
}