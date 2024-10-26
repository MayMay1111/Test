using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.DAO
{
    internal class TonKhoDAO
    {
        SQLConnect connect;
        public TonKhoDAO()
{
    connect = new SQLConnect();
}

public DataTable GetTonKhoData()
{
    string query = @"
        SELECT 
            sp.MaSanPham, 
            sp.TenSanPham, 
            ISNULL(nhap.SoLuongNhap, 0) AS SoLuongNhap, 
            ISNULL(xuat.SoLuongXuat, 0) AS SoLuongXuat, 
            ISNULL(trahang.SoLuongTraHang, 0) AS SoLuongTraHang
        FROM 
            SanPham sp
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongNhap
            FROM 
                ChiTietDonDatHangNhaCungCap
            GROUP BY 
                MaSanPham
        ) nhap ON sp.MaSanPham = nhap.MaSanPham
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongXuat
            FROM 
                ChiTietHoaDon
            GROUP BY 
                MaSanPham
        ) xuat ON sp.MaSanPham = xuat.MaSanPham
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongTraHang
            FROM 
                ChiTietTraHang
            GROUP BY 
                MaSanPham
        ) trahang ON sp.MaSanPham = trahang.MaSanPham;";

    return connect.getDataTable(query);
}

public DataTable timTonKho(string key)
{
    string query = @"
        SELECT 
            sp.MaSanPham, 
            sp.TenSanPham, 
            ISNULL(nhap.SoLuongNhap, 0) AS SoLuongNhap, 
            ISNULL(xuat.SoLuongXuat, 0) AS SoLuongXuat, 
            ISNULL(trahang.SoLuongTraHang, 0) AS SoLuongTraHang
        FROM 
            SanPham sp
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongNhap
            FROM 
                ChiTietDonDatHangNhaCungCap
            GROUP BY 
                MaSanPham
        ) nhap ON sp.MaSanPham = nhap.MaSanPham
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongXuat
            FROM 
                ChiTietHoaDon
            GROUP BY 
                MaSanPham
        ) xuat ON sp.MaSanPham = xuat.MaSanPham
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongTraHang
            FROM 
                ChiTietTraHang
            GROUP BY 
                MaSanPham
        ) trahang ON sp.MaSanPham = trahang.MaSanPham
        WHERE
            sp.TenSanPham LIKE N'%" +key+"%'";

    return connect.getDataTable(query);
}

public DataTable Intonkho()
{
    string query = @"
        SELECT 
            sp.MaSanPham, 
            sp.TenSanPham, 
            ISNULL(nhap.SoLuongNhap, 0) AS SoLuongNhap, 
            ISNULL(xuat.SoLuongXuat, 0) AS SoLuongXuat, 
            ISNULL(trahang.SoLuongTraHang, 0) AS SoLuongTraHang,
            ISNULL(SoLuongNhap - SoLuongXuat + SoLuongTraHang, 0) AS SoLuongCon
        FROM 
            SanPham sp
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongNhap
            FROM 
                ChiTietDonDatHangNhaCungCap
            GROUP BY 
                MaSanPham
        ) nhap ON sp.MaSanPham = nhap.MaSanPham
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongXuat
            FROM 
                ChiTietHoaDon
            GROUP BY 
                MaSanPham
        ) xuat ON sp.MaSanPham = xuat.MaSanPham
        LEFT JOIN (
            SELECT 
                MaSanPham, 
                SUM(SoLuong) AS SoLuongTraHang
            FROM 
                ChiTietTraHang
            GROUP BY 
                MaSanPham
        ) trahang ON sp.MaSanPham = trahang.MaSanPham;";

    return connect.getDataTable(query);
}

    }
}
