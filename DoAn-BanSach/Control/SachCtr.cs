using DoAn_BanSach.Model;
using DoAn_BanSach.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Control
{
    class SachCtr
    {
        SachMod sachMod = new SachMod();
        public DataTable GetData()
        {
            return sachMod.GetData();
        }
        public bool AddData(SachObj sachObj)
        {
            return sachMod.AddData(sachObj);
        }
        public bool UpdData(SachObj sachObj)
        {
            return sachMod.UpdData(sachObj);
        }


        public bool DelData(string ma)
        {
            return sachMod.DelData(ma);
        }
    }
}
