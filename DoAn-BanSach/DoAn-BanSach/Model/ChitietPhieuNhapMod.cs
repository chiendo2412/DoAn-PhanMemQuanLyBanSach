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
    class ChitietPhieuNhapMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"SELECT Sach.MaSach,Sach.TenSach, TacGia.TenTG, TheLoai.TenTL, ChiTietPhieuNhap.SoLuong, ChiTietPhieuNhap.GiaNhap, ChiTietPhieuNhap.ThanhTien FROM ChiTietPhieuNhap INNER JOIN Sach ON ChiTietPhieuNhap.MaSach = Sach.MaSach INNER JOIN TacGia ON Sach.MaTG = TacGia.MaTG INNER JOIN TheLoai ON Sach.MaTL = TheLoai.MaTL  and MaPN='" + ma + "'";
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

        public bool AddData(ChitietPhieuNhapObj ctpnObj)
        {
            cmd.CommandText = "insert into ChiTietPhieuNhap(MaPN,MaSach,SoLuong,GiaNhap) values('" + ctpnObj.Ma + "','" + ctpnObj.Masach + "','" + ctpnObj.Soluong + "','"+ ctpnObj.Gianhap + "')";
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
            cmd.CommandText = "Delete ChiTietPhieuNhap Where MaPN = '" + ma + "'";
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
