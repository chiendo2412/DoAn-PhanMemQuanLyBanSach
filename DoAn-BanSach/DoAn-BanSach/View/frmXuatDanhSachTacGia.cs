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
    public partial class frmXuatDanhSachTacGia : Form
    {
        public frmXuatDanhSachTacGia()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            TacGia report = new TacGia();
            report.SetDataSource(TacGiaCtr.DanhSachTacGia());
            crystalReportViewer1.ReportSource = report;
        }
    }
}
