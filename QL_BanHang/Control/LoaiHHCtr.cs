using QL_BanHang.Model;
using QL_BanHang.Obiect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Control
{
    class LoaiHHCtr
    {
        LoaiHHMod lhhMod = new LoaiHHMod();
        public DataTable GetData()
        {
            return lhhMod.GetData();
        }
        public bool AddData(LoaiHHObj lhhObj)
        {
            return lhhMod.AddData(lhhObj);
        }
        public bool UpdData(LoaiHHObj lhhObj)
        {
            return lhhMod.UpdData(lhhObj);
        }

        public bool DelData(string ma)
        {
            return lhhMod.DelData(ma);
        }
    }
}
