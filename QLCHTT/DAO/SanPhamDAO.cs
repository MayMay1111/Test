using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    public class SanPhamDAO
    {
        QLCHTTDataContext QLCHTT;
        public SanPhamDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable GetAll()
        {
            var results = from sp in QLCHTT.SanPhams
                          select sp;

            return ToDataTableUtils.ToDataTable(results.ToList());
        }

        public DataTable GetSP()
        {
            var results = from sp in QLCHTT.SanPhams
                          select new
                          {
                              sp.MaSanPham,
                              sp.TenSanPham,
                              sp.GiaBan
                          };

            return ToDataTableUtils.ToDataTable(results.ToList());
        }

        public int LayThoiGianBaoHanh(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          join bh in QLCHTT.BaoHanhs on sp.MaBaoHanh equals bh.MaBaoHanh
                          where sp.MaSanPham == maSanPham
                          select bh.ThoiGianBaoHanh).FirstOrDefault();

            return result ?? 0;
        }

        public string LayTenSanPham(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          where sp.MaSanPham == maSanPham
                          select sp.TenSanPham).FirstOrDefault();

            return result;
        }

        public string LayMaSanPham(string tenSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          where sp.TenSanPham == tenSanPham
                          select sp.MaSanPham).FirstOrDefault();

            return result;
        }

        public int SoLuongCon(string maSanPham)
        {
            return 0;
        }

        public DataTable SearchSanPham(string key)
        {
            var results = from sp in QLCHTT.SanPhams
                          where sp.TenSanPham.Contains(key) || sp.MaSanPham.Contains(key)
                          select new
                          {
                              sp.MaSanPham,
                              sp.TenSanPham,
                              sp.GiaBan
                          };

            return ToDataTableUtils.ToDataTable(results.ToList());
        }

        public bool AddSanPham(string tenSanPham,string baoHanh, int danhMuc, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            var newSanPham = new SanPham
            {
                TenSanPham = tenSanPham,
                MaBaoHanh = baoHanh,
                MaDanhMuc = danhMuc,
                GiaBan = giaBan,
                NgaySanXuat = ngaySanXuat,
                XuatXu = xuatXu,
                MoTa = moTa
            };
            QLCHTT.SanPhams.InsertOnSubmit(newSanPham);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool UpdateSanPham(string maSanPham, string tenSanPham, string baoHanh, int danhMuc, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
        {
            var sanPham = QLCHTT.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            if (sanPham == null) return false;

            sanPham.TenSanPham = tenSanPham;
            sanPham.MaBaoHanh = baoHanh;
            sanPham.MaDanhMuc = danhMuc;
            sanPham.GiaBan = giaBan;
            sanPham.NgaySanXuat = ngaySanXuat;
            sanPham.XuatXu = xuatXu;
            sanPham.MoTa = moTa;
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool DeleteSanPham(string maSanPham)
        {
            var sanPham = QLCHTT.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            if (sanPham == null) return false;

            QLCHTT.SanPhams.DeleteOnSubmit(sanPham);
            QLCHTT.SubmitChanges();
            return true;
        }

        public int LayBaoHanh(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          join bh in QLCHTT.BaoHanhs on sp.MaBaoHanh equals bh.MaBaoHanh
                          where sp.MaSanPham == maSanPham
                          select bh.ThoiGianBaoHanh).FirstOrDefault();

            return result ?? 0;
        }

        public int LayGiaBan(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          where sp.MaSanPham == maSanPham
                          select sp.GiaBan).FirstOrDefault();

            return result ?? 0;
        }


    }
}
