using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangTheThao.DTO
{
    public class DoiTraDTO
    {
        int maDoiTra;
        int maDonMuaHang;
        DateTime ngayDoiTra;
        string lyDo;
        string trangThai;

        public DoiTraDTO()
        {
        }

        public DoiTraDTO(int maDoiTra, int maDonMuaHang, DateTime ngayDoiTra, string lyDo, string trangThai)
        {
            this.MaDoiTra = maDoiTra;
            this.MaDonMuaHang = maDonMuaHang;
            this.NgayDoiTra = ngayDoiTra;
            this.LyDo = lyDo;
            this.TrangThai = trangThai;
        }

        public int MaDoiTra { get; set; }
        public int MaDonMuaHang { get; set; }
        public DateTime NgayDoiTra { get; set; }
        public string LyDo { get; set; }
        public string TrangThai { get; set; }

    }
}
