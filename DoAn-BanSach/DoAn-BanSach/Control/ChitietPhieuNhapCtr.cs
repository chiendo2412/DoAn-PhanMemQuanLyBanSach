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
    class ChitietPhieuNhapCtr
    {
        ChitietPhieuNhapMod ctpnMod = new ChitietPhieuNhapMod();
        public DataTable GetData(string ma)
        {
            return ctpnMod.GetData(ma);
        }
        public bool AddData(ChitietPhieuNhapObj ctpnObj)
        {
            return ctpnMod.AddData(ctpnObj);
        }

        public bool DelData(string ma)
        {
            return ctpnMod.DelData(ma);
        }

    }
}
