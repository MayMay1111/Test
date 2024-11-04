using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class DonMuaHangDTO
    {
        int maDonMuaHang;
        int maKhachHang;
        int maNhanVien;
        DateTime ngayMua;
        decimal tongTien;
        decimal giamGia;
        string phuongThucThanhToan;
        string trangThai;

        public DonMuaHangDTO()
        {
        }

        public DonMuaHangDTO(int maDonMuaHang, int maKhachHang, int maNhanVien, DateTime ngayMua, decimal tongTien, decimal giamGia, string phuongThucThanhToan, string trangThai)
        {
            this.MaDonMuaHang = maDonMuaHang;
            this.MaKhachHang = maKhachHang;
            this.MaNhanVien = maNhanVien;
            this.NgayMua = ngayMua;
            this.TongTien = tongTien;
            this.GiamGia = giamGia;
            this.PhuongThucThanhToan = phuongThucThanhToan;
            this.TrangThai = trangThai;
        }

        public int MaDonMuaHang { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayMua { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string TrangThai { get; set; }

    }
}
