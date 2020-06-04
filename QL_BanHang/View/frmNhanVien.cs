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
    public partial class frmNhanVien : Form
    {
        NhanVienCtr nvCtr = new NhanVienCtr();
        private int flagLuu = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.GetData();
            dtgvDS.DataSource = dtDS;
            DisEnl(false);
        }
       

        private void loadCMB()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.SelectedItem = 0;
        }

        private void clearData()
        {
            cbmMaNV.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            dpNamSinh.Value = DateTime.Now.Date;
            loadCMB();
        }

        private void LoadcmbNV()
        {
            cbmMaNV.DataSource = nvCtr.GetData1();
            cbmMaNV.DisplayMember = "MaNV";
            cbmMaNV.ValueMember = "MaNV";

        }
        private void addData(NhanVienObj nv)
        {
            
            nv.MaNhanVien = cbmMaNV.Text.Trim();
            if (cmbGioiTinh.SelectedIndex == 0)
            {
                nv.GioiTinh = "Nam";
            }
            else
                nv.GioiTinh = "Nữ";
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.DienThoai = txtSDT.Text.Trim();
            nv.TenNhanVien = txtTen.Text.Trim();
            nv.NamSinh = dpNamSinh.Text;
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            cbmMaNV.Enabled = e;
            txtTen.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dpNamSinh.Enabled = e;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadcmbNV();
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtr.DelData(cbmMaNV.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhanVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            loadCMB();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienObj nvObj = new NhanVienObj();
            addData(nvObj);
            if (flagLuu == 0)
            {
                if (nvCtr.AddData(nvObj))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhanVien_Load(sender, e);
                }
                    
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvCtr.UpdData(nvObj))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhanVien_Load(sender, e);
                }
                    
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmNhanVien_Load(sender, e);
            }
            else
                return;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                cbmMaNV.Text = dtgvDS.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                txtTen.Text = dtgvDS.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                cmbGioiTinh.Text = dtgvDS.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                dpNamSinh.Text = dtgvDS.Rows[e.RowIndex].Cells["NamSinh"].Value.ToString();
                txtSDT.Text = dtgvDS.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtDiaChi.Text = dtgvDS.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
