using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn_BanSach.View
{
    public partial class frmTimkiemSachtheoNXB : UserControl
    {
        public static frmTimkiemSachtheoNXB frmTKSTNXB = new frmTimkiemSachtheoNXB();
        public frmTimkiemSachtheoNXB()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
        }

        private void frmTimkiemSachtheoNXB_Load(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            string sql = "Select * from NhaXuatBan";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbbNXB .DataSource = dt;
            cbbNXB.DisplayMember = "TenNXB";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT        Sach.MaSach, Sach.TenSach,TheLoai.TenTL,TacGia.TenTG, NhaXuatBan.TenNXB, Sach.SoLuong ,  Sach.GiaBan FROM NhaXuatBan INNER JOIN Sach ON NhaXuatBan.MaNXB = Sach.MaNXB INNER JOIN TacGia ON Sach.MaTG = TacGia.MaTG INNER JOIN TheLoai ON Sach.MaTL = TheLoai.MaTL where TenNXB like N'" + cbbNXB.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgvDS.DataSource = dt;
        }
    }
}
