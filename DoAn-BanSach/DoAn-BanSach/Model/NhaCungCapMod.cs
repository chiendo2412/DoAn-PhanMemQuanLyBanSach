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
    class NhaCungCapMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();


        public static DataSet DanhSachNhaCungCap()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet ds = new DataSet();
            string sql = @"Select * from NhaCungCap";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "NhaCungCap");
            con.Close();
            return ds;
        }
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNCC, TenNCC, DiaChi, Email, SoDT from NhaCungCap";
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
        public bool AddData(NhaCungCapObj nccObj)
        {
            cmd.CommandText = "Insert into NhaCungCap values ('" + nccObj.MaNhaCungCap + "',N'" + nccObj.TenNhaCungCap + "',N'" + nccObj.DiaChi + "',N'" + nccObj.Email + "','" + nccObj.SoDT + "')";
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
        public bool UpdData(NhaCungCapObj nccObj)
        {
            cmd.CommandText = "Update NhaCungCap set TenNCC =  N'" + nccObj.TenNhaCungCap + "', DiaChi = N'" + nccObj.DiaChi + "', Email = N'" + nccObj.Email + "',SoDT = '" + nccObj.SoDT + "' Where MaNCC = '" + nccObj.MaNhaCungCap + "'";
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
            cmd.CommandText = "Delete NhaCungCap Where MaNCC = '" + ma + "'";
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
