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
    class SachMod 
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaSach, TenSach, MaTL, MaTG, MaNXB, GiaBan, SoLuong from Sach";
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
        public bool AddData(SachObj sachObj)
        {
            cmd.CommandText = "Insert into Sach values ('" + sachObj.Ma + "',N'" + sachObj.Ten + "',N'" + sachObj.Matheloai + "','" + sachObj.Matacgia + "','" + sachObj.Manhaxuatban + "','" + sachObj.Giaban + "','" + sachObj.Soluong + "')";
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
        public bool UpdData(SachObj sachObj)
        {
            cmd.CommandText = "Update Sach set TenSach =  N'" + sachObj.Ten + "', MaTL = '"+ sachObj.Matheloai +"', MaTG = '"+ sachObj.Matacgia +"', MaNXB = '"+ sachObj.Manhaxuatban +"', GiaBan = '"+ sachObj.Giaban +"', SoLuong ='"+ sachObj.Soluong +"' Where MaSach = '" + sachObj.Ma + "'";
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
            cmd.CommandText = "Delete Sach Where MaSach = '" + ma + "'";
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
