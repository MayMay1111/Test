using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class GiaoHangBUS
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
        public bool suaGiaoHang(string nhanVienGiao, DateTime ngayGiao, string tinhTrang, string magh)
        {
            return giaoHangDAO.suaGiaoHang(nhanVienGiao, tinhTrang, magh, ngayGiao);
        }
        public DataTable timGiaoHang(string key)
        {
            return giaoHangDAO.timGiaoHang(key);
        }
        public bool addGiaoHang(string maHoaDon, DateTime ngayGiao, string diaChi)
        {
            return giaoHangDAO.addGiaoHang(maHoaDon, ngayGiao, diaChi);
        }
        public string layMaMoiNhat()
        {
            return giaoHangDAO.layMaPhieuMoiNhat();
        }

    }
}
