using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class TraHangDAO
    {
        public string strHoaDon = "select *form HoaDon";
        SQLConnect db = new SQLConnect();
        DataTable dtChiTietSP = new DataTable();
        DataTable dtTraHang = new DataTable();
        public bool timHoaDon(string hoadon)
        {
            string query = string.Format("SELECT COUNT(*) FROM HoaDon WHERE MaHoaDon = '{0}'", hoadon);
            int check = (int)db.GetData(query);
            return check > 0;
        }

        public string layTenKhachHangTrongHoaDon(string hoadon)
        {
            string query = string.Format("SELECT TenKhachHang FROM HoaDon hd, KhachHang kh WHERE kh.MaKhachHang = hd.MaKhachHang AND hd.MaHoaDon = '{0}'", hoadon);
            string tenKH = (string)db.GetData(query);
            return tenKH;
        }

        public string laySDTKhachHangTrongHoaDon(string hoadon)
        {
            string query = string.Format("SELECT SoDienThoai FROM HoaDon hd, KhachHang kh WHERE kh.MaKhachHang = hd.MaKhachHang AND hd.MaHoaDon = '{0}'", hoadon);
            string sdt = (string)db.GetData(query);
            return sdt;
        }

        public DataTable layChiTietSanPham(string hoadon)
        {
            string query = string.Format("SELECT sp.MaSanPham, sp.TenSanPham, ct.SoLuong, ct.DonGia, ct.ThanhTien FROM SanPham sp, ChiTietHoaDon ct WHERE ct.MaSanPham = sp.MaSanPham AND ct.MaHoaDon = '{0}'", hoadon);
            dtChiTietSP = db.getDataTable(query);
            return dtChiTietSP;
        }

        public bool themHDTraHang(string mahoadon, DateTime ngaytra)
        {
            string query = string.Format("INSERT INTO TraHang (MaHoaDon, NgayTra) VALUES ('{0}', '{1}')", mahoadon, ngaytra);
            return db.ExecuteNonQuery(query);
        }

        public DataTable allHDTraHang()
        {
            string query = "SELECT th.MaTraHang, th.MaHoaDon, th.NgayTra, sp.TenSanPham, ct.SoLuong, ct.LyDo FROM TraHang th, ChiTietTraHang ct, SanPham sp WHERE th.MaTraHang = ct.MaTraHang AND ct.MaSanPham = sp.MaSanPham";
            dtTraHang = db.getDataTable(query);
            return dtTraHang;
        }

        public string layMaTraHang(string mahoadon, DateTime time)
        {
            string query = string.Format("SELECT MaTraHang FROM TraHang WHERE MaHoaDon = '{0}' AND NgayTra = '{1}'", mahoadon, time);
            string kq = (string)db.GetData(query);
            return kq;
        }

        public string layMaPhieuMoiNhat()
        {
            string query = "SELECT TOP 1 MaTraHang FROM TraHang ORDER BY CAST(SUBSTRING(MaTraHang, 3, LEN(MaTraHang) - 2) AS INT) DESC";
            string kq = (string)db.GetData(query);
            return kq;
        }

        public bool themChiTietTraHang(string maHD, DateTime time, string maSP, int soLuong, string lydo)
        {
            string matrahang = layMaPhieuMoiNhat();
            string query = string.Format("INSERT INTO ChiTietTraHang VALUES ('{0}', '{1}', '{2}', N'{3}')", matrahang, maSP, soLuong, lydo);
            return db.ExecuteNonQuery(query);
        }

        public bool kiemTraHangTrong30Ngay(string hoadon)
        {
            bool check = false;
            DateTime today = DateTime.Now;
            string query = string.Format("SELECT NgayLapHoaDon FROM HoaDon WHERE MaHoaDon = '{0}'", hoadon);
            DateTime ngaylap = (DateTime)db.GetData(query);
            if ((today - ngaylap).TotalDays <= 30)
            {
                check = true;
            }
            return check;
        }

        public bool capnhatTongTien(decimal tongTien, string mahd, DateTime time)
        {
            string matrahang = layMaTraHang(mahd, time);
            string query = string.Format("UPDATE TraHang SET TongTien = '{0}' WHERE MaTraHang = '{1}'", tongTien, matrahang);
            return db.ExecuteNonQuery(query);
        }

        public DataTable timHDTraHang(string matrahang)
        {
            string query = string.Format("SELECT th.MaTraHang, th.MaHoaDon, th.NgayTra, sp.TenSanPham, ct.SoLuong, ct.LyDo FROM TraHang th, ChiTietTraHang ct, SanPham sp WHERE th.MaTraHang = ct.MaTraHang AND ct.MaSanPham = sp.MaSanPham AND th.MaTraHang LIKE N'%{0}'", matrahang);
            dtTraHang = db.getDataTable(query);
            return dtTraHang;
        }

        public bool suaHDTraHang(string matrahang, string lydo)
        {
            string query = string.Format("UPDATE ChiTietTraHang SET LyDo = N'{0}' WHERE MaTraHang = '{1}'", lydo, matrahang);
            return db.ExecuteNonQuery(query);
        }

        public bool xoaHDTraHang(string matrahang)
        {
            string query = string.Format("DELETE FROM TraHang WHERE MaTraHang = '{0}'", matrahang);
            return db.ExecuteNonQuery(query);
        }

    }
}
