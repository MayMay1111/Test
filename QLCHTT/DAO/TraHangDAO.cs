using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    internal class TraHangDAO
    {
        QLCHTTDataContext QLCHTT = new QLCHTTDataContext();
        DataTable dtChiTietSP = new DataTable();
        DataTable dtTraHang = new DataTable();

        public bool timHoaDon(string hoadon)
        {
            return QLCHTT.HoaDons.Any(hd => hd.MaHoaDon == hoadon);
        }

        public string layTenKhachHangTrongHoaDon(string hoadon)
        {
            var tenKH = (from hd in QLCHTT.HoaDons
                         join kh in QLCHTT.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                         where hd.MaHoaDon == hoadon
                         select kh.TenKhachHang).FirstOrDefault();
            return tenKH ?? string.Empty;
        }

        public string laySDTKhachHangTrongHoaDon(string hoadon)
        {
            var sdt = (from hd in QLCHTT.HoaDons
                       join kh in QLCHTT.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                       where hd.MaHoaDon == hoadon
                       select kh.SoDienThoai).FirstOrDefault();
            return sdt ?? string.Empty;
        }

        public DataTable layChiTietSanPham(string hoadon)
        {
            var result = from sp in QLCHTT.SanPhams
                         join ct in QLCHTT.ChiTietHoaDons on sp.MaSanPham equals ct.MaSanPham
                         where ct.MaHoaDon == hoadon
                         select new
                         {
                             sp.MaSanPham,
                             sp.TenSanPham,
                             ct.SoLuong,
                             ct.DonGia,
                             ct.ThanhTien
                         };

            return ToDataTableUtils.ToDataTable(result);
        }

        public bool themHDTraHang(string mahoadon, DateTime ngaytra)
        {
            QLCHTT.TraHangs.InsertOnSubmit(new TraHang
            {
                MaHoaDon = mahoadon,
                NgayTra = ngaytra
            });
            QLCHTT.SubmitChanges();
            return true;
        }

        public DataTable allHDTraHang()
        {

            return null;
        }

        public string layMaTraHang(string mahoadon, DateTime time)
        {
            return QLCHTT.TraHangs
                .Where(th => th.MaHoaDon == mahoadon && th.NgayTra == time)
                .Select(th => th.MaTraHang)
                .FirstOrDefault() ?? string.Empty;
        }

        public string layMaPhieuMoiNhat()
        {
            return QLCHTT.TraHangs
                .OrderByDescending(th => int.Parse(th.MaTraHang.Substring(2)))
                .Select(th => th.MaTraHang)
                .FirstOrDefault() ?? string.Empty;
        }

        public bool themChiTietTraHang(string maHD, DateTime time, string maSP, int soLuong, string lydo)
        {
            return true;
        }

        public bool kiemTraHangTrong30Ngay(string hoadon)
        {
            DateTime today = DateTime.Now;
            DateTime ngaylap = QLCHTT.HoaDons
                .Where(hd => hd.MaHoaDon == hoadon)
                .Select(hd => hd.NgayLapHoaDon.Value)
                .FirstOrDefault();

            return (today - ngaylap).TotalDays <= 30;
        }

        public bool capnhatTongTien(decimal tongTien, string mahd, DateTime time)
        {
            string matrahang = layMaTraHang(mahd, time);
            var traHang = QLCHTT.TraHangs.FirstOrDefault(th => th.MaTraHang == matrahang);

            if (traHang != null)
            {
                traHang.TongTien = tongTien;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public DataTable timHDTraHang(string matrahang)
        {

            return null;
        }

        public bool suaHDTraHang(string matrahang, string lydo)
        {
            return false;
        }

        public bool xoaHDTraHang(string matrahang)
        {
            return false;
        }
    }
}
