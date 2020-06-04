using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Obiect
{
    class HangHoaObj
    {
        string ma, ten, loaiHH;
        int dongia, soluong;
        public string LoaiHH
        {
            get { return loaiHH; }
            set { loaiHH = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public string TenHangHoa
        {
            get { return ten; }
            set { ten = value; }
        }

        public string MaHangHoa
        {
            get { return ma; }
            set { ma = value; }
        }

        public HangHoaObj() { }
        public HangHoaObj(string ma, string ten, int dongia, int soluong, string loaihanghoa)
        {
            this.ma = ma;
            this.ten = ten;
            this.dongia = dongia;
            this.soluong = soluong;
            this.loaiHH = loaihanghoa;
        }
    }
}
