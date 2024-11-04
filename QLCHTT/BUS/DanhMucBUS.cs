using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class DanhMucBUS
    {
        private DanhMucDAO danhMucDAO;

        public DanhMucBUS()
        {
            danhMucDAO = new DanhMucDAO();
        }
        public DataTable getAll()
        {
            return danhMucDAO.getAll();
        }
        public bool addDanhMuc(string tenDanhMuc, string moTa)
        {
            return danhMucDAO.addDanhMuc(tenDanhMuc, moTa);
        }

        public bool updateDanhMuc(int maDanhMuc, string tenDanhMuc, string moTa)
        {
            return danhMucDAO.updateDanhMuc(maDanhMuc, tenDanhMuc, moTa);
        }

        public bool deleteDanhMuc(int maDanhMuc)
        {
            return danhMucDAO.deleteDanhMuc(maDanhMuc);
        }

        public DataTable searchDanhMuc(string key)
        {
            return danhMucDAO.searchDanhMuc(key);
        }
        public int tongSanPham(int maDanhMuc)
        {
            return danhMucDAO.tongSanPham(maDanhMuc);
        }


    }
}
