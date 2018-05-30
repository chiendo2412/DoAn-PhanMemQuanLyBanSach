using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAn_BanSach.Object;

namespace DoAn_BanSach.Model
{
    class HoaDonMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"SELECT        MaHD, NgayBan, TongTien FROM HoaDonBanSach";
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

        public static string GetIDHoaDon()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_GetIDHoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mahd", SqlDbType.Char);
            cmd.Parameters["@mahd"].Direction = ParameterDirection.Output;
            cmd.Parameters["@mahd"].Size = 6;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                string MaSach = cmd.Parameters["@mahd"].Value.ToString();
                return MaSach;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }   
        }

        public bool AddData(HoaDonObj hdObj)
        {
            cmd.CommandText = "insert into HoaDonBanSach (MaHD,MaKH,MaNV) values('" + hdObj .Mahd + "','"+ hdObj.Makhachhang + "','"+ hdObj .Manhanvien+ "')";
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

        public static DataSet XuatHoaDon(string MaHD)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet dtset = new DataSet();
            string sql = @"SELECT HoaDonBanSach.MaHD, HoaDonBanSach.NgayBan, HoaDonBanSach.TongTien, Sach.MaSach, Sach.TenSach, Sach.GiaBan, ChiTietPhieuBan.SoLuong, ChiTietPhieuBan.ThanhTien FROM HoaDonBanSach INNER JOIN  ChiTietPhieuBan ON HoaDonBanSach.MaHD = ChiTietPhieuBan.MaHD INNER JOIN  Sach ON ChiTietPhieuBan.MaSach = Sach.MaSach where HoaDonBanSach.MaHD='" + MaHD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtset, "dt_HoaDonBanSach");
            con.Close();
            return dtset;
        }


        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete HoaDonBanSach Where MaHD = '" + ma + "'";
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
    }
}
