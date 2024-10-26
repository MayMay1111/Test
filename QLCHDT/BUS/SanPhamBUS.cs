using QLCHDT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO;
        public SanPhamBUS()
        {
            sanPhamDAO = new SanPhamDAO();
        }
        public DataTable getAll()
        {
            return sanPhamDAO.getAll();
        }

        public DataTable getSP()
        {
            return sanPhamDAO.getSP();
        }
        public int layThoiGianBaoHanh(string maSanPham)
        {
            return sanPhamDAO.layThoiGianBaoHanh(maSanPham);
        }
        public string layTenSanPham(string maSanPham)
        {
            return sanPhamDAO.layTenSanPham(maSanPham);
        }

        public string layMaSanPham(string tenSanPham)
        {
            return sanPhamDAO.layMaSanPham(tenSanPham);
        }

        public int soLuongCon(string maSanPham)
        {
            return sanPhamDAO.soLuongCon(maSanPham);
        }

        public DataTable searchSanPham(string key)
        {
            return sanPhamDAO.searchSanPham(key);
        }
        public bool addSanPham(string tenSanPham, string maVach, string baoHanh, int danhMuc, int nhaCungCap, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            return sanPhamDAO.addSanPham(tenSanPham, maVach, baoHanh, danhMuc, nhaCungCap, giaBan, ngaySanXuat, xuatXu, moTa);
        }
        public bool updateSanPham(string maSanPham, string tenSanPham, string maVach, string baoHanh, int danhMuc, int nhaCungCap, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            return sanPhamDAO.updateSanPham(maSanPham, tenSanPham, maVach, baoHanh, danhMuc, nhaCungCap, giaBan, ngaySanXuat, xuatXu, moTa);
        }
        public bool deleteSanPham(string maSanPham)
        {
            return sanPhamDAO.deleteSanPham(maSanPham);
        }
        public bool checkMaVachTrung(string maVach)
        {
            return sanPhamDAO.checkMaVachTrung(maVach);
        }
        public bool checkMaVachTrungSua(string maVach, string maSanPham)
        {
            return sanPhamDAO.checkMaVachTrungSua(maVach, maSanPham);
        }
        public string layMaVach(string maSanPham)
        {
            return sanPhamDAO.layMaVach(maSanPham);
        }
        public int layBaoHanh(string maSanPham)
        {
            return sanPhamDAO.layBaoHanh(maSanPham);
        }
        public int layGiaBan(string maSanPham)
        {
            return sanPhamDAO.layGiaBan(maSanPham);
        }
    }
}
