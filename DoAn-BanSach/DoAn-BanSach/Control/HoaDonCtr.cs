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
    class HoaDonCtr
    {
        HoaDonMod hdMod = new HoaDonMod();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public bool AddData(HoaDonObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public static string GetIDHoaDon()
        {
            return HoaDonMod.GetIDHoaDon();
        }

        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
        public static DataSet XuatHoaDon(string MaHD)
        {
            return HoaDonMod.XuatHoaDon(MaHD);
        }
    }
}
