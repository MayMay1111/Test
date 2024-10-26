using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangDienTu.DTO
{
    public class NhaCungCapDTO
    {
        int maNhaCungCap;
        string tenNhaCungCap;
        string nguoiLienHe;
        string soDienThoai;
        string email;
        string diaChi;

        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string NguoiLienHe { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public NhaCungCapDTO(int maNhaCungCap, string tenNhaCungCap, string nguoiLienHe, string soDienThoai, string email, string diaChi)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.NguoiLienHe = nguoiLienHe;
            this.SoDienThoai = soDienThoai;
            this.Email = email;
            this.DiaChi = diaChi;
        }

        public NhaCungCapDTO()
        {
        }
    }
}
