using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class KhuyenMaiDTO
    {
        int maKhuyenMai;
        string tenChuongTrinh;
        decimal giaTriKhuyenMai;
        string mota;
        DateTime ngayBatDau;
        DateTime ngayKetThuc;
        string dieuKienApDung;
        decimal giaTriDonHangToiThieu;

        public KhuyenMaiDTO()
        {
        }

        public KhuyenMaiDTO(int maKhuyenMai, string tenChuongTrinh, decimal giaTriKhuyenMai, string mota, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKienApDung, decimal giaTriDonHangToiThieu)
        {
            MaKhuyenMai = maKhuyenMai;
            TenChuongTrinh = tenChuongTrinh;
            GiaTriKhuyenMai = giaTriKhuyenMai;
            MoTa = mota;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            DieuKienApDung = dieuKienApDung;
            GiaTriDonHangToiThieu = giaTriDonHangToiThieu;
        }

        public int MaKhuyenMai { get; set; }
        public string TenChuongTrinh { get; set; }
        public decimal GiaTriKhuyenMai { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string DieuKienApDung { get; set; }
        public decimal GiaTriDonHangToiThieu { get; set; }

    }
}
