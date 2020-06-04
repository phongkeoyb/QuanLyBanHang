using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Obiect
{
    class LoaiHHObj
    {
        private string maLHH,tenLHH;
        public string MaLHH
        {
            get { return maLHH; }
            set { maLHH = value; }
        }

        public string TenLHH
        {
            get { return tenLHH; }
            set { tenLHH = value; }
        }
        public LoaiHHObj()
        {
        }
        public LoaiHHObj(string malhh,string tlhh)
        {
            this.maLHH = malhh;
            this.tenLHH = tlhh;
        }

    }
}
