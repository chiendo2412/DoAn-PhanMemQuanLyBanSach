﻿namespace DoAn_BanSach.View
{
    partial class frmXuatPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatPhieuNhap));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crpvXuatPhieuNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(934, 376);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crpvXuatPhieuNhap
            // 
            this.crpvXuatPhieuNhap.ActiveViewIndex = -1;
            this.crpvXuatPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpvXuatPhieuNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpvXuatPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpvXuatPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.crpvXuatPhieuNhap.Name = "crpvXuatPhieuNhap";
            this.crpvXuatPhieuNhap.Size = new System.Drawing.Size(934, 376);
            this.crpvXuatPhieuNhap.TabIndex = 1;
            // 
            // frmXuatPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 376);
            this.Controls.Add(this.crpvXuatPhieuNhap);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuatPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xuất Phiếu Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatPhieuNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvXuatPhieuNhap;
    }
}