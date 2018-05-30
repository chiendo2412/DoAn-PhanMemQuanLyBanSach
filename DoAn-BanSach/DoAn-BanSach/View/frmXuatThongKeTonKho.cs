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
    public partial class frmXuatThongKeTonKho : Form
    {
        public frmXuatThongKeTonKho()
        {
            InitializeComponent();
        }

        private void frmXuatThongKeTonKho_Load(object sender, EventArgs e)
        {
            ThongKeTonKho report = new ThongKeTonKho();
            report.SetDataSource(SachCtr.ThongKeTonKho());
            crystalReportViewer1.ReportSource = report;
        }
    }
}
