using DoAn_BanSach.Control;
using DoAn_BanSach.Object;
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
    public partial class frmNhaCungCap : UserControl
    {
        NhaCungCapCtr nccCtr = new NhaCungCapCtr();
        private int flagLuu = 0;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        public static frmNhaCungCap frmNCC = new frmNhaCungCap();

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nccCtr.GetData();
            dtgvDS.DataSource = dtDS;
            binhding();
            DisEnl(false);
        }
        private void binhding()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dtgvDS.DataSource, "MaNCC");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", dtgvDS.DataSource, "TenNCC");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtgvDS.DataSource, "DiaChi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dtgvDS.DataSource, "Email");
            txtSoDT.DataBindings.Clear();
            txtSoDT.DataBindings.Add("Text", dtgvDS.DataSource, "SoDT");

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNCC.Enabled = e;
            txtTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSoDT.Enabled = e;
            txtEmail.Enabled = e;
        }
        private void clearData()
        {
            
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSoDT.Text = "";
        }
        private void addData(NhaCungCapObj ncc)
        {
            ncc.MaNhaCungCap = txtMaNCC.Text.Trim();
            ncc.TenNhaCungCap = txtTenNCC.Text.Trim();
            ncc.DiaChi = txtDiaChi.Text.Trim();
            ncc.Email = txtEmail.Text.Trim();
            ncc.SoDT = txtSoDT.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flagLuu = 0;
            clearData();
            DisEnl(true);
            txtMaNCC.Enabled = false;
            txtTenNCC.Focus();
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nccCtr.GetData();
            int count = 0;
            count = dtDS.Rows.Count;
            if (count <= 0)
            {
                txtMaNCC.Text = "NCC01";
            }
            else
            {
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dtDS.Rows[count - 1][0].ToString());
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaNCC.Text = "NCC0" + (chuoi2 + 1).ToString();
                else
                    if (chuoi2 + 1 < 100)
                    txtMaNCC.Text = "NCC" + (chuoi2 + 1).ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
            txtTenNCC.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nccCtr.DelData(txtMaNCC.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhaCungCap_Load(sender, e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaCungCapObj nccObj = new NhaCungCapObj();
            addData(nccObj);
            if (flagLuu == 0)
            {
                if (nccCtr.AddData(nccObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nccCtr.UpdData(nccObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmNhaCungCap_Load(sender, e);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmNhaCungCap_Load(sender, e);
            else
                return;
        }

    }
}