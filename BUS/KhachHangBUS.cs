using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    internal class KhachHangBUS
    {
        public KhachHangDAO khachHangDAO;
        public KhachHangBUS()
        {
            khachHangDAO = new KhachHangDAO();
        }
        
        public DataTable getAll()
        {
            return khachHangDAO.AllKhachHang();
        }
        public bool themKH(string tenKH, string ngaySinh, string sdt)
        {
            return khachHangDAO.themKhachHang(tenKH, ngaySinh, sdt);
        }
        public bool suaKH(string maKHHT, string tenKH, string ngaySinh, string sdt, string diem)
        {
            return khachHangDAO.suaKhachHang(maKHHT, tenKH, ngaySinh, sdt, diem);
        }
        public bool xoaKH(string maKHHT, string tenKH, string ngaySinh, string sdt, string diem)
        {
            return khachHangDAO.xoaKhachHang(maKHHT, tenKH, ngaySinh, sdt, diem);
        }
        public bool hienKH(string maKHHT, string tenKH, string ngaySinh, string sdt, string diem)
        {
            return khachHangDAO.hienKhachHang(maKHHT, tenKH, ngaySinh, sdt, diem);

        }
        public DataTable search(string str)
        {
            return khachHangDAO.search(str);
        }
        public bool kiemTraSDT(string sdt)
        {
            return khachHangDAO.kiemTraSDT(sdt);
        }
        public DataTable locKhachHangAn(int trangthai)
        {
            return khachHangDAO.locKhachHangAn(trangthai);
        }
        public string layKhachHangSDT(string soDienThoai)
        {
            return khachHangDAO.layTenKhachHangSDT(soDienThoai);
        }
        public int layDiemTichLuyKhachHangSDT(string soDienThoai)
        {
            return khachHangDAO.layDiemKhachHangSDT(soDienThoai);
        }
        public bool addKhachHang(string tenKhachHang, DateTime ngaySinh, string soDienThoai)
        {
            return khachHangDAO.themKhachHang(tenKhachHang, ngaySinh, soDienThoai);
        }
        public string layMaKhachHang(string soDienThoai)
        {
            return khachHangDAO.layMaKhachHangSDT(soDienThoai);
        }
        public string layTenKhachHang(string ma)
        {
            return khachHangDAO.layTenKhachHang(ma);
        }

    }
}
