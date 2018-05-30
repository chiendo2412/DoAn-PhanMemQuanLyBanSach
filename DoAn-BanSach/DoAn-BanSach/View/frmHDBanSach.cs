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
using DoAn_BanSach.Object;

namespace DoAn_BanSach.View
{
    public partial class frmHDBanSach : UserControl
    {
        HoaDonCtr hdCtr = new HoaDonCtr();
        ChitietHoaDonCtr cthdCtr = new ChitietHoaDonCtr();

        public frmHDBanSach()
        {
            InitializeComponent();
        }
        public static frmHDBanSach frmHDBS = new frmHDBanSach();
        private void frmHDBanSach_Load(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtGRdanhsachHD.DataSource = dt;
            bingding();
        }
        private void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtGRdanhsachHD.DataSource, "MaHD");
        }
        
        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmChitietHoaDon frmhd = new frmChitietHoaDon();
            frmhd.ShowDialog();
            
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = cthdCtr.GetData(txtMa.Text.Trim());
                dtGRchitiethoadon.DataSource = dt;
            }
            catch
            {
                dtGRchitiethoadon.DataSource = null;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đã tồn tại chi tiết hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            frmHDBanSach_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHDBanSach_Load(sender, e);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmXuatHoaDon frm = new frmXuatHoaDon(txtMa.Text);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
