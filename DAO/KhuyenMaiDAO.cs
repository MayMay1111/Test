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
    public class KhuyenMaiDAO
    {
        QLCHTTDataContext QLCHTT;
        public KhuyenMaiDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable GetAll()
        {
            var result = from km in QLCHTT.KhuyenMais
                         select km;
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public DataTable GetKhuyenMaiHopLe(int tongTien, DateTime ngayHienTai)
        {
            var result = from km in QLCHTT.KhuyenMais
                         where (ngayHienTai >= km.NgayBatDau && ngayHienTai <= km.NgayKetThuc &&
                                km.GiaTriDonHangToiThieu <= tongTien) || km.MaKhuyenMai == "KHONG"
                         select new { km.MaKhuyenMai, km.TenChuongTrinh };
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public float GiaTriKhuyenMai(string maKhuyenMai)
        {
            var result = QLCHTT.KhuyenMais
                .Where(km => km.MaKhuyenMai == maKhuyenMai)
                .Select(km => km.GiaTriKhuyenMai)
                .FirstOrDefault();
            if (result != null)
            {
                return (float)result;
            }
            return 0;
        }

        public string MoTaKhuyenMai(string maKhuyenMai)
        {
            return QLCHTT.KhuyenMais
                .Where(km => km.MaKhuyenMai == maKhuyenMai)
                .Select(km => km.MoTa)
                .FirstOrDefault();
        }

        public bool CheckTrungMa(string maKhuyenMai)
        {
            return QLCHTT.KhuyenMais
                .Any(km => km.MaKhuyenMai == maKhuyenMai);
        }

        public bool AddKhuyenMai(string maKhuyenMai, string tenChuongTrinh, float giaTriKhuyenMai, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien, int giaTriToiThieu)
        {
            var newKhuyenMai = new KhuyenMai
            {
                MaKhuyenMai = maKhuyenMai,
                TenChuongTrinh = tenChuongTrinh,
                GiaTriKhuyenMai = giaTriKhuyenMai,
                MoTa = moTa,
                NgayBatDau = ngayBatDau,
                NgayKetThuc = ngayKetThuc,
                DieuKienApDung = dieuKien,
                GiaTriDonHangToiThieu = giaTriToiThieu
            };
            QLCHTT.KhuyenMais.InsertOnSubmit(newKhuyenMai);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool UpdateKhuyenMai(string maKhuyenMai, string tenChuongTrinh, float giaTriKhuyenMai, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien, int giaTriToiThieu)
        {
            var khuyenMai = QLCHTT.KhuyenMais.FirstOrDefault(km => km.MaKhuyenMai == maKhuyenMai);
            if (khuyenMai == null) return false;

            khuyenMai.TenChuongTrinh = tenChuongTrinh;
            khuyenMai.GiaTriKhuyenMai = giaTriKhuyenMai;
            khuyenMai.MoTa = moTa;
            khuyenMai.NgayBatDau = ngayBatDau;
            khuyenMai.NgayKetThuc = ngayKetThuc;
            khuyenMai.DieuKienApDung = dieuKien;
            khuyenMai.GiaTriDonHangToiThieu = giaTriToiThieu;
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool DeleteKhuyenMai(string maKhuyenMai)
        {
            var khuyenMai = QLCHTT.KhuyenMais.FirstOrDefault(km => km.MaKhuyenMai == maKhuyenMai);
            if (khuyenMai == null) return false;

            QLCHTT.KhuyenMais.DeleteOnSubmit(khuyenMai);
            QLCHTT.SubmitChanges();
            return true;
        }

        public DataTable SearchKhuyenMai(string key)
        {
            var result = from km in QLCHTT.KhuyenMais
                         where km.MaKhuyenMai.Contains(key) || km.TenChuongTrinh.Contains(key)
                         select km;
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public DataTable ThongKeKhuyenMai(int thang, int nam)
        {
            var result = from hd in QLCHTT.HoaDons
                         join km in QLCHTT.KhuyenMais on hd.MaKhuyenMai equals km.MaKhuyenMai
                         where hd.NgayLapHoaDon.Value.Month == thang && hd.NgayLapHoaDon.Value.Year == nam
                         group hd by new { km.MaKhuyenMai, km.TenChuongTrinh, km.NgayBatDau, km.NgayKetThuc } into g
                         select new
                         {
                             g.Key.MaKhuyenMai,
                             g.Key.TenChuongTrinh,
                             SoDonHangSuDung = g.Count(),
                             DoanhThuMangLai = g.Sum(hd => hd.TongTien),
                             g.Key.NgayBatDau,
                             g.Key.NgayKetThuc
                         };
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public DataTable ThongKeKhuyenMaiAll()
    {
        var result = from km in QLCHTT.KhuyenMais
                     join hd in QLCHTT.HoaDons on km.MaKhuyenMai equals hd.MaKhuyenMai into hdGroup
                     from hd in hdGroup.DefaultIfEmpty()
                     group hd by new { km.MaKhuyenMai, km.TenChuongTrinh, km.NgayBatDau, km.NgayKetThuc } into g
                     select new
                     {
                         g.Key.MaKhuyenMai,
                         g.Key.TenChuongTrinh,
                         SoDonHangSuDung = g.Count(hd => hd != null),
                         DoanhThuMangLai = g.Sum(hd => hd.TongTien ?? 0),
                         g.Key.NgayBatDau,
                         g.Key.NgayKetThuc
                     };
        return ToDataTableUtils.ToDataTable(result.ToList());
    }

        public DataTable InThongKeKhuyenMai(int thang, int nam)
        {
            var result = from hd in QLCHTT.HoaDons
                         join km in QLCHTT.KhuyenMais on hd.MaKhuyenMai equals km.MaKhuyenMai
                         where hd.NgayLapHoaDon.Value.Month == thang && hd.NgayLapHoaDon.Value.Year == nam
                         group hd by new { km.MaKhuyenMai, km.TenChuongTrinh, km.NgayBatDau, km.NgayKetThuc } into g
                         select new
                         {
                             g.Key.MaKhuyenMai,
                             g.Key.TenChuongTrinh,
                             SoDonHangSuDung = g.Count(),
                             DoanhThuMangLai = g.Sum(hd => hd.TongTien),
                             NgayBatDau = g.Key.NgayBatDau.Value.Date,
                             NgayKetThuc = g.Key.NgayKetThuc.Value.Date,
                             Thang = thang.ToString(),
                             Nam = nam.ToString()
                         };
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

    }
}
