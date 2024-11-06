using QLCHTT.DAO;
using QuanLyBanHangTheThao.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO nhaCungCapDAO;
        public NhaCungCapBUS()
        {
            nhaCungCapDAO = new NhaCungCapDAO();
        }
        public DataTable getAll()
        {
            return nhaCungCapDAO.getAll();
        }
        public bool addNhaCungCap(string tenNhaCungCap, string nguoiLienHe, string diaChi, string soDienThoai)
        {
            return nhaCungCapDAO.addNhaCungCap(tenNhaCungCap, nguoiLienHe, diaChi, soDienThoai);
        }

        public bool updateNhaCungCap(int maNhaCungCap, string tenNhaCungCap, string nguoiLienHe, string diaChi, string soDienThoai)
        {
            return nhaCungCapDAO.updateNhaCungCap(maNhaCungCap, tenNhaCungCap, nguoiLienHe, diaChi, soDienThoai);
        }

        public bool deleteNhaCungCap(int maNhaCungCap)
        {
            return nhaCungCapDAO.deleteNhaCungCap(maNhaCungCap);
        }

        public DataTable searchNhaCungCap(string key)
        {
            return nhaCungCapDAO.searchNhaCungCap(key);
        }
    }
}
