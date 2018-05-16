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
using DoAn_BanSach.Control;

namespace DoAn_BanSach.View
{
    public partial class frmTimkiemNCC : UserControl
    {
        NhaCungCapCtr nccCtr = new NhaCungCapCtr();
        public frmTimkiemNCC()
        {
            InitializeComponent();
        }
        public static frmTimkiemNCC frmTKNCC = new frmTimkiemNCC();

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.Text == "Mã NCC")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  NhaCungCap where MaNCC like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
            else if (cbbTimkiem.Text == "Tên NCC")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from  NhaCungCap where TenNCC like N'" + txtTimkiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dtgvDS.DataSource = dt;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cbbTimkiem.Text = "";
            txtTimkiem.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmTimkiemNCC_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nccCtr.GetData();
            dtgvDS.DataSource = dtDS;
        }
    }
}