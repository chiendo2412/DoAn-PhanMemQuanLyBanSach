using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_BanSach.Control;

namespace DoAn_BanSach.View
{
    public partial class frmDoiMatKhau : UserControl
    {
        string manv = frmDangNhappp.mnvlogin;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(string USN)
        {
            InitializeComponent();
            manv = USN;
        }
        public static frmDoiMatKhau frmDMK = new frmDoiMatKhau();
        private void btnDoi_Click(object sender, EventArgs e)
        {
            string matkhaucu = "", matkhaumoi = "";
            string strMKC = txtMKCu.Text.Trim();
            string strMKM = txtMKmoi.Text.Trim();
            string strNLMKM = txtNhaplaiMKMoi.Text.Trim();
            string strErr = string.Empty;
            if (strMKC == string.Empty)
                strErr = "Chưa nhập mật khẩu cũ";
            if (strMKM == string.Empty)
                strErr += "\n Chưa nhập mật khẩu mới";
            if (strNLMKM != strMKM)
                strErr += "\n Nhập lại mật khẩu mới không đúng";
            if (strErr != string.Empty)
            {
                MessageBox.Show(" " + strErr, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            foreach (DataRow row in NhanVienCtr.DangNhap(manv).Rows)
            {
                matkhaucu = row["MatKhau"].ToString();
            }
            if (txtMKCu.Text == matkhaucu)
            {
                matkhaumoi = txtMKmoi.Text;
                if (NhanVienCtr.ChangePassword(manv, matkhaumoi))
                {
                    MessageBox.Show("Thay đổi thành công.", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMKCu.ResetText();
                    txtMKmoi.ResetText();
                    txtNhaplaiMKMoi.ResetText();
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKCu.ResetText();
                    txtMKmoi.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKCu.ResetText();
                txtMKmoi.ResetText();
            }
        }
    }
}
