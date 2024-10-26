using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class DonDatHangDTO
    {
        int maDonDatHang;
        int maNhaCungCap;
        DateTime ngayDatHang;
        decimal tongTien;
        string trangThai;

        public DonDatHangDTO()
        {
        }

        public DonDatHangDTO(int maDonDatHang, int maNhaCungCap, DateTime ngayDatHang, decimal tongTien, string trangThai)
        {
            this.MaDonDatHang = maDonDatHang;
            this.MaNhaCungCap = maNhaCungCap;
            this.NgayDatHang = ngayDatHang;
            this.TongTien = tongTien;
            this.TrangThai = trangThai;
        }

        public int MaDonDatHang { get; set; }
        public int MaNhaCungCap { get; set; }
        public DateTime NgayDatHang { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }

    }
}
