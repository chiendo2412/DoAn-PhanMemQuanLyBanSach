using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class ChitietHoaDonObj
    {
        string mahd, masach;
        int soluong;

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

       
        

        public ChitietHoaDonObj() { }
        public ChitietHoaDonObj(string mahd, string masach, int soluong)
        {
            this.mahd = mahd;
            this.masach = masach;
            this.soluong = soluong;
        }
    }
}
