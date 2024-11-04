using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO;
        public HoaDonBUS()
        {
            hoaDonDAO = new HoaDonDAO();
        }

        public bool addHoaDon(string maKhachHang, string maNhanVien, string maKhuyenMai, DateTime ngayMua, int tongTien, string phuongThucThanhToan, int dungDiemTichLuy)
        {
            return hoaDonDAO.addHoaDon(maKhachHang, maNhanVien, maKhuyenMai, ngayMua, tongTien, phuongThucThanhToan, dungDiemTichLuy);
        }

        public string layMaMoiNhat()
        {
            return hoaDonDAO.layMaPhieuMoiNhat();
        }
        public bool hoaDonMoi(string maNhanVien, DateTime ngayLap)
        {
            return hoaDonDAO.hoaDonMoi(maNhanVien, ngayLap);
        }
        public bool updateHoaDon(string maHoaDon, string maKhachHang, string maKhuyenMai, int tongTien, string phuongThucThanhToan, int dungDiemTichLuy)
        {
            return hoaDonDAO.updateHoaDon(maHoaDon, maKhachHang, maKhuyenMai, tongTien, phuongThucThanhToan, dungDiemTichLuy);
        }
        public DataTable getAll()
        {
            return hoaDonDAO.getAll();
        }
        public DataTable searchHoaDon(string key)
        {
            return hoaDonDAO.searchHoaDon(key);
        }
        public bool deleteHoaDon(string maHoaDon)
        {
            return hoaDonDAO.deleteHoaDon(maHoaDon);
        }
        public DataTable laySanPhamTuHoaDon(string maHoaDon)
        {
            return hoaDonDAO.laySanPhamTuHoaDon(maHoaDon);
        }
        public DateTime layNgayMua(string maHoaDon)
        {
            return hoaDonDAO.layNgayMua(maHoaDon);
        }

    }
}
