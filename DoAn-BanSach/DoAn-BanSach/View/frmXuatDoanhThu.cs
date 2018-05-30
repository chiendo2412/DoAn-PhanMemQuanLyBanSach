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
    public partial class frmXuatDoanhThu : Form
    {
        DateTime ngay = new DateTime();
        public frmXuatDoanhThu()
        {
            InitializeComponent();
        }
        public frmXuatDoanhThu(DateTime Ngay)
        {
            InitializeComponent();
            ngay = Ngay;
        }

        private void frmXuatDoanhThu_Load(object sender, EventArgs e)
        {
            BaoCaoDoanhThu report = new BaoCaoDoanhThu();
            report.SetDataSource(SachCtr.BaoCaoDoanhThus(ngay));
            crptXuatDoanhThu.ReportSource = report;
        }
    }
}
