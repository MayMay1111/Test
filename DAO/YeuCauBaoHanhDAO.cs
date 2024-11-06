using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    public class YeuCauBaoHanhDAO
    {
        QLCHTTDataContext QLCHTT;
        public YeuCauBaoHanhDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll()
        {
            var query = from ycbh in QLCHTT.YeuCauBaoHanhs
                        select new
                        {
                            ycbh.MaYeuCauBaoHanh,
                            ycbh.MaHoaDon,
                            ycbh.MaSanPham,
                            ycbh.NgayYeuCau,
                            ycbh.LyDo,
                            ycbh.TrangThai
                        };

            return ToDataTableUtils.ToDataTable(query);
        }

        public bool addYeuCauBaoHanh(string maHoaDon, string maSanPham, string lyDo, string trangThai)
        {
            var maxYCBH = QLCHTT.YeuCauBaoHanhs
            .OrderByDescending(ycbh => ycbh.MaYeuCauBaoHanh)
            .FirstOrDefault();

            string newMaYCBH;
            if (maxYCBH != null)
            {
                int lastNumber = int.Parse(maxYCBH.MaHoaDon.Substring(2));
                newMaYCBH = "YCBH" + (lastNumber + 1).ToString("D6");
            }
            else
            {
                newMaYCBH = "YCBH000001";
            }
            
            DateTime ngayYeuCau = DateTime.Now.Date;

            var newRequest = new YeuCauBaoHanh
            {
                MaYeuCauBaoHanh = newMaYCBH,
                MaHoaDon = maHoaDon,
                MaSanPham = maSanPham,
                NgayYeuCau = ngayYeuCau,
                LyDo = lyDo,
                TrangThai = trangThai
            };

            QLCHTT.YeuCauBaoHanhs.InsertOnSubmit(newRequest);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool deleteYeuCauBaoHanh(string maYeuCau)
        {
            var request = QLCHTT.YeuCauBaoHanhs.SingleOrDefault(y => y.MaYeuCauBaoHanh == maYeuCau);
            if (request != null)
            {
                QLCHTT.YeuCauBaoHanhs.DeleteOnSubmit(request);
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool updateYeuCauBaoHanh(string maYeuCau, string trangThai)
        {
            var request = QLCHTT.YeuCauBaoHanhs.SingleOrDefault(y => y.MaYeuCauBaoHanh == maYeuCau);
            if (request != null)
            {
                request.TrangThai = trangThai;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public DataTable searchYeuCauBaoHanh(string key)
        {
            var query = from ycbh in QLCHTT.YeuCauBaoHanhs
                        where ycbh.MaHoaDon.Contains(key) ||
                              ycbh.MaSanPham.Contains(key) ||
                              ycbh.TrangThai.Contains(key)
                        select ycbh;

            return ToDataTableUtils.ToDataTable(query);
        }

        public DataTable inYeuCauBaoHanh(string ma)
        {
            var query = from ycbh in QLCHTT.YeuCauBaoHanhs
                        join hd in QLCHTT.HoaDons on ycbh.MaHoaDon equals hd.MaHoaDon
                        join cthd in QLCHTT.ChiTietHoaDons on new { hd.MaHoaDon, ycbh.MaSanPham } equals new { cthd.MaHoaDon, cthd.MaSanPham }
                        join sp in QLCHTT.SanPhams on ycbh.MaSanPham equals sp.MaSanPham
                        join kh in QLCHTT.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                        where ycbh.MaYeuCauBaoHanh == ma
                        select new
                        {
                            ycbh.MaYeuCauBaoHanh,
                            ycbh.MaHoaDon,
                            sp.TenSanPham,
                            ycbh.NgayYeuCau,
                            ycbh.LyDo,
                            kh.TenKhachHang,
                            kh.SoDienThoai
                        };

            return ToDataTableUtils.ToDataTable(query);
        }

    }
}
