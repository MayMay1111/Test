using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    internal class TraHangBUS
    {
        public TraHangDAO trahangDAO;
        public TraHangBUS()
        {
            trahangDAO = new TraHangDAO();
        }
        public bool timHoaDon(string hoadon)
        {
            return trahangDAO.timHoaDon(hoadon);
        }
        public string layTenKhachHangTrongHoaDon(string hoadon)
        {
            return trahangDAO.layTenKhachHangTrongHoaDon(hoadon);
        }
        public string laySDTKhachHangTrongHoaDon(string hoadon)
        {
            return trahangDAO.laySDTKhachHangTrongHoaDon(hoadon) ;
        }
        public DataTable layChiTietSanPham(string hoadon)
        {
            return trahangDAO.layChiTietSanPham(hoadon);
        }
        public bool luuHDTraHang(string mahoadon, DateTime ngaytra)
        {
            return trahangDAO.themHDTraHang(mahoadon, ngaytra);
        }
        public DataTable allHDTraHang()
        {
            return trahangDAO.allHDTraHang();
        }
        public string layMaTraHang(string mahoadon, DateTime time)
        {
            return trahangDAO.layMaTraHang(mahoadon, time);
        }
        public bool themChiTietTraHang(string maHD, DateTime time, string maSP, int soLuong, string lydo)
        {
            return trahangDAO.themChiTietTraHang(maHD, time, maSP, soLuong, lydo);
        }
        public bool kiemTraHangTrong30Ngay(string hoadon)
        {
            return trahangDAO.kiemTraHangTrong30Ngay(hoadon);
        }
        public bool capnhatTongTien(decimal tongTien, string mahd, DateTime time)
        {
            return trahangDAO.capnhatTongTien(tongTien, mahd, time);
        }
        public DataTable timHDTraHang(string matrahang)
        {
            return trahangDAO.timHDTraHang(matrahang);
        }
        public bool suaHDTraHang(string matrahang, string lydo)
        {
            return trahangDAO.suaHDTraHang(matrahang, lydo);
        }
        public bool xoaHDTraHang(string matrahang)
        {
            return trahangDAO.xoaHDTraHang(matrahang);
        }
    }
}
