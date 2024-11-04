using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class ChiTietDonDatHangDTO
    {
        int maChiTietDonDatHang;
        int maDonDatHang;
        int idSanPham;
        int soLuong;
        int donGia;
        int thanhTien;

        public ChiTietDonDatHangDTO()
        {
        }

        public ChiTietDonDatHangDTO(int maChiTietDonDatHang, int maDonDatHang, int idSanPham, int soLuong, int donGia, int thanhTien)
        {
            this.MaChiTietDonDatHang = maChiTietDonDatHang;
            this.MaDonDatHang = maDonDatHang;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }

        public int MaChiTietDonDatHang { get; set; }
        public int MaDonDatHang { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }

    }
}
