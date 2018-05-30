using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class ChitietPhieuNhapObj
    {
        string ma, masach;
        int soluong, gianhap;

        public int Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
            }
        }

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

        public string Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
        public ChitietPhieuNhapObj() { }

        public ChitietPhieuNhapObj(string ma, string masach, int soluong, int gianhap)
        {
            this.ma = ma;
            this.masach = masach;
            this.soluong = soluong;
            this.gianhap = gianhap;
        }
    }
}
