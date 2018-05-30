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


        public static DataTable DanhSachSach()
        {
            return SachMod.DanhSachSach();
        }
        public static DataSet ThongKeTonKho()
        {
            return SachMod.ThongKeTonKho();
        }
        public DataTable GetData()
        {
            return sachMod.GetData();
        }
        public DataTable GetData(string dieukien)
        {
            return sachMod.GetData(dieukien);
        }
        public bool AddData(SachObj sachObj)
        {
            return sachMod.AddData(sachObj);
        }
        public bool UpdData(SachObj sachObj)
        {
            return sachMod.UpdData(sachObj);
        }
        public static DataTable BaoCaoNhapKho(DateTime Ngay)
        {
            return SachMod.BaoCaoNhapKho(Ngay);
        }
        public static DataSet BaoCaoNhapKhoS(DateTime Ngay)
        {
            return SachMod.BaoCaoNhapKhoS(Ngay);
        }
        public static DataTable BaoCaoDoanhThu(DateTime Ngay)
        {
            return SachMod.BaoCaoDoanhThu(Ngay);
        }
        public static DataSet BaoCaoDoanhThus(DateTime Ngay)
        {
            return SachMod.BaoCaoDoanhThus(Ngay);
        }

        public bool DelData(string ma)
        {
            return sachMod.DelData(ma);
        }
    }
}
