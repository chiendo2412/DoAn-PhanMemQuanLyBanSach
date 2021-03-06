﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAn_BanSach.Object;

namespace DoAn_BanSach.Model
{
    class TacGiaMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public static DataSet DanhSachTacGia()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet ds = new DataSet();
            string sql = @"Select * from TacGia";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "TacGia");
            con.Close();
            return ds;
        }
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaTG, TenTG, DiaChi, Email, SoDT from TacGia";
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
        public bool AddData(TacGiaObj tgObj)
        {
            cmd.CommandText = "Insert into TacGia values ('" + tgObj.Ma + "',N'" + tgObj.Ten + "',N'" + tgObj.Diachi + "','" + tgObj.Email + "','" + tgObj.Sodt + "')";
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
        public bool UpdData(TacGiaObj tgObj)
        {
            cmd.CommandText = "Update TacGia set TenTG =  N'" + tgObj.Ten + "', DiaChi = N'" + tgObj.Diachi + "',Email = '" + tgObj.Email + "',SoDT = '" + tgObj.Sodt + "' Where MaTG = '" + tgObj.Ma + "'";
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
            cmd.CommandText = "Delete TacGia Where MaTG = '" + ma + "'";
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
