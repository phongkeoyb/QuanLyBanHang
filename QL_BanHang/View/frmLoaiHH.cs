using QL_BanHang.Control;
using QL_BanHang.Obiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang.View
{
    public partial class frmLoaiHH : Form
    {
        LoaiHHCtr LHHCtr = new LoaiHHCtr();
        private int flagLuu = 0;
        public frmLoaiHH()
        {
            InitializeComponent();
        }

        private void frmLoaiHH_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = LHHCtr.GetData();
            dtgvLHH.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvLHH.DataSource, "MaLoaiHH");
            txtTenLHH.DataBindings.Clear();
            txtTenLHH.DataBindings.Add("Text", dtgvLHH.DataSource, "TenLoaiHH");
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMa.Enabled = e;
            txtTenLHH.Enabled = e;
        }


        private void clearData()
        {
            txtMa.Text = "";
            txtTenLHH.Text = "";
        }

        private void addData(LoaiHHObj lhh)
        {
            lhh.MaLHH = txtMa.Text.Trim();
            lhh.TenLHH = txtTenLHH.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (LHHCtr.DelData(txtMa.Text.Trim()))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLoaiHH_Load(sender, e);

                }

                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmLoaiHH_Load(sender, e);
                }

            }
            frmLoaiHH_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoaiHHObj lhhObj = new LoaiHHObj();
            addData(lhhObj);
            if (flagLuu == 0)
            {
                if (LHHCtr.AddData(lhhObj))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLoaiHH_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmLoaiHH_Load(sender, e);
                }

            }
            else
            {
                if (LHHCtr.UpdData(lhhObj))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLoaiHH_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmLoaiHH_Load(sender, e);
                }

            }
            frmLoaiHH_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmLoaiHH_Load(sender, e);
            else
                return;
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //cboHP.SelectedValue = dgvDiem.Rows[e.RowIndex].Cells["MaHP"].Value;
                txtMa.Text = dtgvLHH.Rows[e.RowIndex].Cells["MaloaiHH"].Value.ToString();
                txtTenLHH.Text = dtgvLHH.Rows[e.RowIndex].Cells["TenLoaiHH"].Value.ToString();
            }
        }
    }
}
