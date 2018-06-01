﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_BanSach.View;

namespace DoAn_BanSach
{
    public partial class frmTrangChu : Form
    {
        string manv = "", phanquyen = "";
        public frmTrangChu()
        {
            InitializeComponent();
        }
        public frmTrangChu(string Hoten, string USN, string PQ)
        {
            InitializeComponent();
            label2.Text = "Nhân viên: " + Hoten;
            label2.ForeColor = Color.Red;
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

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmNhanVien.frmNV, 4, "Quản lý Nhân Viên");
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmKhachHang.frmKH, 4, "Quản lý Khách Hàng");
        }

        private void đóngTrangHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmNhaXuatBan.frmNXB, 4, "Quản lý Nhà Xuất Bản:");
        }
        private void tìmKiếmKháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemkhachhang.frmTKKH, 4, "Tìm kiếm Khách Hàng");
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemnhanvien.frmTKNV, 4, "Tìm kiếm Nhân Viên");
        }

        private void tìmKiếmNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemNXB.frmTKNXB, 4, "Tìm kiếm Nhà Xuất Bản");
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTacgia.frmTG, 4, "Quản Lý Tác Giả");
        }

        private void tìmKiếmTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemtacgia.frmTKTG, 4, "Tìm kiếm Tác Giả");
        }

        private void TabHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTheloai.frmTL, 4, "Quản lý Thể Loại");
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmNhaCungCap.frmNCC, 4, "Quản lý Nhà Cung Cấp");
        }

        private void tìmKiếmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemNCC.frmTKNCC, 4, "Tìm kiếm Nhà Cung Cấp");
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmSach.frmS, 4, "Cập nhật Sách");
        }

        private void hóaĐơnBánSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmHDBanSach.frmHDBS, 4, "Bán Sách");
        }

        private void theoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachtheoTen.frmTKSTT, 4, "Tìm kiếm Sách theo Tên");
        }

        private void theoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachTheoTheLoai.frmTKSTTL, 4, "Tìm kiếm Sách theo Thể Loại");
        }

        private void theoTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachtheoNXB.frmTKSTNXB, 4, "Tìm kiếm Sách theo Nhà Xuất Bản");
        }

        private void theoNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmTimkiemSachtheoTacGia.frmTKSTTG, 4, "Tìm kiếm Sách theo Tác Giả");
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmHDNhapSach.frmHDNS, 4, "Nhập Sách");
        }

        private void thốngKêTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmBaocaoTonKho.frmBCTK, 4, "Thống kê tồn kho");
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmBaocaoDoanhThu.frmBCDT, 4, "Báo cáo Doanh thu");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmDoiMatKhau.frmDMK, 4, "Đổi Mật Khẩu");
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu();
            frm.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void báoCáoNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frmBaocaoNhapKho.frmBCNK, 4, "Báo cáo Nhập kho");
        }
    }
}
