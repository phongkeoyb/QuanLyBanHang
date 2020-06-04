using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;


namespace QL_BanHang.Control
{
    class TaiKhoanCtr
    {

        TaiKhoanMod ndMod = new TaiKhoanMod();
        public DataTable GetData()
        {
            return ndMod.GetData();
        }
        public bool AddData(TaiKhoanObj ndObj)
        {
            return ndMod.AddData(ndObj);
        }
        public bool UpdData(TaiKhoanObj ndObj)
        {
            return ndMod.UpdData(ndObj);
        }   

        public bool DelData(string MaNV)
        {
            return ndMod.DelData(MaNV);
        }
    }
}
