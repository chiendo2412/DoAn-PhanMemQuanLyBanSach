using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_BanSach.View
{
    public partial class frmHDBanSach : UserControl
    {
        public frmHDBanSach()
        {
            InitializeComponent();
        }
        public static frmHDBanSach frmHDBS = new frmHDBanSach();
        private void frmHDBanSach_Load(object sender, EventArgs e)
        {

        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            frmHD frmhd = new frmHD();
            frmhd.ShowDialog();
        }
    }
}
