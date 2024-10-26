using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class InPhieuGiaoDAO
    {
        SQLConnect connect;
        public InPhieuGiaoDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable inPhieuGiao(string maPhieu)
        {
            string query = "  SELECT gh.MaGiaoHang, gh.MaHoaDon, nv.TenNhanVien, sp.TenSanPham, gh.NgayGiao, gh.DiaChi, gh.TinhTrang, ctgh.SoLuong FROM GiaoHang gh JOIN ChiTietGiaoHang ctgh ON gh.MaGiaoHang = ctgh.MaGiaoHang JOIN SanPham sp ON ctgh.MaSanPham = sp.MaSanPham JOIN NhanVien nv ON gh.NhanVienGiao = nv.MaNhanVien WHERE gh.MaGiaoHang =" + "maPhieu" + ";";
            return connect.getDataTable(query);
        }
    }
}
