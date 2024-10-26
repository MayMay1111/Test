using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace QLCHDT.DAO
{
    public class HoaDonDAO
    {
        SQLConnect connect;
        public HoaDonDAO()
        {
            connect = new SQLConnect();
        }
        public bool addHoaDon(string maKhachHang, string maNhanVien, string maKhuyenMai, DateTime ngayLapHoaDon, int tongTien, string phuongThucThanhToan, int diemDung)
        {
            string query = string.Format("INSERT INTO HoaDon (MaKhachHang, MaNhanVien, MaKhuyenMai, NgayLapHoaDon, TongTien, PhuongThucThanhToan, DiemDaDung) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, N'{5}', {6})",
                maKhachHang, maNhanVien, maKhuyenMai, ngayLapHoaDon.ToString("yyyy-MM-dd HH:mm:ss"), tongTien, phuongThucThanhToan, diemDung);
            return connect.ExecuteNonQuery(query);
        }

        public string layMaPhieuMoiNhat()
        {
            string query = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY CAST(SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon) - 2) AS INT) DESC";
            string kq = (string)connect.GetData(query);
            return kq;
        }

        public bool hoaDonMoi(string maNhanVien, DateTime ngayLap)
        {
            string query = string.Format("INSERT INTO HoaDon (MaNhanVien, NgayLapHoaDon) VALUES('{0}', '{1}')", maNhanVien, ngayLap.ToString("yyyy-MM-dd HH:mm:ss"));
            return connect.ExecuteNonQuery(query);
        }

        public bool deleteHoaDon(string maHoaDon)
        {
            string query = string.Format("DELETE FROM HoaDon WHERE MaHoaDon = '{0}'", maHoaDon);
            return connect.ExecuteNonQuery(query);
        }

        public bool updateHoaDon(string maHoaDon, string maKhachHang, string maKhuyenMai, int tongTien, string phuongThucThanhToan, int diemDung)
        {
            string query = string.Format("UPDATE HoaDon SET MaKhachHang = '{0}', MaKhuyenMai = '{1}', TongTien = {2}, PhuongThucThanhToan = N'{3}', DiemDaDung = {4} WHERE MaHoaDon = '{5}'",
                maKhachHang, maKhuyenMai, tongTien, phuongThucThanhToan, diemDung, maHoaDon);
            return connect.ExecuteNonQuery(query);
        }

        public DataTable getAll()
        {
            string query = "SELECT * FROM HoaDon";
            return connect.getDataTable(query);
        }

        public DataTable searchHoaDon(string key)
        {
            string query = string.Format("SELECT hd.* FROM HoaDon hd JOIN KhachHang kh ON hd.MaKhachHang = kh.MaKhachHang WHERE hd.MaHoaDon LIKE '%{0}%' OR hd.MaNhanVien LIKE '%{0}%' OR hd.MaKhachHang LIKE '%{0}%' OR kh.TenKhachHang LIKE N'%{0}%'", key);
            return connect.getDataTable(query);
        }

        public DataTable laySanPhamTuHoaDon(string maHoaDon)
        {
            string query = string.Format("SELECT ChiTietHoaDon.MaSanPham, TenSanPham, NgayLapHoaDon FROM HoaDon, SanPham, ChiTietHoaDon WHERE SanPham.MaSanPham = ChiTietHoaDon.MaSanPham AND HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon AND HoaDon.MaHoaDon = '{0}'", maHoaDon);
            return connect.getDataTable(query);
        }

        public DateTime layNgayMua(string maHoaDon)
        {
            string query = string.Format("SELECT NgayLapHoaDon FROM HoaDon WHERE MaHoaDon = '{0}'", maHoaDon);
            DataTable kq = connect.getDataTable(query);
            if (kq.Rows.Count > 0)
            {
                return DateTime.Parse(kq.Rows[0]["NgayLapHoaDon"].ToString());
            }
            else
            {
                return DateTime.Now;
            }
        }

    }
}
