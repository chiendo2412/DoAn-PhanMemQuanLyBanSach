using DoAn_BanSach.Control;
using DoAn_BanSach.Model;
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

    public partial class frmXuatPhieuNhap : Form
    {
        string mapn;
        public frmXuatPhieuNhap()
        {
            InitializeComponent();
        }
        public frmXuatPhieuNhap(string MaPN)
        {
            InitializeComponent();
            mapn = MaPN;
        }

        private void frmXuatPhieuNhap_Load(object sender, EventArgs e)
        {
            PhieuNhapSach report = new PhieuNhapSach();
            report.SetDataSource(PhieuNhapCtr.XuatPhieuNhapSach(mapn));
            crpvXuatPhieuNhap.ReportSource = report;
        }
    }
}
