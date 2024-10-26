using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class InHoaDonDAO
    {
        SQLConnect connect;
        public InHoaDonDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable inHoaDon(string maHD)
        {
            string query = string.Format(@"
       SELECT
    KH.TenKhachHang,
    KH.SoDienThoai,
    NV.TenNhanVien,
    SP.TenSanPham,
    CTHD.SoLuong,
    CTHD.DonGia,
    CTHD.ThanhTien,
    SUM(CTHD.ThanhTien) OVER(PARTITION BY HD.MaHoaDon) AS TongTienGoc,
    HD.TongTien,
    KM.TenChuongTrinh,
    KM.GiaTriKhuyenMai,
    KM.MoTa,
   CAST(
    CASE
        WHEN KM.MoTa = N'Giảm phần trăm' THEN SUM(CTHD.ThanhTien) OVER(PARTITION BY HD.MaHoaDon) * (GiaTriKhuyenMai)
        WHEN KM.MoTa = N'Giảm trực tiếp' THEN GiaTriKhuyenMai
        ELSE 0
    END AS float
) AS GiaTriKhuyenMaiTinh,
    SUM(CTHD.ThanhTien) OVER(PARTITION BY HD.MaHoaDon) - 
	CAST(
    CASE 
        WHEN KM.MoTa = N'Giảm phần trăm' THEN SUM(CTHD.ThanhTien) OVER(PARTITION BY HD.MaHoaDon) * (KM.GiaTriKhuyenMai)
        WHEN KM.MoTa = N'Giảm trực tiếp' THEN KM.GiaTriKhuyenMai
        ELSE 0
    END AS float )
	AS TongTienSauKhuyenMai
FROM
    HoaDon HD
    JOIN ChiTietHoaDon CTHD ON HD.MaHoaDon = CTHD.MaHoaDon
    JOIN KhachHang KH ON HD.MaKhachHang = KH.MaKhachHang
    JOIN NhanVien NV ON HD.MaNhanVien = NV.MaNhanVien
    JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSanPham
    LEFT JOIN KhuyenMai KM ON HD.MaKhuyenMai = KM.MaKhuyenMai
WHERE
    HD.MaHoaDon = '{0}'", maHD);

            return connect.getDataTable(query);
        }



    }
}
