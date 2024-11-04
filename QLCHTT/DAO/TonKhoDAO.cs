using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    internal class TonKhoDAO
    {
        QLCHTTDataContext QLCHTT;
        public TonKhoDAO()
{
    QLCHTT = new QLCHTTDataContext();
}

public DataTable GetTonKhoData()
{
    var result = from sp in QLCHTT.SanPhams
                 join nhap in QLCHTT.ChiTietDonDatHangNhaCungCaps
                     .GroupBy(x => x.MaSanPham)
                     .Select(g => new { MaSanPham = g.Key, SoLuongNhap = g.Sum(x => x.SoLuong) })
                 on sp.MaSanPham equals nhap.MaSanPham into nhapGroup
                 from nhap in nhapGroup.DefaultIfEmpty()
                 join xuat in QLCHTT.ChiTietHoaDons
                     .GroupBy(x => x.MaSanPham)
                     .Select(g => new { MaSanPham = g.Key, SoLuongXuat = g.Sum(x => x.SoLuong) })
                 on sp.MaSanPham equals xuat.MaSanPham into xuatGroup
                 from xuat in xuatGroup.DefaultIfEmpty()
                 select new
                 {
                     sp.MaSanPham,
                     sp.TenSanPham,
                     SoLuongNhap = nhap.SoLuongNhap ?? 0,
                     SoLuongXuat = xuat.SoLuongXuat ?? 0,
                 };

    return ToDataTableUtils.ToDataTable(result);
}

public DataTable timTonKho(string key)
{
    var result = from sp in QLCHTT.SanPhams
                 join nhap in QLCHTT.ChiTietDonDatHangNhaCungCaps
                     .GroupBy(x => x.MaSanPham)
                     .Select(g => new { MaSanPham = g.Key, SoLuongNhap = g.Sum(x => x.SoLuong) })
                 on sp.MaSanPham equals nhap.MaSanPham into nhapGroup
                 from nhap in nhapGroup.DefaultIfEmpty()
                 join xuat in QLCHTT.ChiTietHoaDons
                     .GroupBy(x => x.MaSanPham)
                     .Select(g => new { MaSanPham = g.Key, SoLuongXuat = g.Sum(x => x.SoLuong) })
                 on sp.MaSanPham equals xuat.MaSanPham into xuatGroup
                 from xuat in xuatGroup.DefaultIfEmpty()
                 where sp.TenSanPham.Contains(key)
                 select new
                 {
                     sp.MaSanPham,
                     sp.TenSanPham,
                     SoLuongNhap = nhap.SoLuongNhap ?? 0,
                     SoLuongXuat = xuat.SoLuongXuat ?? 0,
                 };

    return ToDataTableUtils.ToDataTable(result);
}

public DataTable Intonkho()
{
    var result = from sp in QLCHTT.SanPhams
                 join nhap in QLCHTT.ChiTietDonDatHangNhaCungCaps
                     .GroupBy(x => x.MaSanPham)
                     .Select(g => new { MaSanPham = g.Key, SoLuongNhap = g.Sum(x => x.SoLuong) })
                 on sp.MaSanPham equals nhap.MaSanPham into nhapGroup
                 from nhap in nhapGroup.DefaultIfEmpty()
                 join xuat in QLCHTT.ChiTietHoaDons
                     .GroupBy(x => x.MaSanPham)
                     .Select(g => new { MaSanPham = g.Key, SoLuongXuat = g.Sum(x => x.SoLuong) })
                 on sp.MaSanPham equals xuat.MaSanPham into xuatGroup
                 from xuat in xuatGroup.DefaultIfEmpty()
                 select new
                 {
                     sp.MaSanPham,
                     sp.TenSanPham,
                     SoLuongNhap = nhap.SoLuongNhap ?? 0,
                     SoLuongXuat = xuat.SoLuongXuat ?? 0,
                     SoLuongCon = (nhap.SoLuongNhap ?? 0) - (xuat.SoLuongXuat ?? 0)
                 };

    return ToDataTableUtils.ToDataTable(result);
}

    }
}
