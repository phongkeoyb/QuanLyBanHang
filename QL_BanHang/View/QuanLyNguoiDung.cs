using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control;
using QL_BanHang.Obiect;

namespace QL_BanHang.View
{
    public partial class QuanLyNguoiDung : Form

    {
        TaiKhoanCtr ndCtr = new TaiKhoanCtr();
        private int flagLuu = 0;
        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = ndCtr.GetData();
            dsNguoiDung.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtmk1.DataBindings.Clear();
            txtmk1.DataBindings.Add("Text", dsNguoiDung.DataSource, "MatKhau");
            txtTk.DataBindings.Clear();
            txtTk.DataBindings.Add("Text", dsNguoiDung.DataSource, "MaNV");
            cbQuyen.DataBindings.Clear();
            cbQuyen.DataBindings.Add("Text", dsNguoiDung.DataSource, "PhanQuyen");
        }
        
        private void loadCMBPQ()
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("Admin");
            cbQuyen.Items.Add("Member");
            cbQuyen.SelectedItem = 0;
        }
        private void clearData()
        {
            txtmk1.Text = "";
            txtTk.Text = "";
            
            loadCMBPQ();
        }
        private void DisEnl(bool e)
        {
            btThemND.Enabled = !e;
            btSuaND.Enabled = !e;
            BtXoaND.Enabled = !e;
            btluu.Enabled = e;
            bthuy.Enabled = e;
            txtmk1.Enabled = e;
            txtTk.Enabled = e;
            
            cbQuyen.Enabled = e;
            
        }
        private void addData(TaiKhoanObj nd)
        {
            nd.MatKhau = txtmk1.Text.Trim();
            
            nd.MaNV = txtTk.Text.Trim();
            nd.PhanQuyen = cbQuyen.Text;
            
        }

        private void btThemND_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btSuaND_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMBPQ();
        }

        private void BtXoaND_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ndCtr.DelData(txtmk1.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLyNguoiDung_Load(sender, e);
                }
                    
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            TaiKhoanObj NDObj = new TaiKhoanObj();
            addData(NDObj);
            if (flagLuu == 0)
            {
                if (ndCtr.AddData(NDObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ndCtr.UpdData(NDObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyNguoiDung_Load(sender, e);
        }

        private void QuanLyNguoiDung_Load_1(object sender, EventArgs e)
        {
            QuanLyNguoiDung_Load(sender, e);
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                QuanLyNguoiDung_Load(sender, e);
            else
                return;
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
