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
