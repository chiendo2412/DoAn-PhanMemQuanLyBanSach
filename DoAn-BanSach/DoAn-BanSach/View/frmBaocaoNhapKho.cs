using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_BanSach.Control;

namespace DoAn_BanSach.View
{
    public partial class frmBaocaoNhapKho : UserControl
    {
        public frmBaocaoNhapKho()
        {
            InitializeComponent();
        }
        public static frmBaocaoNhapKho frmBCNK = new frmBaocaoNhapKho();
        private void frmBaocaoNhapKho_Load(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = SachCtr.BaoCaoNhapKho(dtkNgay.Value);
            Custom();
            dgvDanhSach.ClearSelection();
            int TongCong = 0;

            for (int i = 0; i < dgvDanhSach.RowCount; i++)
            {
                TongCong = TongCong + int.Parse(dgvDanhSach.Rows[i].Cells[2].Value.ToString());
            }
            txtTongcong.Text = TongCong.ToString();
        }
        void Custom()
        {
            if (!dgvDanhSach.AutoGenerateColumns)
            {
                return;
            }
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã sách";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaSach";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên sách";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenSach";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Số lượng nhập";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "SoLuong";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 200;
            dgvDanhSach.Columns.Add(dgvCol);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmXuatNhapKho frm = new frmXuatNhapKho(dtkNgay.Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
