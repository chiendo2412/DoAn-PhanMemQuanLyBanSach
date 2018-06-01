using DoAn_BanSach.Control;
using DoAn_BanSach.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_BanSach.View
{
    public partial class frmChitietPhieuNhap : Form
    {
        string manv = frmDangNhappp.mnvlogin;
        string phanquyen = "";
        int i;
        long Tien;
        PhieuNhapCtr pnCtr = new PhieuNhapCtr();
        ChitietPhieuNhapCtr ctpnCtr = new ChitietPhieuNhapCtr();
        public frmChitietPhieuNhap()
        {
            InitializeComponent();
            fillcombobox();
            dtGRchitietHD.ColumnCount = 6;
            dtGRchitietHD.Columns[0].HeaderText = "Mã sách";
            dtGRchitietHD.Columns[0].Name = "MaSach";
            dtGRchitietHD.Columns[0].AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[1].HeaderText = "Tên sách";
            dtGRchitietHD.Columns[1].Name = "TenSach";
            dtGRchitietHD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[2].HeaderText = "Thể loại";
            dtGRchitietHD.Columns[2].Name = "TheLoai";
            dtGRchitietHD.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[3].HeaderText = "Tác giả";
            dtGRchitietHD.Columns[3].Name = "TacGia";
            dtGRchitietHD.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[4].HeaderText = "Số lượng";
            dtGRchitietHD.Columns[4].Name = "SoLuong";
            dtGRchitietHD.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[5].HeaderText = "Giá nhập";
            dtGRchitietHD.Columns[5].Name = "GiaNhap";
            dtGRchitietHD.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            
        }
        public frmChitietPhieuNhap(string Hoten, string USN, string PQ)
        {
            InitializeComponent();
            txtMaNV.Text = USN;
            manv = USN;
            phanquyen = PQ;
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection("Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
        }

        private void DisEnl(bool e)
        {
            btnLapPhieuMoi.Enabled = !e;
            btnGhiPhieu.Enabled = e;
            //btnIn.Enabled = e;
            btnThemSach.Enabled = e;
            txtMaPN.Enabled = e;
            cbbNhaCC.Enabled = e;
            txtMaNV.Enabled = e;
            cbbMaSach.Enabled = e;
            txtSoLuong.Enabled = e;
            txtGiaNhap.Enabled = e;
            dtimeNgayNhap.Enabled = e;
            txtTacgia.Enabled = e;
            txtTheloai.Enabled = e;
            txtTongtien.Enabled = e;
            txtTenSach.Enabled = e;
        }



        private void frmChitietPhieuNhap_Load(object sender, EventArgs e)
        {
            DisEnl(false);

        }
        private void btnLapPhieuMoi_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = PhieuNhapCtr.GetIDPhieuNhap();
            txtMaNV.Focus();
            cbbNhaCC.Enabled = true;
            txtMaNV.Text = manv;
            btnGhiPhieu.Enabled = true;
            btnLapPhieuMoi.Enabled = false;
            loadCombox();
        }
        public void loadCombox()
        {
            NhaCungCapCtr nccCtr = new NhaCungCapCtr();   
            cbbNhaCC.DataSource = nccCtr.GetData();
            cbbNhaCC.ValueMember = "MaNCC";
            cbbNhaCC.DisplayMember = "TenNCC";

        }

        private void addData(PhieuNhapObj pn)
        {
            pn.Ma = txtMaPN.Text.Trim();
            pn.Manhanvien = txtMaNV.Text.Trim();
            pn.Manhacungcap = cbbNhaCC.SelectedValue.ToString();
        }
        private void btnGhiPhieu_Click(object sender, EventArgs e)
        {
            //btnIn.Enabled = true;
            txtSoLuong.Enabled = false;
            txtGiaNhap.Enabled = true;
            cbbMaSach.Enabled = true;
            btnThemSach.Enabled = true;
            PhieuNhapObj pnObj = new PhieuNhapObj();
            addData(pnObj);
            if (pnCtr.AddData(pnObj))
            {
                btnGhiPhieu.Enabled = false;
                btnLapPhieuMoi.Enabled = true;
            }


            else
                MessageBox.Show("Ghi không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void fillcombobox()
        {
            SqlConnection con = getConnect();
            string sql = "Select * from Sach";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string masach = myreader.GetString(0);
                    cbbMaSach.Items.Add(masach);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Sach.MaSach, Sach.TenSach, TacGia.TenTG, TheLoai.TenTL FROM Sach INNER JOIN TacGia ON Sach.MaTG = TacGia.MaTG INNER JOIN TheLoai ON Sach.MaTL = TheLoai.MaTL where MaSach='" + cbbMaSach.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtTenSach.Text = dr["TenSach"].ToString();
                txtTheloai.Text = dr["TenTL"].ToString();
                txtTacgia.Text = dr["TenTG"].ToString();
            }
            con.Close();
        }

        private void addData1(ChitietPhieuNhapObj ctpn)
        {
            ctpn.Ma = txtMaPN.Text.Trim();
            ctpn.Masach = cbbMaSach.Text.Trim();
            ctpn.Soluong = Convert.ToInt32(txtSoLuong.Text.Trim());
            ctpn.Gianhap = Convert.ToInt32(txtGiaNhap.Text.Trim());
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            int j = 0;
            if (dtGRchitietHD.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtGRchitietHD.Rows)
                {
                    if (cbbMaSach.Text == dtGRchitietHD.Rows[j].Cells[0].Value.ToString())
                    {
                        dtGRchitietHD.Rows[j].Cells[4].Value = (Int32.Parse(dtGRchitietHD.Rows[j].Cells[4].Value.ToString()) + Int32.Parse(txtSoLuong.Text)).ToString();
                        break;
                    }
                    else if (j == dtGRchitietHD.Rows.Count - 1)
                    {
                        dtGRchitietHD.Rows.Add();
                        dtGRchitietHD.Rows[i].Cells[0].Value = cbbMaSach.Text;
                        dtGRchitietHD.Rows[i].Cells[1].Value = txtTenSach.Text;
                        dtGRchitietHD.Rows[i].Cells[2].Value = txtTheloai.Text;
                        dtGRchitietHD.Rows[i].Cells[3].Value = txtTacgia.Text;
                        dtGRchitietHD.Rows[i].Cells[4].Value = txtSoLuong.Text;
                        dtGRchitietHD.Rows[i].Cells[5].Value = txtGiaNhap.Text;
                        i++;
                        break;
                    }
                    j++;
                }
            }
            else
            {
                dtGRchitietHD.Rows.Add();
                dtGRchitietHD.Rows[i].Cells[0].Value = cbbMaSach.Text;
                dtGRchitietHD.Rows[i].Cells[1].Value = txtTenSach.Text;
                dtGRchitietHD.Rows[i].Cells[2].Value = txtTheloai.Text;
                dtGRchitietHD.Rows[i].Cells[3].Value = txtTacgia.Text;
                dtGRchitietHD.Rows[i].Cells[4].Value = txtSoLuong.Text;
                dtGRchitietHD.Rows[i].Cells[5].Value = txtGiaNhap.Text;
                i++;
            }
            //Tính tổng tiền
            TongTien();
            

        }
        void TongTien()
        {
            long TongTien = 0;
            for (int k = 0; k < dtGRchitietHD.Rows.Count; k++)
            {
                TongTien = TongTien + (Int64.Parse(dtGRchitietHD.Rows[k].Cells[5].Value.ToString()) * Int64.Parse(dtGRchitietHD.Rows[k].Cells[4].Value.ToString()));
            }
            txtTongtien.Text = String.Format("{0:0,0}", TongTien);
            Tien = TongTien;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool a = false;
            ChitietPhieuNhapObj ctpnObj = new ChitietPhieuNhapObj();
            for (int k = 0; k < dtGRchitietHD.Rows.Count; k++)
            {
                ctpnObj.Ma = txtMaPN.Text;
                ctpnObj.Masach = dtGRchitietHD.Rows[k].Cells[0].Value.ToString();
                ctpnObj.Soluong = int.Parse(dtGRchitietHD.Rows[k].Cells[4].Value.ToString());
                ctpnObj.Gianhap = int.Parse(dtGRchitietHD.Rows[k].Cells[5].Value.ToString());
                a = ctpnCtr.AddData(ctpnObj);
            }
            if (a == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGRchitietHD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Delete)
            {
                foreach(DataGridViewRow row in dtGRchitietHD.SelectedRows)
                {
                    dtGRchitietHD.Rows.Remove(row);
                }
            }
            TongTien();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtimeNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGRchitietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
