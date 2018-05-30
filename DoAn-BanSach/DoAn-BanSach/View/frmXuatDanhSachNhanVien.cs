using DoAn_BanSach.Control;
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
    public partial class frmXuatDanhSachNhanVien : Form
    {
        public frmXuatDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void frmXuatDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien report = new NhanVien();
            report.SetDataSource(NhanVienCtr.DanhSachNhanVien());
            crystalReportViewer1.ReportSource = report;
        }
    }
}
