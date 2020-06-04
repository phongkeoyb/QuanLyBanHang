﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;

namespace QL_BanHang.Control
{
    class NhanVienCtr
    {

        NhanVienMod nvMod = new NhanVienMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public DataTable GetData1()
        {
            return nvMod.GetData1();
        }
        public bool AddData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }
        
        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
