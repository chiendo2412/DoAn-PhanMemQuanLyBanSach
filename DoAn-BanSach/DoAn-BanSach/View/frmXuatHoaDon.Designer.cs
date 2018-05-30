namespace DoAn_BanSach.View
{
    partial class frmXuatHoaDon
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
            this.crtpvXuatHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtpvXuatHoaDon
            // 
            this.crtpvXuatHoaDon.ActiveViewIndex = -1;
            this.crtpvXuatHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtpvXuatHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtpvXuatHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtpvXuatHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crtpvXuatHoaDon.Name = "crtpvXuatHoaDon";
            this.crtpvXuatHoaDon.Size = new System.Drawing.Size(853, 315);
            this.crtpvXuatHoaDon.TabIndex = 0;
            // 
            // frmXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 315);
            this.Controls.Add(this.crtpvXuatHoaDon);
            this.Name = "frmXuatHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmXuatHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtpvXuatHoaDon;
    }
}