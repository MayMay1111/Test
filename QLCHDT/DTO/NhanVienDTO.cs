﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class NhanVienDTO
    {
        int maNhanVien;
        string tenNhanVien;
        string soDienThoai;
        string email;
        string chucVu;
        string taiKhoan;
        string matKhau;

        public NhanVienDTO() { }

        public NhanVienDTO(int maNhanVien, string tenNhanVien, string soDienThoai, string email, string chucVu, string taiKhoan, string matKhau)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.SoDienThoai = soDienThoai;
            this.Email = email;
            this.ChucVu = chucVu;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
        }

        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

    }
}
