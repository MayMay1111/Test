using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class SanPhamDTO
    {
        int id;
        string imei;
        string maSanPham;
        string tenSanPham;
        int maDanhMuc;
        string moTa;
        decimal giaBan;
        decimal giaNhap;
        int soLuong;
        int thoiGianBaoHanh;
        int maNhaCungCap;

        public int Id { get; set; }
        public string Imei { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaDanhMuc { get; set; }
        public string MoTa { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public int MaNhaCungCap { get; set; }

        public SanPhamDTO(int id, string imei, string maSanPham, string tenSanPham, int maDanhMuc, int maNhaCungCap, string moTa, decimal giaBan, decimal giaNhap, int soLuong, int thoiGianBaoHanh)
        {
            this.id = id;
            this.imei = imei;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.maDanhMuc = maDanhMuc;
            this.moTa = moTa;
            this.giaBan = giaBan;
            this.giaNhap = giaNhap;
            this.soLuong = soLuong;
            this.thoiGianBaoHanh = thoiGianBaoHanh;
            this.maNhaCungCap = maNhaCungCap;
        }

        public SanPhamDTO()
        {
        }
    }
}
