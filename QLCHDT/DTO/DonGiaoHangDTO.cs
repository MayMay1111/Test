using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class DonGiaoHangDTO
    {
        int maDonGiaoHang;
        int maKhachHang;
        DateTime ngayDatHang;
        DateTime ngayGiaoHang;
        string diaChiGiao;
        int tongTien;
        decimal phiVanChuyen;
        string trangThaiGiao;

        public int MaDonGiaoHang { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public string DiaChiGiao { get; set; }
        public int TongTien { get; set; }
        public decimal PhiVanChuyen { get; set; }
        public string TrangThaiGiao { get; set; }

        public DonGiaoHangDTO(int maDonGiaoHang, int maKhachHang, DateTime ngayDatHang, DateTime ngayGiaoHang, string diaChiGiao, int tongTien, decimal phiVanChuyen, string trangThaiGiao)
        {
            this.MaDonGiaoHang = maDonGiaoHang;
            this.MaKhachHang = maKhachHang;
            this.NgayDatHang = ngayDatHang;
            this.NgayGiaoHang = ngayGiaoHang;
            this.DiaChiGiao = diaChiGiao;
            this.TongTien = tongTien;
            this.PhiVanChuyen = phiVanChuyen;
            this.TrangThaiGiao = trangThaiGiao;
        }

        public DonGiaoHangDTO()
        {
        }
    }
}
