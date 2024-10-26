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
    public class SanPhamDAO
    {
        SQLConnect connect;
        public SanPhamDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "SELECT * FROM SanPham";
            return connect.getDataTable(query);
        }

        public DataTable getSP()
        {
            string query = "SELECT MaSanPham, TenSanPham, GiaBan FROM SanPham";
            return connect.getDataTable(query);
        }
        public int layThoiGianBaoHanh(string maSanPham)
        {
            string query = "SELECT ThoiGianBaoHanh FROM SanPham, BaoHanh WHERE MaSanPham = '" + maSanPham + "' and SanPham.MaBaoHanh = BaoHanh.MaBaoHanh";
            int kq = Convert.ToInt32(connect.GetData(query));
            return kq;
        }

        public string layTenSanPham(string maSanPham)
        {
            string query = "SELECT TenSanPham FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
            string kq = (string)connect.GetData(query);
            return kq;
        }

        public string layMaSanPham(string tenSanPham)
        {
            string query = "SELECT MaSanPham FROM SanPham WHERE TenSanPham = N'" + tenSanPham + "'";
            string kq = (string)connect.GetData(query);
            return kq;
        }

        public int soLuongCon(string maSanPham)
        {
            string query = @"
        SELECT 
            COALESCE(nhap.TongSoLuongNhap, 0) -
            COALESCE(ban.TongSoLuongBan, 0) +
            COALESCE(tra.TongSoLuongTra, 0) AS SoLuongConLai
        FROM 
            SanPham sp
        LEFT JOIN 
            (SELECT ct.MaSanPham, SUM(ct.SoLuong) AS TongSoLuongNhap
             FROM ChiTietDonDatHangNhaCungCap ct
             INNER JOIN DonDatHangNhaCungCap dh
             ON ct.MaDonDatHang = dh.MaDonDatHang
             WHERE dh.TrangThai = N'Đã nhập hàng vào kho'
             GROUP BY ct.MaSanPham) nhap
        ON sp.MaSanPham = nhap.MaSanPham
        LEFT JOIN 
            (SELECT MaSanPham, SUM(SoLuong) AS TongSoLuongBan
             FROM ChiTietHoaDon
             GROUP BY MaSanPham) ban
        ON sp.MaSanPham = ban.MaSanPham
        LEFT JOIN 
            (SELECT MaSanPham, SUM(SoLuong) AS TongSoLuongTra
             FROM ChiTietTraHang
             GROUP BY MaSanPham) tra
        ON sp.MaSanPham = tra.MaSanPham
        WHERE sp.MaSanPham = '" + maSanPham + "'";

            int result = (int)connect.GetData(query);
            return result;
        }

        public DataTable searchSanPham(string key)
        {
            string query = "SELECT MaSanPham, TenSanPham, GiaBan FROM SanPham WHERE TenSanPham LIKE N'%" + key + "%' OR MaSanPham LIKE '%" + key + "%' OR MaVach LIKE '%" + key + "%'";
            return connect.getDataTable(query);
        }

        public bool addSanPham(string tenSanPham, string maVach, string baoHanh, int danhMuc, int nhaCungCap, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            string query = "INSERT INTO SanPham (TenSanPham, MaVach, MaBaoHanh, MaDanhMuc, MaNhaCungCap, GiaBan, NgaySanXUat, XuatXu, MoTa) VALUES (N'" + tenSanPham + "', '" + maVach + "','" + baoHanh + "'," + danhMuc + "," + nhaCungCap + "," + giaBan + ",'" + ngaySanXuat.ToString("yyyy-MM-dd") + "',N'" + xuatXu + "',N'" + moTa + "')";
            return connect.ExecuteNonQuery(query);
        }

        public bool updateSanPham(string maSanPham, string tenSanPham, string maVach, string baoHanh, int danhMuc, int nhaCungCap, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            string query = "UPDATE SanPham SET TenSanPham = N'" + tenSanPham + "', MaVach = '" + maVach + "', MaBaoHanh = '" + baoHanh + "', MaDanhMuc = " + danhMuc + ", MaNhaCungCap = " + nhaCungCap + ", GiaBan = " + giaBan + ", NgaySanXuat = '" + ngaySanXuat.ToString("yyyy-MM-dd") + "', XuatXu = N'" + xuatXu + "', MoTa = N'" + moTa + "' WHERE MaSanPham = '" + maSanPham + "'";
            return connect.ExecuteNonQuery(query);
        }

        public bool deleteSanPham(string maSanPham)
        {
            string query = "DELETE FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
            return connect.ExecuteNonQuery(query);
        }

        public bool checkMaVachTrung(string maVach)
        {
            string query = "SELECT COUNT(*) FROM SanPham WHERE MaVach = '" + maVach + "'";
            int kq = Convert.ToInt32(connect.GetData(query));
            return kq > 0;
        }

        public bool checkMaVachTrungSua(string maVach, string maSanPham)
        {
            string query = "SELECT COUNT(*) FROM SanPham WHERE MaVach = '" + maVach + "' AND MaSanPham ='" + maSanPham + "'";
            int kq = Convert.ToInt32(connect.GetData(query));
            return kq > 1;
        }

        public string layMaVach(string maSanPham)
        {
            string query = "SELECT MaVach FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
            string kq = Convert.ToString(connect.GetData(query));
            return kq;
        }

        public int layBaoHanh(string maSanPham)
        {
            string query = "SELECT ThoiGianBaoHanh FROM SanPham, BaoHanh WHERE SanPham.MaBaoHanh = BaoHanh.MaBaoHanh and MaSanPham = '" + maSanPham + "'";
            int kq = Convert.ToInt32(connect.GetData(query));
            return kq;
        }

        public int layGiaBan(string maSanPham)
        {
            string query = "SELECT GiaBan FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
            int kq = Convert.ToInt32(connect.GetData(query));
            return kq;
        }


    }
}
