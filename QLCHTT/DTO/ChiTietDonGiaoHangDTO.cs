using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class ChiTietDonGiaoHangDTO
    {
        int maChiTietDonGiaoHang;
        int maDonGiaoHang;
        int idSanPham;
        int soLuong;
        decimal donGia;
        decimal thanhTien;

        public int MaChiTietDonGiaoHang { get; set; }
        public int MaDonGiaoHang { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietDonGiaoHangDTO(int maChiTietDonGiaoHang, int maDonGiaoHang, int idSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.MaChiTietDonGiaoHang = maChiTietDonGiaoHang;
            this.MaDonGiaoHang = maDonGiaoHang;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public ChiTietDonGiaoHangDTO()
        {
        }
    }
}
