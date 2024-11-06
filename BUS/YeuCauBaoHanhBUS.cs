using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class YeuCauBaoHanhBUS
    {
        YeuCauBaoHanhDAO yeuCauBaoHanhDAO;
        public YeuCauBaoHanhBUS()
        {
            yeuCauBaoHanhDAO = new YeuCauBaoHanhDAO();
        }
        public DataTable getAll()
        {
            return yeuCauBaoHanhDAO.getAll();
        }
        public bool addYeuCauBaoHanh(string maHoaDon, string maSanPham,  string lyDo, string trangThai)
        {
            return yeuCauBaoHanhDAO.addYeuCauBaoHanh(maHoaDon, maSanPham, lyDo, trangThai);
        }
        public bool deleteYeuCauBaoHanh(string maYeuCau)
        {
            return yeuCauBaoHanhDAO.deleteYeuCauBaoHanh(maYeuCau);
        }
        public bool updateYeuCauBaoHanh(string maYeuCau, string trangThai)
        {
            return yeuCauBaoHanhDAO.updateYeuCauBaoHanh(maYeuCau, trangThai);
        }
        public DataTable searchYeuCauBaoHanh(string key)
        {
            return yeuCauBaoHanhDAO.searchYeuCauBaoHanh(key);
        }
        public DataTable inYeuCauBaoHanh(string ma)
        {
            return yeuCauBaoHanhDAO.inYeuCauBaoHanh(ma);
        }
    }
}
