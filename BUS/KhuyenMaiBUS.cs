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
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAO khuyenMaiDAO;
        public KhuyenMaiBUS()
        {
            khuyenMaiDAO = new KhuyenMaiDAO();
        }
        public DataTable getAll()
        {
            return khuyenMaiDAO.getAll();
        }
        public DataTable GetKhuyenMaiHopLe(int tongTien, DateTime ngayHienTai)
        {
            return khuyenMaiDAO.getKhuyenMaiHopLe(tongTien, ngayHienTai);
        }

        public float giaTriKhuyenMai(string maKhuyenMai)
        {
            return khuyenMaiDAO.giaTriKhuyenMai(maKhuyenMai);
        }
        public string moTaKhuyenMai(string maKhuyenMai)
        {
            return khuyenMaiDAO.moTaKhuyenMai(maKhuyenMai);
        }

        public bool checkTrungMa(string maKhuyenMai)
        {
            return khuyenMaiDAO.checkTrungMa(maKhuyenMai);
        }
        public bool addKhuyenMai(string maKhuyenMai, string tenChuongTrinh, float giaTriKhuyenMai, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien, int giaTriToiThieu)
        {
            return khuyenMaiDAO.addKhuyenMai(maKhuyenMai, tenChuongTrinh, giaTriKhuyenMai, moTa, ngayBatDau, ngayKetThuc, dieuKien, giaTriToiThieu);
        }

        public bool deleteKhuyenMai(string maKhuyenMai)
        {
            return khuyenMaiDAO.deleteKhuyenMai(maKhuyenMai);
        }
        public bool updatekhuyenMai(string maKhuyenMai, string tenChuongTrinh, float giaTriKhuyenMai, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien, int giaTriToiThieu)
        {
            return khuyenMaiDAO.updateKhuyenMai(maKhuyenMai, tenChuongTrinh, giaTriKhuyenMai, moTa, ngayBatDau, ngayKetThuc, dieuKien, giaTriToiThieu);
        }
        public DataTable searchKhuyenMai(string key)
        {
            return khuyenMaiDAO.searchKhuyenMai(key);
        }
        public DataTable thongKeKhuyenMai(int thang, int nam)
        {
            return khuyenMaiDAO.thongKeKhuyenMai(thang, nam);
        }
        public DataTable thongKeKhuyenMaiAll()
        {
            return khuyenMaiDAO.thongKeKhuyenMaiAll();
        }
        public DataTable inThongKeKhuyenMai(int thang, int nam)
        {
            return khuyenMaiDAO.inThongKeKhuyenMai(thang, nam);
        }
    }
}
