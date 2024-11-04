using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class InHoaDonDAO
    {
        QLCHTTDataContext QLCHTT;
        
        public InHoaDonDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }

        public DataTable inHoaDon(string maHD)
        {
            var query = from hd in QLCHTT.HoaDons
                        join cthd in QLCHTT.ChiTietHoaDons on hd.MaHoaDon equals cthd.MaHoaDon
                        join kh in QLCHTT.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                        join nv in QLCHTT.NhanViens on hd.MaNhanVien equals nv.MaNhanVien
                        join sp in QLCHTT.SanPhams on cthd.MaSanPham equals sp.MaSanPham
                        join km in QLCHTT.KhuyenMais on hd.MaKhuyenMai equals km.MaKhuyenMai into kmGroup
                        from km in kmGroup.DefaultIfEmpty()
                        where hd.MaHoaDon == maHD
                        let tongTienGoc = QLCHTT.ChiTietHoaDons
                            .Where(ct => ct.MaHoaDon == hd.MaHoaDon)
                            .Sum(ct => ct.ThanhTien)
                        let giaTriKhuyenMaiTinh = km == null ? 0 :
                            km.MoTa == "Giảm phần trăm" ? tongTienGoc * (km.GiaTriKhuyenMai) :
                            km.MoTa == "Giảm trực tiếp" ? km.GiaTriKhuyenMai : 0
                        let tongTienSauKhuyenMai = tongTienGoc - giaTriKhuyenMaiTinh
                        select new
                        {
                            kh.TenKhachHang,
                            kh.SoDienThoai,
                            nv.TenNhanVien,
                            sp.TenSanPham,
                            cthd.SoLuong,
                            cthd.DonGia,
                            cthd.ThanhTien,
                            TongTienGoc = tongTienGoc,
                            hd.TongTien,
                            TenChuongTrinh = km == null ? null : km.TenChuongTrinh,
                            GiaTriKhuyenMai = km == null ? 0 : km.GiaTriKhuyenMai,
                            MoTa = km == null ? null : km.MoTa,
                            GiaTriKhuyenMaiTinh = (float)giaTriKhuyenMaiTinh,
                            TongTienSauKhuyenMai = (float)tongTienSauKhuyenMai
                        };

            return ToDataTable(query.ToList());
        }

        private DataTable ToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);

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
