using QLCHDT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.BUS
{
    internal class GiaoHangBUS
    {
        GiaoHangDAO giaoHangDAO;
        public GiaoHangBUS()
        {
            giaoHangDAO = new GiaoHangDAO();
        }
        public DataTable getAll()
        {
            return giaoHangDAO.getAll();
        }
        public DataTable timGiaoHang(string key)
        {
            return giaoHangDAO.timGiaoHang(key);
        }
        public bool suaGiaoHang(string nhanVienGiao, string ngayGiao, string tinhTrang, string magh)
        {
            return giaoHangDAO.suaGiaoHang(nhanVienGiao, ngayGiao, tinhTrang, magh);
        }
        public bool addGiaoHang(string maHoaDon, DateTime ngayGiao, string diaChi)
        {
            return giaoHangDAO.addGiaoHang(maHoaDon, ngayGiao, diaChi);
        }
        public bool addChiTietGiaoHang(string maGiaoHang, string maSanPham, int soLuong)
        {
            return giaoHangDAO.addChiTietGiaoHang(maGiaoHang, maSanPham, soLuong);
        }
        public string layMaMoiNhat()
        {
            return giaoHangDAO.layMaPhieuMoiNhat();
        }

    }
}
