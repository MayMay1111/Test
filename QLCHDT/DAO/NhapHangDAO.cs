using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class NhapHangDAO
    {
        SQLConnect connect;
        public NhapHangDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "sELECT * FROM DonDatHangNhaCungCap";
            return connect.getDataTable(query);
        }
        public bool addDonNhapHang(string maNhaCungCap, DateTime ngayDatHang)
        {
            string query = string.Format("INSERT INTO DonDatHangNhaCungCap (MaNhaCungCap, NgayDatHang) " +
                                           "VALUES ('{0}', '{1}')", maNhaCungCap, ngayDatHang.ToString("yyyy-MM-dd"));
            return connect.ExecuteNonQuery(query);
        }

        public string layDonMoi()
        {
            string query = "SELECT TOP 1 MaDonDatHang FROM DonDatHangNhaCungCap ORDER BY CAST(SUBSTRING(MaDonDatHang, 3, LEN(MaDonDatHang) - 2) AS INT) DESC";
            string result = (string)connect.GetData(query);
            return result;
        }

        public DataTable searchDonNhapHang(string key)
        {
            string query = string.Format(@"
        SELECT DISTINCT ddh.MaDonDatHang, ddh.MaNhaCungCap, ddh.NgayDatHang, ddh.TongTien, ddh.TrangThai
        FROM DonDatHangNhaCungCap ddh
        LEFT JOIN ChiTietDonDatHangNhaCungCap ctdh ON ddh.MaDonDatHang = ctdh.MaDonDatHang
        LEFT JOIN SanPham sp ON ctdh.MaSanPham = sp.MaSanPham
        WHERE ddh.MaDonDatHang LIKE '%{0}%'
        OR ddh.MaNhaCungCap LIKE '%{0}%'
        OR sp.TenSanPham LIKE N'%{0}%'
        OR ddh.TrangThai LIKE N'%{0}%'", key);
            return connect.getDataTable(query);
        }

        public bool deleteDonNhapHang(string maDonDatHang)
        {
            string query = string.Format("DELETE FROM DonDatHangNhaCungCap WHERE MaDonDatHang = '{0}'", maDonDatHang);
            return connect.ExecuteNonQuery(query);
        }

        public bool updateDonNhapHang(string maDonDatHang, string trangThai)
        {
            string query = string.Format("UPDATE DonDatHangNhaCungCap SET TrangThai = N'{0}' WHERE MaDonDatHang = '{1}'", trangThai, maDonDatHang);
            return connect.ExecuteNonQuery(query);
        }

    }
}
