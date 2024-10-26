using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class NhaCungCapDAO
    {
        private SQLConnect connect;
        public NhaCungCapDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "SELECT * FROM NHACUNGCAP";
            return connect.getDataTable(query);
        }

        public bool addNhaCungCap(string tenNhaCungCap, string nguoiLienHe, string diaChi, string soDienThoai, string email)
        {
            string query = string.Format("INSERT INTO NhaCungCap (TenNhaCungCap, NguoiLienHe, DiaChi, SoDienThoai, Email) " +
                                          "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')",
                                          tenNhaCungCap, nguoiLienHe, diaChi, soDienThoai, email);
            return connect.ExecuteNonQuery(query);
        }

        public bool updateNhaCungCap(int maNhaCungCap, string tenNhaCungCap, string nguoiLienHe, string diaChi, string soDienThoai, string email)
        {
            string query = string.Format("UPDATE NhaCungCap SET TenNhaCungCap = N'{0}', NguoiLienHe = N'{1}', DiaChi = N'{2}', SoDienThoai = N'{3}', Email = N'{4}' WHERE MaNhaCungCap = {5}",
                                          tenNhaCungCap, nguoiLienHe, diaChi, soDienThoai, email, maNhaCungCap);
            return connect.ExecuteNonQuery(query);
        }

        public bool deleteNhaCungCap(int maNhaCungCap)
        {
            string query = string.Format("DELETE FROM NhaCungCap WHERE MaNhaCungCap = {0}", maNhaCungCap);
            return connect.ExecuteNonQuery(query);
        }

        public DataTable searchNhaCungCap(string key)
        {
            string query = string.Format("SELECT * FROM NhaCungCap WHERE TenNhaCungCap LIKE N'%{0}%' " +
                                          "OR MaNhaCungCap LIKE '%{0}%' OR NguoiLienHe LIKE '%{0}%' " +
                                          "OR SoDienThoai LIKE '%{0}%' OR Email LIKE '%{0}%' " +
                                          "OR DiaChi LIKE '%{0}%'", key);
            return connect.getDataTable(query);
        }

    }
}
