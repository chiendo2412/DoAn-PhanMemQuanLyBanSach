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
    public partial class frmBaocaoTonKho : UserControl
    {
        public frmBaocaoTonKho()
        {
            InitializeComponent();
        }
        public static frmBaocaoTonKho frmBCTK = new frmBaocaoTonKho();
        private void frmBaocaoTonKho_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = SachCtr.DanhSachSach();
            Custom();
            dgvDanhSach.ClearSelection();
            for(int i = 0; i<dgvDanhSach.RowCount; i++)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.Yellow;
                if (int.Parse(dgvDanhSach.Rows[i].Cells[2].Value.ToString()) <= 10)
                {
                    dgvDanhSach.Rows[i].DefaultCellStyle = style;
                }
            }
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
            dgvCol.HeaderText = "Số lượng tồn";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCol.DataPropertyName = "SoLuong";
            dgvCol.Width = 200;
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmXuatThongKeTonKho frm = new frmXuatThongKeTonKho();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
