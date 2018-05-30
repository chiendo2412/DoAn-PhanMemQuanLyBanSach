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
    public partial class frmHDNhapSach : UserControl
    {
        PhieuNhapCtr pnCtr = new PhieuNhapCtr();
        ChitietPhieuNhapCtr ctpnCtr = new ChitietPhieuNhapCtr();
        public frmHDNhapSach()
        {
            InitializeComponent();
        }
        public static frmHDNhapSach frmHDNS = new frmHDNhapSach();
        private void frmHDNhapSach_Load(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = pnCtr.GetData();
            dtGRdanhsachPN.DataSource = dt;
            bingding();
        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtGRdanhsachPN.DataSource, "MaPN");
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmChitietPhieuNhap frmpn = new frmChitietPhieuNhap();
            frmpn.ShowDialog();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ctpnCtr.GetData(txtMa.Text.Trim());
                dtGRchitietphieunhap.DataSource = dt;
            }
            catch
            {
                dtGRchitietphieunhap.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHDNhapSach_Load(sender, e);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (pnCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đã tồn tại chi tiết phiếu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            frmHDNhapSach_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmXuatPhieuNhap frm = new frmXuatPhieuNhap(txtMa.Text);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
