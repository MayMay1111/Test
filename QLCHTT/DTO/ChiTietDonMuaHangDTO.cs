using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class ChiTietDonMuaHangDTO
    {
        int maChiTietDonMuaHang;
        int maDonMuaHang;
        int idSanPham;
        int soLuong;
        decimal donGia;
        decimal thanhTien;

        public int MaChiTietDonMuaHang { get; set; }
        public int MaDonMuaHang { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietDonMuaHangDTO(int maChiTietDonMuaHang, int maDonMuaHang, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.MaChiTietDonMuaHang = maChiTietDonMuaHang;
            this.MaDonMuaHang = maDonMuaHang;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public ChiTietDonMuaHangDTO()
        {
        }
    }
}
