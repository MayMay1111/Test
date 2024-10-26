using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class GiaoHangDAO
    {
        SQLConnect connect;
        public GiaoHangDAO()
        {
            connect = new SQLConnect();
        }
        private int maGiaoHang;
        private string maHoaDon;
        private string nhanVienGiao;
        private DateTime ngayGiao;
        private string diaChi;
        private string tinhTrang;

        public DataTable getAll()
        {
            string query = @"
        SELECT 
            p.MaGiaoHang,
            p.MaHoaDon,
            n.TenNhanVien,
            p.NgayGiao,
            p.DiaChi,
            p.TinhTrang,
            s.TenSanPham,
            c.SoLuong
        FROM 
            GiaoHang p
        LEFT JOIN 
            ChiTietGiaoHang c ON p.MaGiaoHang = c.MaGiaoHang
        LEFT JOIN 
            NhanVien n ON p.NhanVienGiao = n.MaNhanVien
        LEFT JOIN 
            SanPham s ON c.MaSanPham = s.MaSanPham;
    ";
            return connect.getDataTable(query);
        }

        public DataTable timGiaoHang(string key)
        {
            string query = @"
        SELECT 
            p.MaGiaoHang,
            p.MaHoaDon,
            n.TenNhanVien,
            p.NgayGiao,
            p.DiaChi,
            p.TinhTrang,
            s.TenSanPham,
            c.SoLuong
        FROM 
            GiaoHang p
        LEFT JOIN 
            ChiTietGiaoHang c ON p.MaGiaoHang = c.MaGiaoHang
        LEFT JOIN 
            NhanVien n ON p.NhanVienGiao = n.MaNhanVien
        LEFT JOIN 
            SanPham s ON c.MaSanPham = s.MaSanPham
        WHERE 
            p.MaGiaoHang LIKE '%" + key + @"%'
            OR p.MaHoaDon LIKE '%" + key + @"%'
            OR n.TenNhanVien LIKE N'%" + key + @"%'
            OR p.NgayGiao LIKE '%" + key + @"%'
            OR p.DiaChi LIKE N'%" + key + @"%'
            OR s.TenSanPham LIKE N'%" + key + @"%'
            OR c.SoLuong LIKE '%" + key + @"%';
    ";
            return connect.getDataTable(query);
        }

        public bool suaGiaoHang(string nhanVienGiao, string ngayGiao, string tinhTrang, string magh)
        {
            string query = "UPDATE GiaoHang SET NhanVienGiao = '" + nhanVienGiao + "', NgayGiao = '" + ngayGiao + "', TinhTrang = N'" + tinhTrang + "' WHERE MaGiaoHang = '" + magh + "'";
            bool result = connect.ExecuteNonQuery(query);
            return result;
        }

        public bool addGiaoHang(string maHoaDon, DateTime ngayGiao, string diaChi)
        {
            string query = "INSERT INTO GiaoHang (MaHoaDon, NgayGiao, DiaChi) VALUES ('" + maHoaDon + "', '" + ngayGiao.ToString("yyyy-MM-dd") + "', N'" + diaChi + "')";
            return connect.ExecuteNonQuery(query);
        }

        public bool addChiTietGiaoHang(string maGiaoHang, string maSanPham, int soLuong)
        {
            string query = "INSERT INTO ChiTietGiaoHang VALUES ('" + maGiaoHang + "', '" + maSanPham + "', " + soLuong + ")";
            return connect.ExecuteNonQuery(query);
        }

        public string layMaPhieuMoiNhat()
        {
            string query = "SELECT TOP 1 MaGiaoHang FROM GiaoHang ORDER BY CAST(SUBSTRING(MaGiaoHang, 3, LEN(MaGiaoHang) - 2) AS INT) DESC";
            string kq = (string)connect.GetData(query);
            return kq;
        }


    }
}
