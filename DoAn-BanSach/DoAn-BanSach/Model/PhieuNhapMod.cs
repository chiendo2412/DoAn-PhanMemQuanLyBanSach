using DoAn_BanSach.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_BanSach.Model
{
    class PhieuNhapMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"SELECT        MaPN, NgayNhap, TongTien FROM HoaDonNhapSach";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public static string GetIDPhieuNhap()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_GetIDPhieuNhap", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mapn", SqlDbType.Char);
            cmd.Parameters["@mapn"].Direction = ParameterDirection.Output;
            cmd.Parameters["@mapn"].Size = 6;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                string MaSach = cmd.Parameters["@mapn"].Value.ToString();
                return MaSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddData(PhieuNhapObj pnObj)
        {
            cmd.CommandText = "insert into HoaDonNhapSach(MaPN,MaNV,MaNCC) values('" + pnObj.Ma + "','" + pnObj.Manhanvien + "','" + pnObj.Manhacungcap + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public static bool XoaPN(string MaPN)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("sp_XoaPN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapn", SqlDbType.Char);
                cmd.Parameters["@mapn"].Value = MaPN;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete HoaDonNhapSach Where MaPN = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public static DataSet XuatPhieuNhapSach(string MaPN)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet dtset = new DataSet();
            string sql = @"SELECT HoaDonNhapSach.MaPN, HoaDonNhapSach.NgayNhap, NhaCungCap.TenNCC, HoaDonNhapSach.TongTien, Sach.MaSach, Sach.TenSach, ChiTietPhieuNhap.SoLuong, ChiTietPhieuNhap.GiaNhap FROM            HoaDonNhapSach INNER JOIN NhaCungCap ON HoaDonNhapSach.MaNCC = NhaCungCap.MaNCC INNER JOIN ChiTietPhieuNhap ON HoaDonNhapSach.MaPN = ChiTietPhieuNhap.MaPN INNER JOIN Sach ON ChiTietPhieuNhap.MaSach = Sach.MaSach where HoaDonNhapSach.MaPN='" + MaPN + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtset, "dt_PhieuNhap");
            con.Close();
            return dtset;
        }
    }
}
