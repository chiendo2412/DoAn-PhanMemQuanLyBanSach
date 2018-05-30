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
    class NhaCungCapCtr
    {
        NhaCungCapMod nccMod = new NhaCungCapMod();

        public static DataSet DanhSachNhaCungCap()
        {
            return NhaCungCapMod.DanhSachNhaCungCap();
        }
        public DataTable GetData()
        {
            return nccMod.GetData();
        }
        public bool AddData(NhaCungCapObj nccObj)
        {
            return nccMod.AddData(nccObj);
        }
        public bool UpdData(NhaCungCapObj nccObj)
        {
            return nccMod.UpdData(nccObj);
        }


        public bool DelData(string ma)
        {
            return nccMod.DelData(ma);
        }
    }
}
