using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DoAn_BanSach.Object;

namespace DoAn_BanSach.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public static DataSet DanhSachNhanVien()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet ds = new DataSet();
            string sql = @"Select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "NhanVien");
            con.Close();
            return ds;
        }

        public static DataTable DangNhap(string MaNV)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataTable dt = new DataTable();
            string sql = @"Select * From NhanVien Where MaNV='" + MaNV + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static bool ChangePassword(string MaNV, string MatKhau)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("sp_ChangePassword", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.Char);
                cmd.Parameters.Add("@matkhaumoi", SqlDbType.VarChar);
                cmd.Parameters["@manv"].Value = MaNV;
                cmd.Parameters["@matkhaumoi"].Value = MatKhau;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
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
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNV, TenNV, Email,SoDT,DiaChi, NgaySinh, GioiTinh, CMND, MatKhau, Quyen from NhanVien";
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
        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien" +dieukien;
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

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into NhanVien values ('" + nvObj.MaNhanVien + "',N'" + nvObj.TenNhanVien + "',N'" + nvObj.Email + "',N'" + nvObj.SoDT + "','" + nvObj.DiaChi + "',CONVERT(DATE,'" + nvObj.Ngaysinh + "',103),'" + nvObj.Gioitinh + "','" + nvObj.Cmnd + "','" + nvObj.Matkhau + "','" + nvObj.Quyen + "')";
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

        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update NhanVien set TenNV =  N'" + nvObj.TenNhanVien + "', Email='"+ nvObj.Email + "', SoDT = '"+ nvObj.SoDT + "',  DiaChi = N'" + nvObj.DiaChi + "', NgaySinh= CONVERT(DATE,'" + nvObj.Ngaysinh + "',103), GioiTinh = N'" + nvObj.Gioitinh + "', CMND= '"+ nvObj.Cmnd +"' , MatKhau='"+ nvObj.Matkhau +"', Quyen='"+ nvObj.Quyen+"'  Where MaNV = '" + nvObj.MaNhanVien + "'";
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

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete NhanVien Where NhanVien = '" + ma + "'";
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
