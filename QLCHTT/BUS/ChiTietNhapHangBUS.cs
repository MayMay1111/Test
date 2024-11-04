using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class ChiTietNhapHangBUS
    {
        ChiTietNhapHangDAO chiTietNhapHangDAO;
        public ChiTietNhapHangBUS()
        {
            chiTietNhapHangDAO = new ChiTietNhapHangDAO();
        }
        public DataTable getAll(string maDonDatHang)
        {
            return chiTietNhapHangDAO.getAll(maDonDatHang);
        }
        public bool addChiTietDonNhapHang(string maDonDatHang, string maSanPham, int soLuong, int donGia, out string errorMessage)
        {
            return chiTietNhapHangDAO.addChiTietDonNhapHang(maDonDatHang, maSanPham, soLuong, donGia, out errorMessage);
        }
        
    }
}
