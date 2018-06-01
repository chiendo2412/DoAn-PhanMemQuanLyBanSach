using DoAn_BanSach.Control;
using DoAn_BanSach.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_BanSach.View
{
    public partial class frmDangNhappp : Form
    {
        public static String mnvlogin;
            
            
        int dem = 0;
        public frmDangNhappp()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            Init_Data();
        }

        private void frmDangNhappp_Load(object sender, EventArgs e)
        {

        }
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
            NhanVienObj nvObj = new NhanVienObj();
            string matkhau = "", ten = "", manv = "", phanquyen = "";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                while (true)
                {
                    manv = txtMaNV.Text;
                    foreach (DataRow row in NhanVienCtr.DangNhap(manv).Rows)
                    {
                        matkhau = row["MatKhau"].ToString();
                        ten = row["TenNV"].ToString();
                        phanquyen = row["Quyen"].ToString();

                    }
                    if (txtMatkhau.Text == matkhau)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Save_Data();
                        mnvlogin= txtMaNV.Text;
                        if (phanquyen == "Admin")
                        {
                            this.Hide();
                            frmTrangChu frm = new frmTrangChu(ten, manv, phanquyen);
                            frm.ShowDialog();
                            this.Show();
                            txtMatkhau.ResetText();
                            break;
                        }
                        else if (phanquyen == "User")
                        {
                            this.Hide();
                            frmUser frm = new frmUser(ten, manv, phanquyen);
                            frm.ShowDialog();
                            this.Show();
                            txtMatkhau.ResetText();
                            break;
                        }
                    }
                    else
                    {
                        if (dem == 3)
                        {
                            MessageBox.Show("Bạn nhập sai quá 3 lần cho phép.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            break;
                        }
                        dem++;
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
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
