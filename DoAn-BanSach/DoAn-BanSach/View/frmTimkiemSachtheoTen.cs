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
    public partial class frmTimkiemSachtheoTen : UserControl
    {
        public static frmTimkiemSachtheoTen frmTKSTT = new frmTimkiemSachtheoTen();
        public frmTimkiemSachtheoTen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT        Sach.MaSach, Sach.TenSach,TheLoai.TenTL,TacGia.TenTG, NhaXuatBan.TenNXB, Sach.SoLuong ,  Sach.GiaBan FROM NhaXuatBan INNER JOIN Sach ON NhaXuatBan.MaNXB = Sach.MaNXB INNER JOIN TacGia ON Sach.MaTG = TacGia.MaTG INNER JOIN TheLoai ON Sach.MaTL = TheLoai.MaTL where TenSach like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
            
        }
    }
}
