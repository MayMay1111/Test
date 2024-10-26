using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class YeuCauBaoHanhDAO
    {
        SQLConnect connect;
        public YeuCauBaoHanhDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "SELECT * FROM YeuCauBaoHanh";
            return connect.getDataTable(query);
        }

        public bool addYeuCauBaoHanh(string maHoaDon, string maSanPham, DateTime ngayYeuCau, string lyDo, string trangThai)
        {
            string query = string.Format("INSERT INTO YeuCauBaoHanh (MaHoaDon, MaSanPham, NgayYeuCau, LyDo, TrangThai) VALUES ('{0}', '{1}', '{2}', N'{3}', N'{4}')",
                                          maHoaDon, maSanPham, ngayYeuCau.ToString("yyyy-MM-dd"), lyDo, trangThai);
            return connect.ExecuteNonQuery(query);
        }

        public bool deleteYeuCauBaoHanh(string maYeuCau)
        {
            string query = string.Format("DELETE FROM YeuCauBaoHanh WHERE MaYeuCauBaoHanh = '{0}'", maYeuCau);
            return connect.ExecuteNonQuery(query);
        }

        public bool updateYeuCauBaoHanh(string maYeuCau, string trangThai)
        {
            string query = string.Format("UPDATE YeuCauBaoHanh SET TrangThai = N'{0}' WHERE MaYeuCauBaoHanh = '{1}'", trangThai, maYeuCau);
            return connect.ExecuteNonQuery(query);
        }

        public DataTable searchYeuCauBaoHanh(string key)
        {
            string query = string.Format("SELECT * FROM YeuCauBaoHanh WHERE MaHoaDon LIKE '%{0}%' OR MaSanPham LIKE '%{0}%' OR TrangThai LIKE N'%{0}%'", key);
            return connect.getDataTable(query);
        }

        public DataTable inYeuCauBaoHanh(string ma)
        {
            string query = string.Format(@"
        SELECT 
            ycbh.MaYeuCauBaoHanh,
            ycbh.MaHoaDon,
            sp.TenSanPham,
            ycbh.NgayYeuCau,
            ycbh.LyDo,
            kh.TenKhachHang,
            kh.SoDienThoai
        FROM 
            YeuCauBaoHanh ycbh
        INNER JOIN 
            HoaDon hd ON ycbh.MaHoaDon = hd.MaHoaDon
        INNER JOIN 
            ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon AND ycbh.MaSanPham = cthd.MaSanPham
        INNER JOIN 
            SanPham sp ON ycbh.MaSanPham = sp.MaSanPham
        INNER JOIN 
            KhachHang kh ON hd.MaKhachHang = kh.MaKhachHang
        WHERE 
            ycbh.MaYeuCauBaoHanh = '{0}'", ma);
            return connect.getDataTable(query);
        }

    }
}
