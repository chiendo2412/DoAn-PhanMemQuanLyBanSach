using DoAn_BanSach.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn_BanSach.View
{
    public partial class frmDangNhap : Form
    {
        public static string UsertName = "";

        NhanVienCtr nvCtr = new NhanVienCtr();
        public frmDangNhap()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            Init_Data();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaNV.Focus();
           // txtMaNV.Text = Properties.Settings.Default.MaNV;
            //txtMatkhau.Text = Properties.Settings.Default.MatKhau;


        }
        //-----Set color for Background gradient-----
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn hủy bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
      

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string strMaNV = txtMaNV.Text.Trim();
            string strMK = txtMatkhau.Text.Trim();
            string strErr = string.Empty;
            if (strMaNV == string.Empty)
                strErr = "Chưa nhập Mã Nhân Viên";
            if (strMK == string.Empty)
                strErr += "\n Chưa nhập Mật Khẩu";
            if (strErr != string.Empty)
            {
                MessageBox.Show(" " + strErr, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=QuanLyBanSach;Integrated Security=True");
            try
            {
                con.Open();
                string manv = txtMaNV.Text;
                string matkhau = txtMatkhau.Text;
                string sql = "Select * from NhanVien where MaNV='" + manv + "' and MatKhau='" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Save_Data();
                    this.Hide();
                    frmTrangChu frmTrangChu = new frmTrangChu();
                    frmTrangChu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thông tin không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.MaNV != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txtMaNV.Text = Properties.Settings.Default.MaNV;
                    txtMatkhau.Text = Properties.Settings.Default.MatKhau;
                    checkBoxLuuMK.Checked = true;
                }
                else
                {
                    checkBoxLuuMK.Checked = true;
                    txtMaNV.Text = Properties.Settings.Default.MaNV;
                    txtMatkhau.Text = Properties.Settings.Default.MatKhau;
                }
            }
        }
        private void Save_Data()
        {
            if (checkBoxLuuMK.Checked)
            {
                Properties.Settings.Default.MaNV = txtMaNV.Text;
                Properties.Settings.Default.MatKhau = txtMatkhau.Text;
                Properties.Settings.Default.Remme = "Yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.MaNV = txtMaNV.Text;
                Properties.Settings.Default.MatKhau = "";
                Properties.Settings.Default.Remme = "No";
                Properties.Settings.Default.Save();
            }
        }

        
    }
}
