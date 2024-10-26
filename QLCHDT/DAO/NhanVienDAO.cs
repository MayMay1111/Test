using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class NhanVienDAO
    {
        SQLConnect db = new SQLConnect();
        SqlConnection connection = new SqlConnection(SQLConnect.connectString);
        public static string strNhanVien = "select * from NhanVien";
        DataTable dtNhanVien = new DataTable();

        public DataTable getDataTable()
        {
            dtNhanVien = db.getDataTable(strNhanVien);
            return dtNhanVien;
        }
        public bool addNhanVien(string ten, string gioitinh, string ngaySinh, string sdt, string email, string chucVu, string mucLuong, string taiKhoan, string matKhau, byte[] hinhAnh)
        {
            string query = "INSERT INTO NhanVien (TenNhanVien, GioiTinh, NgaySinh, SoDienThoai, Email, ChucVu, MucLuong, TaiKhoan, MatKhau";
            if (hinhAnh != null)
            {
                query += ", HinhAnh";
            }
            query += ") VALUES (@ten, @gioitinh, @ngaySinh, @sdt, @email, @chucVu, @mucLuong, @taiKhoan, @matKhau";

            if (hinhAnh != null)
            {
                query += ", @hinhAnh";
            }

            query += ")";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ten", ten);
                command.Parameters.AddWithValue("@gioitinh", gioitinh);
                command.Parameters.AddWithValue("@ngaySinh", DateTime.Parse(ngaySinh));
                command.Parameters.AddWithValue("@sdt", sdt);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@chucVu", chucVu);
                command.Parameters.AddWithValue("@mucLuong", decimal.Parse(mucLuong));
                command.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                command.Parameters.AddWithValue("@matKhau", matKhau);

                if (hinhAnh != null)
                {
                    command.Parameters.AddWithValue("@hinhAnh", hinhAnh);
                }

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
        }

        public bool updateNhanVien(string ma, string ten, string gioitinh, string ngaySinh, string sdt, string email, string chucVu, string mucLuong, string taihkhoan, string matKhau, byte[] hinhAnh)
        {
            string query = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai, Email = @Email, ChucVu = @ChucVu, MucLuong = @MucLuong, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau";

            if (hinhAnh != null)
            {
                query += ", HinhAnh = @HinhAnh";
            }

            query += " WHERE MaNhanVien = @MaNhanVien";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                cmd.Parameters.AddWithValue("@TenNhanVien", ten);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                cmd.Parameters.AddWithValue("@MucLuong", Convert.ToDecimal(mucLuong));
                cmd.Parameters.AddWithValue("@TaiKhoan", taihkhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                if (hinhAnh != null)
                {
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                }

                return db.ExecuteNonQuery(cmd);
            }
        }
        public DataTable searchDataTable(string str)
        {
            string sql = "select * from NhanVien where TenNhanVien like N'%" + str + "%' OR SoDienThoai like N'%" + str + "%'";
            dtNhanVien = db.getDataTable(sql);
            return dtNhanVien;
        }
        public DataTable locNhanVien(string str)
        {
            string sql = "select *from NhanVien where ChucVu = N'" + str + "'";
            dtNhanVien = db.getDataTable(sql);
            return dtNhanVien;
        }
        public bool trungTaiKhoan(string taiKhoan)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @TaiKhoan";
            SqlCommand cmd = new SqlCommand(sql, db.Connect);
            cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
            db.open();
            int kq = (int) cmd.ExecuteScalar();
            db.close();
            return kq > 0;
        }
        public bool trungSoDienThoai(string sdt)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE SoDienThoai = @SDT";
            SqlCommand cmd = new SqlCommand(sql, db.Connect);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            db.open();
            int kq = (int) cmd.ExecuteScalar();
            db.close();
            return kq > 0;
        }
        
        public DataTable lay1NhanVien(string ma)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNhanVien = " + ma + ";";

            dtNhanVien = db.getDataTable(query);
            return dtNhanVien;
        }

        public bool update1NhanVien(string ma, string ten, string gioitinh, string ngaySinh, string sdt, string email, string chucVu, string mucLuong, byte[] hinhAnh)
        {
            string query = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai, Email = @Email, ChucVu = @ChucVu, MucLuong = @MucLuong";

            if (hinhAnh != null)
            {
                query += ", HinhAnh = @HinhAnh";
            }

            query += " WHERE MaNhanVien = @MaNhanVien";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                cmd.Parameters.AddWithValue("@TenNhanVien", ten);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                cmd.Parameters.AddWithValue("@MucLuong", Convert.ToDecimal(mucLuong));

                if (hinhAnh != null)
                {
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                }

                return db.ExecuteNonQuery(cmd);
            }
        }

        public bool doiMatKhau(string taikhoan, string matkhau)
        {
            string query = "UPDATE NhanVien SET MatKhau = @MatKhau WHERE TaiKhoan = @TaiKhoan";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);

                return db.ExecuteNonQuery(cmd);
            }
        }

    }
}
