using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class DonGiaoHangDTO
    {
        public string MaGiaoHang { get; set; }
        public string MaHoaDon { get; set; }
        public string NhanVienGiao { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string DiaChi { get; set; }
        public string TinhTrang { get; set; }

        public DonGiaoHangDTO(string maGiaoHang, string maHoaDon, string nhanVienGiao, DateTime? ngayGiao, string diaChi, string tinhTrang)
        {
            MaGiaoHang = maGiaoHang;
            MaHoaDon = maHoaDon;
            NhanVienGiao = nhanVienGiao;
            NgayGiao = ngayGiao;
            DiaChi = diaChi;
            TinhTrang = tinhTrang;
        }

        public DonGiaoHangDTO() { }
        }
}
