using DAO;
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
        public DataTable getAll()
        {
            var results = from sp in QLCHTT.SanPhams
                          select sp;

            return ToDataTableUtils.ToDataTable(results.ToList());
        }

        public DataTable getSP()
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

        public int layThoiGianBaoHanh(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          join bh in QLCHTT.BaoHanhs on sp.MaBaoHanh equals bh.MaBaoHanh
                          where sp.MaSanPham == maSanPham
                          select bh.ThoiGianBaoHanh).FirstOrDefault();

            return result ?? 0;
        }

        public string layTenSanPham(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          where sp.MaSanPham == maSanPham
                          select sp.TenSanPham).FirstOrDefault();

            return result;
        }

        public string layMaSanPham(string tenSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          where sp.TenSanPham == tenSanPham
                          select sp.MaSanPham).FirstOrDefault();

            return result;
        }

        public int soLuongCon(string maSanPham)
        {
            return 0;
        }

        public DataTable searchSanPham(string key)
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

        public bool addSanPham(string tenSanPham,string baoHanh, int danhMuc, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
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

        public bool updateSanPham(string maSanPham, string tenSanPham, string baoHanh, int danhMuc, int giaBan, DateTime ngaySanXuat, string xuatXu, string moTa)
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

        public bool deleteSanPham(string maSanPham)
        {
            var sanPham = QLCHTT.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
            if (sanPham == null) return false;

            QLCHTT.SanPhams.DeleteOnSubmit(sanPham);
            QLCHTT.SubmitChanges();
            return true;
        }

        public int layBaoHanh(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          join bh in QLCHTT.BaoHanhs on sp.MaBaoHanh equals bh.MaBaoHanh
                          where sp.MaSanPham == maSanPham
                          select bh.ThoiGianBaoHanh).FirstOrDefault();

            return result ?? 0;
        }

        public int layGiaBan(string maSanPham)
        {
            var result = (from sp in QLCHTT.SanPhams
                          where sp.MaSanPham == maSanPham
                          select sp.GiaBan).FirstOrDefault();

            return result ?? 0;
        }


    }
}
