using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.View;

namespace QL_BanHang
{
    public partial class Form1 : Form
    {
        string quyen = "";
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string quyendn)
        {
            quyen = quyendn;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (quyen.Equals("Admin"))
            {
                MnStripHeThong.Enabled = true;
            }
        }

        private void MnStripND_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung frmND = new QuanLyNguoiDung();
           
            frmND.ShowDialog();
           
        }

        private void MnStripNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
            
        }

        private void MnStripKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
            
        }

        private void MnStripSp_Click(object sender, EventArgs e)
        {
            frmHangHoa frmSP = new frmHangHoa();
            frmSP.ShowDialog();
           
        }

        private void MnStripHD_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.ShowDialog();
            
        }

        private void MnStripHeThong_Click(object sender, EventArgs e)
        {

        }

        private void MnStripDN_Click(object sender, EventArgs e)
        {

        }

        private void MnStripDX_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void MnStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnStripLSP_Click(object sender, EventArgs e)
        {
            frmLoaiHH loaiHH = new frmLoaiHH();
            loaiHH.ShowDialog();
        }
    }
}
