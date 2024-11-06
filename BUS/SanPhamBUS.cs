using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
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
        public bool addSanPham(string tenSanPham, string baoHanh, int danhMuc, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            return sanPhamDAO.addSanPham(tenSanPham, baoHanh, danhMuc, giaBan, ngaySanXuat, xuatXu, moTa);
        }
        public bool updateSanPham(string maSanPham, string tenSanPham, string baoHanh, int danhMuc, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            return sanPhamDAO.updateSanPham(maSanPham, tenSanPham, baoHanh, danhMuc, giaBan, ngaySanXuat, xuatXu, moTa);
        }
        public bool deleteSanPham(string maSanPham)
        {
            return sanPhamDAO.deleteSanPham(maSanPham);
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
