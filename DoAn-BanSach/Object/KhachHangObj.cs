using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Object
{
    class KhachHangObj
    {
        string ma, ten, gioitinh, diachi, sodt,ngaysinh;

        public string NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string MaKhachHang
        {
            get { return ma; }
            set { ma = value; }
        }
        public string TenKhachHang
        {
            get { return ten; }
            set { ten = value; }
        }
        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SoDT
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public KhachHangObj() { }
        public KhachHangObj(string ma, string ten, string gioitinh, string diachi, string sodt, string ngaysinh)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sodt = sodt;
            this.ngaysinh = ngaysinh;
        }
    }
}
