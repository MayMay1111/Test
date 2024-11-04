using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class NhapHangBUS
    {
        NhapHangDAO nhapHangDAO;
        public NhapHangBUS()
        {
            nhapHangDAO = new NhapHangDAO();
        }
        public DataTable getAll()
        {
            return nhapHangDAO.getAll();
        }
        public bool addDonNhapHang(string maNhaCungCap, DateTime ngayDatHang)
        {
            return nhapHangDAO.addDonNhapHang(maNhaCungCap, ngayDatHang);
        }
        public string layDonMoi()
        {
            return nhapHangDAO.layDonMoi();
        }
        public bool updateDonNhapHang(string maDonDatHang, string trangThai)
        {
            return nhapHangDAO.updateDonNhapHang(maDonDatHang, trangThai);
        }
        public DataTable searchDonNhapHang(string key)
        {
            return nhapHangDAO.searchDonNhapHang(key);
        }
    }
}
