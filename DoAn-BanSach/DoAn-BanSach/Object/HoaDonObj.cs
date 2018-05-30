using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class HoaDonObj
        
    {
        string mahd, makhachhang, manhanvien;

        public string Mahd
        {
            get
            {
                return mahd;
            }

            set
            {
                mahd = value;
            }
        }

        public string Makhachhang
        {
            get
            {
                return makhachhang;
            }

            set
            {
                makhachhang = value;
            }
        }

        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
            }
        }

        
        public HoaDonObj() { }

        public HoaDonObj(string mahd, string makhachhang, string manhanvien)
        {
            this.mahd = mahd;
            this.makhachhang = makhachhang;
            this.manhanvien = manhanvien;
        }
    }
}
