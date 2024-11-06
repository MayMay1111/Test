using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class NhanVienBUS
    {
        public NhanVienDAO nhanVienDAO;
        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }
        public DataTable getAll()
        {
            return nhanVienDAO.getDataTable();
        }
        public bool addNhanVien(string ten, string gioitinh, DateTime ngaySinh, string sdt, string chucVu, decimal mucLuong, string taikhoan, string matKhau, byte[] hinhAnh)
        {
            return nhanVienDAO.addNhanVien(ten, gioitinh, ngaySinh, sdt, chucVu, mucLuong, taikhoan, matKhau, hinhAnh);
        }
        public bool updateNhanVien(string ma, string ten, string gioitinh, DateTime ngaySinh, string sdt, string chucVu, decimal mucLuong, string taikhoan, string matKhau, byte[] hinhAnh)
        {
            return nhanVienDAO.updateNhanVien(ma, ten, gioitinh, ngaySinh, sdt, chucVu, mucLuong, taikhoan, matKhau, hinhAnh);
        }
        public DataTable lay1NhanVien(string ma)
        {
            return nhanVienDAO.lay1NhanVien(ma);
        }
        public bool doiMatKhau(string taikhoan, string matkhau)
        {
            return nhanVienDAO.doiMatKhau(taikhoan, matkhau);
        }
    }
}
