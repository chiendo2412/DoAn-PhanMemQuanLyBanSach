using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_BanSach.Model;

namespace DoAn_BanSach.View
{
    public partial class frmTimkiemSachTheoTheLoai : UserControl
    {
        public static frmTimkiemSachTheoTheLoai frmTKSTTL = new frmTimkiemSachTheoTheLoai();
        public frmTimkiemSachTheoTheLoai()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
        }
        private void frmTimkiemSachTheoTheLoai_Load(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            string sql = "Select * from TheLoai";
            SqlDataAdapter ad = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbbTheLoai.DataSource = dt;
            cbbTheLoai.DisplayMember = "TenTL";
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTheLoai.SelectedValue.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT        Sach.MaSach, Sach.TenSach,TheLoai.TenTL,TacGia.TenTG, NhaXuatBan.TenNXB, Sach.SoLuong ,  Sach.GiaBan FROM NhaXuatBan INNER JOIN Sach ON NhaXuatBan.MaNXB = Sach.MaNXB INNER JOIN TacGia ON Sach.MaTG = TacGia.MaTG INNER JOIN TheLoai ON Sach.MaTL = TheLoai.MaTL where TenTL like N'" + cbbTheLoai.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgvDS.DataSource = dt;
        }
    }
}
