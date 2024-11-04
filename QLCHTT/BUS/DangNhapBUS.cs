using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class DangNhapBUS
    {
        private DangNhapDAO dangNhapDAO;

        public DangNhapBUS()
        {
            dangNhapDAO = new DangNhapDAO();
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            return dangNhapDAO.DangNhap(taiKhoan, matKhau);
        }

        public string layChucVu(string taiKhoan)
        {
            return dangNhapDAO.layChucVu(taiKhoan);
        }
        public string layMaNhanVien(string taiKhoan)
        {
            return dangNhapDAO.layMaNhanVien(taiKhoan);
        }
        public string layTenNhanVien(string ma)
        {
            return dangNhapDAO.layTenNhanVienTuMa(ma);
        }
    }
}
