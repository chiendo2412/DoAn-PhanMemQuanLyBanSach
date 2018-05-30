﻿using DoAn_BanSach.Control;
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
    public partial class frmXuatDanhSachKhachHang : Form
    {
        public frmXuatDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void frmXuatDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            KhachHang report = new KhachHang();
            report.SetDataSource(KhachHangCtr.DanhSachKhachHang());
            crystalReportViewer1.ReportSource = report;
        }
    }
}
