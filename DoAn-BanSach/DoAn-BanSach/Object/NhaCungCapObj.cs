using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class NhaCungCapObj
    {
        string ma, ten, diachi, email, sodt;
        public string MaNhaCungCap
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
        public string TenNhaCungCap
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
        public string DiaChi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string SoDT
        {
            get
            {
                return sodt;
            }

            set
            {
                sodt = value;
            }
        }
        public NhaCungCapObj() { }
        public NhaCungCapObj(string ma, string ten, string diachi, string email, string sodt)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.email = email;
            this.sodt = sodt;
        }
    }
}
