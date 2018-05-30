using System.Windows.Forms;

namespace DoAn_BanSach
{
    partial class frmTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctxtmenuTabHienTai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đóngTrangHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabHienThi = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ctxtmenuTabHienTai.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctxtmenuTabHienTai
            // 
            this.ctxtmenuTabHienTai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTrangHiệnTạiToolStripMenuItem,
            this.đóngToolStripMenuItem});
            this.ctxtmenuTabHienTai.Name = "ctxtmenuTabHienTai";
            this.ctxtmenuTabHienTai.Size = new System.Drawing.Size(188, 48);
            // 
            // đóngTrangHiệnTạiToolStripMenuItem
            // 
            this.đóngTrangHiệnTạiToolStripMenuItem.Name = "đóngTrangHiệnTạiToolStripMenuItem";
            this.đóngTrangHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đóngTrangHiệnTạiToolStripMenuItem.Text = "Đóng trang hiện tại";
            this.đóngTrangHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.đóngTrangHiệnTạiToolStripMenuItem_Click);
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đóngToolStripMenuItem.Text = "Đóng tất cả các trang";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.đóngToolStripMenuItem_Click);
            // 
            // TabHienThi
            // 
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienTai;
            this.TabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHienThi.ImageList = this.imageList1;
            this.TabHienThi.Location = new System.Drawing.Point(0, 27);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(1354, 673);
            this.TabHienThi.TabIndex = 2;
            this.TabHienThi.SelectedIndexChanged += new System.EventHandler(this.TabHienThi_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.jpg");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1144, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(861, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(781, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýNhàXuấtBảnToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.cậpNhậtSáchToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.quảnLýThểLoạiToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem.Image")));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image")));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýNhàXuấtBảnToolStripMenuItem
            // 
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhàXuấtBảnToolStripMenuItem.Image")));
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Name = "quảnLýNhàXuấtBảnToolStripMenuItem";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Text = "Nhà Xuất Bản";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýTácGiảToolStripMenuItem.Image")));
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Tác Giả";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // cậpNhậtSáchToolStripMenuItem
            // 
            this.cậpNhậtSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cậpNhậtSáchToolStripMenuItem.Image")));
            this.cậpNhậtSáchToolStripMenuItem.Name = "cậpNhậtSáchToolStripMenuItem";
            this.cậpNhậtSáchToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.cậpNhậtSáchToolStripMenuItem.Text = "Cập nhật Sách";
            this.cậpNhậtSáchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtSáchToolStripMenuItem_Click);
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhàCungCấpToolStripMenuItem.Image")));
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.quảnLýNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàCungCấpToolStripMenuItem_Click);
            // 
            // quảnLýThểLoạiToolStripMenuItem
            // 
            this.quảnLýThểLoạiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýThểLoạiToolStripMenuItem.Image")));
            this.quảnLýThểLoạiToolStripMenuItem.Name = "quảnLýThểLoạiToolStripMenuItem";
            this.quảnLýThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.quảnLýThểLoạiToolStripMenuItem.Text = "Thể Loại Sách";
            this.quảnLýThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThểLoạiToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánSáchToolStripMenuItem,
            this.phiếuNhậpSáchToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hóaĐơnToolStripMenuItem.Image")));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // hóaĐơnBánSáchToolStripMenuItem
            // 
            this.hóaĐơnBánSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hóaĐơnBánSáchToolStripMenuItem.Image")));
            this.hóaĐơnBánSáchToolStripMenuItem.Name = "hóaĐơnBánSáchToolStripMenuItem";
            this.hóaĐơnBánSáchToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.hóaĐơnBánSáchToolStripMenuItem.Text = "Bán Sách";
            this.hóaĐơnBánSáchToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánSáchToolStripMenuItem_Click);
            // 
            // phiếuNhậpSáchToolStripMenuItem
            // 
            this.phiếuNhậpSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phiếuNhậpSáchToolStripMenuItem.Image")));
            this.phiếuNhậpSáchToolStripMenuItem.Name = "phiếuNhậpSáchToolStripMenuItem";
            this.phiếuNhậpSáchToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.phiếuNhậpSáchToolStripMenuItem.Text = "Nhập Sách";
            this.phiếuNhậpSáchToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpSáchToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.tìmKiếmKháchHàngToolStripMenuItem,
            this.tìmKiếmNhânViênToolStripMenuItem,
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem,
            this.tìmKiếmTácGiảToolStripMenuItem,
            this.tìmKiếmNhàCungCấpToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem.Image")));
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoTênToolStripMenuItem,
            this.theoNhàXuấtBảnToolStripMenuItem,
            this.theoThểLoạiToolStripMenuItem,
            this.theoTácGiảToolStripMenuItem});
            this.sáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sáchToolStripMenuItem.Image")));
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // theoTênToolStripMenuItem
            // 
            this.theoTênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theoTênToolStripMenuItem.Image")));
            this.theoTênToolStripMenuItem.Name = "theoTênToolStripMenuItem";
            this.theoTênToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.theoTênToolStripMenuItem.Text = "Theo tên";
            this.theoTênToolStripMenuItem.Click += new System.EventHandler(this.theoTênToolStripMenuItem_Click);
            // 
            // theoNhàXuấtBảnToolStripMenuItem
            // 
            this.theoNhàXuấtBảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theoNhàXuấtBảnToolStripMenuItem.Image")));
            this.theoNhàXuấtBảnToolStripMenuItem.Name = "theoNhàXuấtBảnToolStripMenuItem";
            this.theoNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.theoNhàXuấtBảnToolStripMenuItem.Text = "Theo tác giả";
            this.theoNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.theoNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // theoThểLoạiToolStripMenuItem
            // 
            this.theoThểLoạiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theoThểLoạiToolStripMenuItem.Image")));
            this.theoThểLoạiToolStripMenuItem.Name = "theoThểLoạiToolStripMenuItem";
            this.theoThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.theoThểLoạiToolStripMenuItem.Text = "Theo thể loại";
            this.theoThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.theoThểLoạiToolStripMenuItem_Click);
            // 
            // theoTácGiảToolStripMenuItem
            // 
            this.theoTácGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theoTácGiảToolStripMenuItem.Image")));
            this.theoTácGiảToolStripMenuItem.Name = "theoTácGiảToolStripMenuItem";
            this.theoTácGiảToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.theoTácGiảToolStripMenuItem.Text = "Theo nhà xuất bản";
            this.theoTácGiảToolStripMenuItem.Click += new System.EventHandler(this.theoTácGiảToolStripMenuItem_Click);
            // 
            // tìmKiếmKháchHàngToolStripMenuItem
            // 
            this.tìmKiếmKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmKháchHàngToolStripMenuItem.Image")));
            this.tìmKiếmKháchHàngToolStripMenuItem.Name = "tìmKiếmKháchHàngToolStripMenuItem";
            this.tìmKiếmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.tìmKiếmKháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.tìmKiếmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmKháchHàngToolStripMenuItem_Click_1);
            // 
            // tìmKiếmNhânViênToolStripMenuItem
            // 
            this.tìmKiếmNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmNhânViênToolStripMenuItem.Image")));
            this.tìmKiếmNhânViênToolStripMenuItem.Name = "tìmKiếmNhânViênToolStripMenuItem";
            this.tìmKiếmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.tìmKiếmNhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.tìmKiếmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmNhânViênToolStripMenuItem_Click);
            // 
            // tìmKiếmNhàXuấtBảnToolStripMenuItem
            // 
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmNhàXuấtBảnToolStripMenuItem.Image")));
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Name = "tìmKiếmNhàXuấtBảnToolStripMenuItem";
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Text = "Nhà Xuất Bản";
            this.tìmKiếmNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // tìmKiếmTácGiảToolStripMenuItem
            // 
            this.tìmKiếmTácGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmTácGiảToolStripMenuItem.Image")));
            this.tìmKiếmTácGiảToolStripMenuItem.Name = "tìmKiếmTácGiảToolStripMenuItem";
            this.tìmKiếmTácGiảToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.tìmKiếmTácGiảToolStripMenuItem.Text = "Tác Giả";
            this.tìmKiếmTácGiảToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTácGiảToolStripMenuItem_Click);
            // 
            // tìmKiếmNhàCungCấpToolStripMenuItem
            // 
            this.tìmKiếmNhàCungCấpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmNhàCungCấpToolStripMenuItem.Image")));
            this.tìmKiếmNhàCungCấpToolStripMenuItem.Name = "tìmKiếmNhàCungCấpToolStripMenuItem";
            this.tìmKiếmNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.tìmKiếmNhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.tìmKiếmNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmNhàCungCấpToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoNhậpKhoToolStripMenuItem,
            this.báoCáoDoanhThuToolStripMenuItem,
            this.thốngKêTồnKhoToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(159, 23);
            this.thốngKêToolStripMenuItem.Text = "Báo cáo - Thống kê";
            // 
            // báoCáoNhậpKhoToolStripMenuItem
            // 
            this.báoCáoNhậpKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("báoCáoNhậpKhoToolStripMenuItem.Image")));
            this.báoCáoNhậpKhoToolStripMenuItem.Name = "báoCáoNhậpKhoToolStripMenuItem";
            this.báoCáoNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.báoCáoNhậpKhoToolStripMenuItem.Text = "Báo cáo nhập kho";
            this.báoCáoNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoNhậpKhoToolStripMenuItem_Click);
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            this.báoCáoDoanhThuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("báoCáoDoanhThuToolStripMenuItem.Image")));
            this.báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            this.báoCáoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            this.báoCáoDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuToolStripMenuItem_Click);
            // 
            // thốngKêTồnKhoToolStripMenuItem
            // 
            this.thốngKêTồnKhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêTồnKhoToolStripMenuItem.Image")));
            this.thốngKêTồnKhoToolStripMenuItem.Name = "thốngKêTồnKhoToolStripMenuItem";
            this.thốngKêTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.thốngKêTồnKhoToolStripMenuItem.Text = "Thống kê tồn kho";
            this.thốngKêTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTồnKhoToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(125, 23);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinToolStripMenuItem.Image")));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Bán Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxtmenuTabHienTai.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtmenuTabHienTai;
        private System.Windows.Forms.ToolStripMenuItem đóngTrangHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private TabControl TabHienThi;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmKháchHàngToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmNhânViênToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmNhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private ToolStripMenuItem quảnLýThểLoạiToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmTácGiảToolStripMenuItem;
        private ImageList imageList1;
        private Label label1;
        private Label lblTime;
        private ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmNhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtSáchToolStripMenuItem;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem theoTênToolStripMenuItem;
        private ToolStripMenuItem theoThểLoạiToolStripMenuItem;
        private ToolStripMenuItem theoTácGiảToolStripMenuItem;
        private ToolStripMenuItem theoNhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem báoCáoNhậpKhoToolStripMenuItem;
        private ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private ToolStripMenuItem thốngKêTồnKhoToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}

