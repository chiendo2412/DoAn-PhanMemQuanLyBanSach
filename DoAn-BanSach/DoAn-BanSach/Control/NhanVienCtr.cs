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
    class NhanVienCtr
    {
        NhanVienMod nvMod = new NhanVienMod();
        public static DataSet DanhSachNhanVien()
        {
            return NhanVienMod.DanhSachNhanVien();
        }

        public static DataTable DangNhap(string MaNV)
        {
            return NhanVienMod.DangNhap(MaNV);
        }

        public static bool ChangePassword(string MaNV, string MatKhau)
        {
            return NhanVienMod.ChangePassword(MaNV, MatKhau);
        }
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public DataTable GetData(string dieukien)
        {
            return nvMod.GetData(dieukien);
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
