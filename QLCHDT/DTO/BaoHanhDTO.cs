using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class BaoHanhDTO
    {
        int maBaoHanh;
        int maChiTietDonMuaHang;
        int idSanPham;
        DateTime ngayBatDau;
        DateTime ngayKetThuc;
        string trangThai;

        public BaoHanhDTO()
        {
        }

        public BaoHanhDTO(int maBaoHanh, int maChiTietDonMuaHang, int idSanPham, DateTime ngayBatDau, DateTime ngayKetThuc, string trangThai)
        {
            this.MaBaoHanh = maBaoHanh;
            this.MaChiTietDonMuaHang = maChiTietDonMuaHang;
            this.IdSanPham = idSanPham;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.TrangThai = trangThai;
        }

        public int MaBaoHanh { get; set; }
        public int MaChiTietDonMuaHang { get; set; }
        public int IdSanPham { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TrangThai { get; set; }

    }
}
