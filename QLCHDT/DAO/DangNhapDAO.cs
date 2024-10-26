using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrypt;

namespace QLCHDT.DAO
{
    public class DangNhapDAO
    {
        private SQLConnect connect;

        public DangNhapDAO()
        {
            connect = new SQLConnect();
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @username AND MatKhau = @password";
                SqlCommand cmd = new SqlCommand(query, connect.Connect);
                cmd.Parameters.AddWithValue("@username", taiKhoan);
                cmd.Parameters.AddWithValue("@password", matKhau);
                
                connect.open();
                int result = (int) cmd.ExecuteScalar();
                connect.close();

                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connect.close();
            }
        }

        public string MaHoaMatKhau(string matKhau)
        {
            ScryptEncoder scryptEncoder = new ScryptEncoder();
            return scryptEncoder.Encode(matKhau);
        }

        //public void TaoTaiKhoan(string taiKhoan, string matKhau, string tenNhanVien, string soDienThoai, string email, string chucVu)
        //{
        //    try
        //    {
        //        string hashedPassword = MaHoaMatKhau(matKhau);

        //        string query = "INSERT INTO NhanVien (TaiKhoan, MatKhau, TenNhanVien, SoDienThoai, Email, ChucVu) " +
        //                       "VALUES (@TaiKhoan, @MatKhau, @TenNhanVien, @SoDienThoai, @Email, @ChucVu)";

        //        connect.open();
        //        SqlCommand cmd = new SqlCommand(query, connect.Connect);
        //        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
        //        cmd.Parameters.AddWithValue("@MatKhau", hashedPassword);
        //        cmd.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
        //        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
        //        cmd.Parameters.AddWithValue("@Email", email);
        //        cmd.Parameters.AddWithValue("@ChucVu", chucVu);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        connect.close();
        //    }
        //}

        public string layChucVu(string taiKhoan)
        {
            string query = "SELECT ChucVu FROM NhanVien WHERE TaiKhoan = '" + taiKhoan + "'";
            string result = (string)connect.GetData(query);
            return result;
        }

        public string layMaNhanVien(string taiKhoan)
        {
            string query = "SELECT MaNhanVien FROM NhanVien WHERE TaiKhoan = '" + taiKhoan + "'";
            string result = (string)connect.GetData(query);
            return result;
        }

        public string layTenNhanVienTuMa(string ma)
        {
            string query = "SELECT TenNhanVien FROM NhanVien WHERE MaNhanVien = '" + ma + "'";
            string kq = (string)connect.GetData(query);
            return kq;
        }

    }
}
