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

    public partial class frmXuatNhapKho : Form
    {
        DateTime ngay;
        public frmXuatNhapKho()
        {
            InitializeComponent();
        }
        public frmXuatNhapKho(DateTime Ngay)
        {
            InitializeComponent();
            ngay = Ngay;
        }

        private void frmXuatNhapKho_Load(object sender, EventArgs e)
        {
            BaoCaoNhapKho report = new BaoCaoNhapKho();
            report.SetDataSource(SachCtr.BaoCaoNhapKhoS(ngay));
            crptXuatNhapKho.ReportSource = report;
        }
    }
}
