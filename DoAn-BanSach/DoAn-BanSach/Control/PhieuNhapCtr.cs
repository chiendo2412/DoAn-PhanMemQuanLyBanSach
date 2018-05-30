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
    class PhieuNhapCtr
    {
        PhieuNhapMod pnMod = new PhieuNhapMod();
        public DataTable GetData()
        {
            return pnMod.GetData();
        }
        public bool AddData(PhieuNhapObj pnObj)
        {
            return pnMod.AddData(pnObj);
        }
        public static string GetIDPhieuNhap()
        {
            return PhieuNhapMod.GetIDPhieuNhap();
        }

        public bool DelData(string ma)
        {
            return pnMod.DelData(ma);
        }
        public static bool XoaPN(string MaPN)
        {
            return PhieuNhapMod.XoaPN(MaPN);
        }
        public static DataSet XuatPhieuNhapSach(string MaPN)
        {
            return PhieuNhapMod.XuatPhieuNhapSach(MaPN);
        }
    }
}
