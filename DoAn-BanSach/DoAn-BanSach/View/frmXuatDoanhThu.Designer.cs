namespace DoAn_BanSach.View
{
    partial class frmXuatDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatDoanhThu));
            this.crptXuatDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptXuatDoanhThu
            // 
            this.crptXuatDoanhThu.ActiveViewIndex = -1;
            this.crptXuatDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptXuatDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptXuatDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptXuatDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.crptXuatDoanhThu.Name = "crptXuatDoanhThu";
            this.crptXuatDoanhThu.Size = new System.Drawing.Size(975, 332);
            this.crptXuatDoanhThu.TabIndex = 0;
            // 
            // frmXuatDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 332);
            this.Controls.Add(this.crptXuatDoanhThu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuatDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Doanh Thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatDoanhThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptXuatDoanhThu;
    }
}