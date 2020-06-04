using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_BanHang.View
{
    public partial class frmDangNhap : Form
    {

        SqlConnection con;
        SqlDataAdapter sda;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btThoay_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-2EKSP0C;Initial Catalog=QL_BanHang;Integrated Security=True");
            con.Open();         
           
            sda = new SqlDataAdapter("Select PhanQuyen from TaiKhoan where MaNV ='"+txtDN.Text+"' and MatKhau ='"+txtMkND.Text+"'",con);           
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Form1 frm1 = new Form1(dt.Rows[0]["PhanQuyen"].ToString ());
                frm1.Show();
              
            }
        
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
        
}
