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
    public partial class frmXuatDanhSachNhaXuatBan : Form
    {
        public frmXuatDanhSachNhaXuatBan()
        {
            InitializeComponent();
        }

        private void frmXuatDanhSachNhaXuatBan_Load(object sender, EventArgs e)
        {
            NhaXuatBan report = new NhaXuatBan();
            report.SetDataSource(NhaXuatBanCtr.DanhSachNhaXuatBan());
            crystalReportViewer1.ReportSource = report;
        }
    }
}
