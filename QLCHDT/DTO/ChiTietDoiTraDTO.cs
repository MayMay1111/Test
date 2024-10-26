using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class ChiTietDoiTraDTO
    {
        int maChiTietDoiTra;
        int maDoiTra;
        int idSanPham;
        int soLuong;

        public int MaChiTietDoiTra { get; set ; }
        public int MaDoiTra { get ; set ; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }

        public ChiTietDoiTraDTO(int maChiTietDoiTra, int maDoiTra, int idSanPham, int soLuong)
        {
            this.MaChiTietDoiTra = maChiTietDoiTra;
            this.MaDoiTra = maDoiTra;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
        }

        public ChiTietDoiTraDTO()
        {
        }
    }
}
