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
    public partial class frmXuatDanhSachNhaCungCap : Form
    {
        public frmXuatDanhSachNhaCungCap()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            NhaCungCap report = new NhaCungCap();
            report.SetDataSource(NhaCungCapCtr.DanhSachNhaCungCap());
            crystalReportViewer1.ReportSource = report;
        }
    }
}
