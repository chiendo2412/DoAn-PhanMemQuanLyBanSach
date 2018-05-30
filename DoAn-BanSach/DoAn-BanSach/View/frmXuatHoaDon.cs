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
    public partial class frmXuatHoaDon : Form
    {
        string mahd;
        public frmXuatHoaDon()
        {
            InitializeComponent();
        }
        public frmXuatHoaDon(string MaHD)
        {
            InitializeComponent();
            mahd = MaHD;
        }
        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            XuatHoaDon report = new XuatHoaDon();
            report.SetDataSource(HoaDonCtr.XuatHoaDon(mahd));
            crtpvXuatHoaDon.ReportSource = report;
        }
    }
}
