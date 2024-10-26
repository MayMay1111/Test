using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class ChiTietHoaDonDAO
    {
        SQLConnect connect;
        public ChiTietHoaDonDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getChiTietMa(string maHoaDon)
        {
            string query = string.Format("SELECT * FROM ChiTietHoaDon WHERE MaHoaDon ='{0}'", maHoaDon);
            return connect.getDataTable(query);
        }

        public DataTable getAll()
        {
            string query = "SELECT * FROM ChiTietHoaDon";
            return connect.getDataTable(query);
        }

        public bool kiemTraTrungSanPham(string maHoaDon, string maSanPham)
        {
            string query = string.Format("SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHoaDon = '{0}' AND MaSanPham = '{1}'", maHoaDon, maSanPham);
            int kq = (int)connect.GetData(query);
            return kq > 0;
        }

        public bool updateChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            string query = string.Format("UPDATE ChiTietHoaDon SET SoLuong = {0}, DonGia = {1}, ThanhTien = {2}, GhiChu = N'{3}' WHERE MaHoaDon = '{4}' AND MaSanPham = '{5}'",
                soLuong, donGia, thanhTien, ghiChu, maHoaDon, maSanPham);

            return connect.ExecuteNonQuery(query);
        }

        public bool addChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            string query = string.Format("INSERT INTO ChiTietHoaDon VALUES ('{0}', '{1}', {2}, {3}, {4}, N'{5}')",
                maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
            return connect.ExecuteNonQuery(query);
        }

    }
}
