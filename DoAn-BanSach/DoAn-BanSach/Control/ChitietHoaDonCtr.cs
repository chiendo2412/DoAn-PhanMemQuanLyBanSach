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
    class ChitietHoaDonCtr
    {
        ChitietHoaDonMod cthdMod = new ChitietHoaDonMod();
        public DataTable GetData(string ma)
        {
            return cthdMod.GetData(ma);
        }
        public bool AddData(ChitietHoaDonObj cthdObj)
        {
            return cthdMod.AddData(cthdObj);
        }

        public bool DelData(string ma)
        {
            return cthdMod.DelData(ma);
        }

       
    }
}
