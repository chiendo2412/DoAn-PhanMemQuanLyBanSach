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

        public static DataTable DanhSachSach()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataTable dt = new DataTable();
            string sql = @"Select S.MaSach, S.TenSach, S.MaTL, TL.TenTL, S.MaNXB, NXB.TenNXB, S.MaTG, TG.TenTG, S.SoLuong, S.GiaBan  From ((Sach S join TheLoai TL on S.MaTL=TL.MaTL) join TacGia TG on S.MaTG=TG.MaTG) join NhaXuatBan NXB on S.MaNXB=NXB.MaNXB";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

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
        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaSach, TenSach, MaTL, MaTG, MaNXB, GiaBan, SoLuong from Sach"+dieukien;
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

        public static DataTable BaoCaoNhapKho(DateTime Ngay)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataTable dt = new DataTable();
            string sql = @"Select S.MaSach,S.TenSach,CT.SoLuong " +
                          "From (HoaDonNhapSach PN join ChiTietPhieuNhap CT on PN.MaPN=CT.MaPN) join Sach S on CT.MaSach=S.MaSach " +
                          "where PN.NgayNhap= '" + Ngay.Year + "-" + Ngay.Month + "-" + Ngay.Day + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataSet BaoCaoNhapKhoS(DateTime Ngay)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet ds = new DataSet();
            string sql = @"Select S.MaSach,S.TenSach,CT.SoLuong,PN.NgayNhap " +
                          "From (HoaDonNhapSach PN join ChiTietPhieuNhap CT on PN.MaPN=CT.MaPN) join Sach S on CT.MaSach=S.MaSach " +
                          "where PN.NgayNhap= '" + Ngay.Year + "-" + Ngay.Month + "-" + Ngay.Day + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "dt_Nhapkho");
            con.Close();
            return ds;
        }

        public static DataSet ThongKeTonKho()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet ds = new DataSet();
            string sql = @"Select MaSach, TenSach,SoLuong From Sach";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "dt_TonKho");
            con.Close();
            return ds;
        }

        public static DataSet BaoCaoDoanhThus(DateTime Ngay)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataSet ds = new DataSet();
            string sql = @"Select S.MaSach,S.TenSach,CT.SoLuong,S.GiaBan,HD.NgayBan,CT.ThanhTien " +
                          "From (HoaDonBanSach HD join ChiTietPhieuBan CT on HD.MaHD=CT.MaHD) join Sach S on CT.MaSach=S.MaSach " +
                          "Where HD.NgayBan='" + Ngay.Year + "-" + Ngay.Month + "-" + Ngay.Day + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "dt_Doanhthu");
            con.Close();
            return ds;
        }

        public static DataTable BaoCaoDoanhThu(DateTime Ngay)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D617688;Initial Catalog=PhanMemBanSach;Integrated Security=True");
            DataTable dt = new DataTable();
            string sql = @"Select S.MaSach,S.TenSach,CT.SoLuong,S.GiaBan,HD.NgayBan,CT.ThanhTien " +
                          "From (HoaDonBanSach HD join ChiTietPhieuBan CT on HD.MaHD=CT.MaHD) join Sach S on CT.MaSach=S.MaSach " +
                          "Where HD.NgayBan='" + Ngay.Year + "-" + Ngay.Month + "-" + Ngay.Day + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
