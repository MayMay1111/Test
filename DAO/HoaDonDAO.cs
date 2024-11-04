using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class HoaDonDAO
    {
        QLCHTTDataContext QLCHTT;
        public HoaDonDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public bool addHoaDon(string maKhachHang, string maNhanVien, string maKhuyenMai, DateTime ngayLapHoaDon, int tongTien, string phuongThucThanhToan, int diemDung)
        {
            var hoaDon = new HoaDon
            {
                MaKhachHang = maKhachHang,
                MaNhanVien = maNhanVien,
                MaKhuyenMai = maKhuyenMai,
                NgayLapHoaDon = ngayLapHoaDon,
                TongTien = tongTien,
                PhuongThucThanhToan = phuongThucThanhToan,
                DiemDaDung = diemDung
            };

            QLCHTT.HoaDons.InsertOnSubmit(hoaDon);
            QLCHTT.SubmitChanges();
            return true;
        }

        public string layMaPhieuMoiNhat()
        {
            var maHoaDon = QLCHTT.HoaDons
                .OrderByDescending(hd => Convert.ToInt32(hd.MaHoaDon.Substring(2)))
                .Select(hd => hd.MaHoaDon)
                .FirstOrDefault();

            return maHoaDon;
        }

        public bool hoaDonMoi(string maNhanVien, DateTime ngayLap)
        {
            var hoaDon = new HoaDon
            {
                MaNhanVien = maNhanVien,
                NgayLapHoaDon = ngayLap
            };

            QLCHTT.HoaDons.InsertOnSubmit(hoaDon);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool deleteHoaDon(string maHoaDon)
        {
            var hoaDon = QLCHTT.HoaDons.SingleOrDefault(hd => hd.MaHoaDon == maHoaDon);
            if (hoaDon != null)
            {
                QLCHTT.HoaDons.DeleteOnSubmit(hoaDon);
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool updateHoaDon(string maHoaDon, string maKhachHang, string maKhuyenMai, int tongTien, string phuongThucThanhToan, int diemDung)
        {
            var hoaDon = QLCHTT.HoaDons.SingleOrDefault(hd => hd.MaHoaDon == maHoaDon);
            if (hoaDon != null)
            {
                hoaDon.MaKhachHang = maKhachHang;
                hoaDon.MaKhuyenMai = maKhuyenMai;
                hoaDon.TongTien = tongTien;
                hoaDon.PhuongThucThanhToan = phuongThucThanhToan;
                hoaDon.DiemDaDung = diemDung;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public DataTable getAll()
        {
            var results = QLCHTT.HoaDons.ToList();
            return ToDataTable(results);
        }

        public DataTable searchHoaDon(string key)
        {
            var results = QLCHTT.HoaDons
                .Where(hd => hd.MaHoaDon.Contains(key) ||
                             hd.MaNhanVien.Contains(key) ||
                             hd.MaKhachHang.Contains(key) ||
                             hd.KhachHang.TenKhachHang.Contains(key))
                .ToList();
            return ToDataTable(results);
        }

        public DataTable laySanPhamTuHoaDon(string maHoaDon)
        {
            var results = QLCHTT.ChiTietHoaDons
                .Where(cthd => cthd.MaHoaDon == maHoaDon)
                .Select(cthd => new
                {
                    cthd.MaSanPham,
                    cthd.SanPham.TenSanPham,
                    cthd.HoaDon.NgayLapHoaDon
                })
                .ToList();
            return ToDataTable(results);
        }

        public DateTime layNgayMua(string maHoaDon)
        {
            var ngayLapHoaDon = QLCHTT.HoaDons
                .Where(hd => hd.MaHoaDon == maHoaDon)
                .Select(hd => hd.NgayLapHoaDon)
                .FirstOrDefault();

            return ngayLapHoaDon ?? DateTime.Now;
        }

        // Helper method to convert List<T> to DataTable
        private DataTable ToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);

            // Get all properties
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}