using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Obiect
{
    class TaiKhoanObj
    {
        string manv, matkhau, phanquyen;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
       
        public string PhanQuyen
        {
            get { return phanquyen; }
            set { phanquyen = value; }
        }


        public TaiKhoanObj() { }
        public TaiKhoanObj(string manv, string matkhau, string phanquyen)
        {
            this.manv = manv;
            this.matkhau = matkhau;
            this.phanquyen = phanquyen;
        }
    }
}
