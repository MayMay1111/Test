﻿using DAO;
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
                          select new
                          {
                              sp.MaSanPham,
                              sp.MaBaoHanh,
                              sp.TenSanPham,
                              sp.MaDanhMuc,
                              sp.MoTa,
                              sp.GiaBan,
                              sp.NgaySanXuat,
                              sp.XuatXu,
                          };

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
            var tongSoLuongNhap = QLCHTT.ChiTietDonDatHangNhaCungCaps
                .Where(ct => ct.MaSanPham == maSanPham &&
                QLCHTT.DonDatHangNhaCungCaps
                .Any(dh => dh.MaDonDatHang == ct.MaDonDatHang && dh.TrangThai == "Đã nhập hàng vào kho"))
                .Sum(ct => (int?)ct.SoLuong) ?? 0;

            var tongSoLuongBan = QLCHTT.ChiTietHoaDons
                .Where(ct => ct.MaSanPham == maSanPham)
                .Sum(ct => (int?)ct.SoLuong) ?? 0;

            int soLuongConLai = tongSoLuongNhap - tongSoLuongBan;

            return soLuongConLai;
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
            var maxKhachHang = QLCHTT.KhachHangs
            .OrderByDescending(kh => kh.MaKhachHang)
            .FirstOrDefault();

            string newMaSanPham;
            if (maxKhachHang != null)
            {
                int lastNumber = int.Parse(maxKhachHang.MaKhachHang.Substring(2));
                newMaSanPham = "SP" + (lastNumber + 1).ToString("D8");
            }
            else
            {
                newMaSanPham = "SP00000001";
            }
            var newSanPham = new SanPham
            {
                MaSanPham = newMaSanPham,
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
