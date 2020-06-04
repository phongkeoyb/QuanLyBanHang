using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;

namespace QL_BanHang.Control
{
    class HangHoaCtr
    {

        HangHoaMod hhMod = new HangHoaMod();
        public DataTable GetData()
        {
            return hhMod.GetData();
        }
        public DataTable GetData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
        public bool AddData(HangHoaObj hhObj)
        {
            return hhMod.AddData(hhObj);
        }
        public bool UpdData(HangHoaObj hhObj)
        {
            return hhMod.UpdData(hhObj);
        }
        
        
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}
