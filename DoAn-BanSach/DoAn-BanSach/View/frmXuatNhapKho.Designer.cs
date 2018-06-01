namespace DoAn_BanSach.View
{
    partial class frmXuatNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatNhapKho));
            this.crptXuatNhapKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptXuatNhapKho
            // 
            this.crptXuatNhapKho.ActiveViewIndex = -1;
            this.crptXuatNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptXuatNhapKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptXuatNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptXuatNhapKho.Location = new System.Drawing.Point(0, 0);
            this.crptXuatNhapKho.Name = "crptXuatNhapKho";
            this.crptXuatNhapKho.Size = new System.Drawing.Size(938, 341);
            this.crptXuatNhapKho.TabIndex = 0;
            // 
            // frmXuatNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 341);
            this.Controls.Add(this.crptXuatNhapKho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuatNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Nhập Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatNhapKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptXuatNhapKho;
    }
}