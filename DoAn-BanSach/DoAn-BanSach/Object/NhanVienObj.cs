using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class NhanVienObj
    {
        string ma, ten, email, sodt, diachi, ngaysinh, gioitinh, cmnd, matkhau, quyen;
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
        public string Quyen
        {
            get
            {
                return quyen;
            }
            set
            {
                quyen = value;
            }
        }
        public string Matkhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
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

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string MaNhanVien
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

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string TenNhanVien
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

        public NhanVienObj() { }

        public NhanVienObj(string ma, string ten, string email,string sodt, string diachi, string ngaysinh, string gioitinh, string cmnd, string matkhau, string quyen)
        {
            this.ma = ma;
            this.ten = ten;
            this.email = email;
            this.sodt = sodt;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
    }
}
