using DoAn_BanSach.Control;
using DoAn_BanSach.Model;
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
    public partial class frmChitietHoaDon : Form
    {
        string manv = frmDangNhappp.mnvlogin;
        string phanquyen = "";
        int i;
        long Tien;
        HoaDonCtr hdCtr = new HoaDonCtr();
        ChitietHoaDonCtr cthdCtr = new ChitietHoaDonCtr();
        
        public frmChitietHoaDon()
        {
            InitializeComponent();
            fillcombobox();
            dtGRchitietHD.ColumnCount = 4;
            dtGRchitietHD.Columns[0].HeaderText = "Mã sách";
            dtGRchitietHD.Columns[0].Name = "MaSach";
            dtGRchitietHD.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[1].HeaderText = "Tên sách";
            dtGRchitietHD.Columns[1].Name = "TenSach";
            dtGRchitietHD.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            
            dtGRchitietHD.Columns[2].HeaderText = "Số lượng";
            dtGRchitietHD.Columns[2].Name = "SoLuong";
            dtGRchitietHD.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtGRchitietHD.Columns[3].HeaderText = "Giá bán";
            dtGRchitietHD.Columns[3].Name = "GiaBan";
            dtGRchitietHD.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           
        }

        public frmChitietHoaDon(string Hoten, string USN, string PQ)
        {
            InitializeComponent();
            txtMaNV.Text = USN;
            manv = USN;
            phanquyen = PQ;
        }

        private void frmChitietHoaDon_Load(object sender, EventArgs e)
        {
            DisEnl(false);
        }
        private void DisEnl(bool e)
        {
            btnLapHoaDonMoi.Enabled = !e;
            btnGhiHoaDon.Enabled = e;
            btnLuu.Enabled = e;
            btnThemSach.Enabled = e;
            txtMaHD.Enabled = e;
            txtMaKH.Enabled = e;
            txtMaNV.Enabled = e;
            txtTenSach.Enabled = e;
            cbbMaSach.Enabled = e;
            txtSoLuong.Enabled = e;
            txtGiaBan.Enabled = e;
            dtimeNgayBan.Enabled = e;
        }
        private void addData(HoaDonObj hd)
        {
            hd.Mahd = txtMaHD.Text.Trim();
            hd.Makhachhang = txtMaKH.SelectedValue.ToString();
            hd.Manhanvien = txtMaNV.Text.Trim();
        }

        private void btnLapHoaDonMoi_Click(object sender, EventArgs e)
        {
            i = 0;
            Tien = 0;
            txtTongtien.Text = "0";
            btnGhiHoaDon.Enabled = true;
            btnLapHoaDonMoi.Enabled = false;
            btnThemSach.Enabled = false;
            txtMaHD.Enabled = false;
            txtMaHD.Text = HoaDonCtr.GetIDHoaDon();
            txtMaKH.Enabled = true;
            txtMaNV.Text = manv;
            loadCombox();
        }

        private void btnGhiHoaDon_Click(object sender, EventArgs e)
        {
            DisEnl(false);
           
            HoaDonObj hdObj = new HoaDonObj();
            addData(hdObj);
            if (hdCtr.AddData(hdObj))
            {
                cbbMaSach.Enabled = true;
                btnThemSach.Enabled = true;
                btnGhiHoaDon.Enabled = false;
                btnLapHoaDonMoi.Enabled = true;
            }

            else
                MessageBox.Show("Ghi không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        dtGRchitietHD.Rows[j].Cells[2].Value = (Int32.Parse(dtGRchitietHD.Rows[j].Cells[2].Value.ToString()) + 1).ToString();
                        break;
                    }
                    else if (j == dtGRchitietHD.Rows.Count - 1)
                    {
                        dtGRchitietHD.Rows.Add();
                        dtGRchitietHD.Rows[i].Cells[0].Value = cbbMaSach.Text;
                        dtGRchitietHD.Rows[i].Cells[1].Value = txtTenSach.Text;
                        dtGRchitietHD.Rows[i].Cells[2].Value = txtSoLuong.Text;
                        dtGRchitietHD.Rows[i].Cells[3].Value = txtGiaBan.Text;
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
                dtGRchitietHD.Rows[i].Cells[2].Value = txtSoLuong.Text;
                dtGRchitietHD.Rows[i].Cells[3].Value = txtGiaBan.Text;
                i++;
            }
            //Tính tổng tiền
            //TongTien()
            btnLuu.Enabled = true;
        }

        void TongTien()
        {
                long TongTien = 0;
                for (int k = 0; k < dtGRchitietHD.Rows.Count; k++)
                {
                    TongTien = TongTien + (Int64.Parse(dtGRchitietHD.Rows[k].Cells[3].Value.ToString()) * Int64.Parse(dtGRchitietHD.Rows[k].Cells[2].Value.ToString()));
                }
                txtTongtien.Text = String.Format("{0:0,0}",TongTien);
                Tien = TongTien;
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
        }

        public void fillcombobox()
        {
            SqlConnection con = getConnect();
            string sql = "Select * from Sach";
            SqlCommand cmd = new SqlCommand(sql,con);
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void loadCombox()
        {
            KhachHangCtr khCtr = new KhachHangCtr();
            txtMaKH.DataSource = khCtr.GetData();
            txtMaKH.ValueMember = "MaKH";
            txtMaKH.DisplayMember = "TenKH";
        }

        private void cbbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenSach, GiaBan From Sach where MaSach='" + cbbMaSach.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtTenSach.Text = dr["TenSach"].ToString();
                txtGiaBan.Text = dr["GiaBan"].ToString();
            }
            con.Close();

        }

        private void dtGRchitietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool a = false;
            ChitietHoaDonObj cthdObj = new ChitietHoaDonObj();
            for (int k = 0; k < dtGRchitietHD.Rows.Count; k++)
            {
                cthdObj.Mahd = txtMaHD.Text;
                cthdObj.Masach = dtGRchitietHD.Rows[k].Cells[0].Value.ToString();
                cthdObj.Soluong = int.Parse(dtGRchitietHD.Rows[k].Cells[2].Value.ToString());
                a=cthdCtr.AddData(cthdObj);
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
        private void txtMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtGRchitietHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dtGRchitietHD.SelectedRows)
                {
                    dtGRchitietHD.Rows.Remove(row);
                }
            }
        }

    }
}
