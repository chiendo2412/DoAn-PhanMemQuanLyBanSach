using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_BanSach.View
{
    public partial class frmUser : Form
    {
        string manv = "", phanquyen = "";
        public frmUser()
        {
            InitializeComponent();
        }
        public frmUser(string Hoten, string USN, string PQ)
        {
            InitializeComponent();
            label1.Text = "Nhân viên: " + Hoten;
            label1.ForeColor = Color.Red;
            manv = USN;
            phanquyen = PQ;
        }

        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            //Kiểm tra tồn trại trang này chưa
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        //Đóng tab hiện tai
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        //Đóng all tab
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();

            }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmHDBanSach.frmHDBS, 4, "Bán Sách");
        }

        private void đóngTrangHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }
        private void theoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachtheoTen.frmTKSTT, 4, "Tìm kiếm theo tên sách");

        }

        private void theoNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachtheoTacGia.frmTKSTTG, 4, "Tìm kiếm theo tác giả");
        }

        private void theoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachTheoTheLoai.frmTKSTTL, 4, "Tìm kiếm theo thể loại");
        }

        private void theoTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachtheoNXB.frmTKSTNXB, 4, "Tìm kiếm theo nhà xuất bản");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmDoiMatKhau.frmDMK, 4, "Đổi Mật Khẩu");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemkhachhang.frmTKKH, 4, "Tìm kiếm Khách Hàng");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemnhanvien.frmTKNV, 4, "Tìm kiếm Nhân Viên");
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemNXB.frmTKNXB, 4, "Tìm kiếm Nhà Xuất Bản");
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemtacgia.frmTKTG, 4, "Tìm kiếm Tác Giả");
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemNCC.frmTKNCC, 4, "Tìm kiếm Nhà Cung Cấp");
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void lậpPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmHDNhapSach.frmHDNS, 4, "Nhập Sách");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemTabPages(View.frmDoiMatKhau.frmDMK, 4, "Đổi Mật Khẩu");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }

        }
    }
}
