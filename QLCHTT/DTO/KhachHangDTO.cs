using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class KhachHangDTO
    {
        int maKhachHang;
        string tenKhachHang;
        string soDienThoai;
        string email;
        string diaChi;
        int diemTichLuy;

        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int DiemTichLuy { get; set; }

        public KhachHangDTO(int maKhachHang, string tenKhachHang, string soDienThoai, string email, string diaChi, int diemTichLuy)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.diaChi = diaChi;
            this.diemTichLuy = diemTichLuy;
        }

        public KhachHangDTO()
        {
        }
    }
}
