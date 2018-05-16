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
    public partial class frmTimkiemSachtheoTacGia : UserControl
    {
        public static frmTimkiemSachtheoTacGia frmTKSTTG = new frmTimkiemSachtheoTacGia();
        public frmTimkiemSachtheoTacGia()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
        }

        private void frmTimkiemSachtheoTacGia_Load(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            string sql = "Select * from TacGia";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbbTG.DataSource = dt;
            cbbTG.DisplayMember = "TenTG";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT        Sach.MaSach, Sach.TenSach,TheLoai.TenTL,TacGia.TenTG, NhaXuatBan.TenNXB, Sach.SoLuong ,  Sach.GiaBan FROM NhaXuatBan INNER JOIN Sach ON NhaXuatBan.MaNXB = Sach.MaNXB INNER JOIN TacGia ON Sach.MaTG = TacGia.MaTG INNER JOIN TheLoai ON Sach.MaTL = TheLoai.MaTL where TenTG like N'" + cbbTG.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgvDS.DataSource = dt;
        }
    }
}
