using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class SachObj
    {
        string ma, ten, matheloai, matacgia, manhaxuatban; 
         int soluong, giaban;

        public int Giaban
        {
            get
            {
                return giaban;
            }

            set
            {
                giaban = value;
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

        public string Manhaxuatban
        {
            get
            {
                return manhaxuatban;
            }

            set
            {
                manhaxuatban = value;
            }
        }

        public string Matacgia
        {
            get
            {
                return matacgia;
            }

            set
            {
                matacgia = value;
            }
        }

        public string Matheloai
        {
            get
            {
                return matheloai;
            }

            set
            {
                matheloai = value;
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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public SachObj() { }
        public SachObj(string ma, string ten, string matheloai, string matacgia, string manhaxuatban, int giaban, int soluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.matheloai = matheloai;
            this.matacgia = matacgia;
            this.manhaxuatban = manhaxuatban;
            this.giaban = giaban;
            this.soluong = soluong;
        }
    }
}
