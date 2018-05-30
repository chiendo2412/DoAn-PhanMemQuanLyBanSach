using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class PhieuNhapObj
    {
        string ma, manhanvien, manhacungcap, ngaynhap;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Manhacungcap
        {
            get
            {
                return manhacungcap;
            }

            set
            {
                manhacungcap = value;
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

        public string Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
            }
        }
        public PhieuNhapObj() { }

        public PhieuNhapObj(string ma, string manhanvien, string manhacungcap, string ngaynhap)
        {
            this.ma = ma;
            this.manhanvien = manhanvien;
            this.manhacungcap = manhacungcap;
            this.ngaynhap = ngaynhap;
        }
    }
}
