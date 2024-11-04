using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO;
        public ChiTietHoaDonBUS()
        {
            chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        }
        public DataTable getChiTietMa(string maHD)
        {
            return chiTietHoaDonDAO.getChiTietMa(maHD);
        }
        public DataTable getAll()
        {
            return chiTietHoaDonDAO.getAll();
        }
        public bool addChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            return chiTietHoaDonDAO.addChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
        }
        public bool updateChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            return chiTietHoaDonDAO.updateChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
        }
        public bool kiemTraTrungSanPham(string maHoaDon, string maSanPham)
        {
            return chiTietHoaDonDAO.kiemTraTrungSanPham(maHoaDon, maSanPham);
        }
    }
}
