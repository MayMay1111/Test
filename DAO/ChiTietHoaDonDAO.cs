using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class ChiTietHoaDonDAO
    {
        QLCHTTDataContext QLCHTT;
        public ChiTietHoaDonDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getChiTietMa(string maHoaDon)
        {
            var query = from ct in QLCHTT.ChiTietHoaDons
                        where ct.MaHoaDon == maHoaDon
                        select ct;

            return ToDataTable(query.ToList());
        }

        public DataTable getAll()
        {
            var query = from ct in QLCHTT.ChiTietHoaDons
                        select ct;

            return ToDataTable(query.ToList());
        }

        public bool kiemTraTrungSanPham(string maHoaDon, string maSanPham)
        {
            return QLCHTT.ChiTietHoaDons
                .Any(ct => ct.MaHoaDon == maHoaDon && ct.MaSanPham == maSanPham);
        }

        public bool updateChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            var chiTiet = QLCHTT.ChiTietHoaDons
                .FirstOrDefault(ct => ct.MaHoaDon == maHoaDon && ct.MaSanPham == maSanPham);

            if (chiTiet != null)
            {
                chiTiet.SoLuong = soLuong;
                chiTiet.DonGia = donGia;
                chiTiet.ThanhTien = thanhTien;
                chiTiet.GhiChu = ghiChu;

                QLCHTT.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool addChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            var newChiTiet = new ChiTietHoaDon
            {
                MaHoaDon = maHoaDon,
                MaSanPham = maSanPham,
                SoLuong = soLuong,
                DonGia = donGia,
                ThanhTien = thanhTien,
                GhiChu = ghiChu
            };

            QLCHTT.ChiTietHoaDons.InsertOnSubmit(newChiTiet);
            QLCHTT.SubmitChanges();
            return true;
        }

        private DataTable ToDataTable(List<ChiTietHoaDon> chiTietHoaDons)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("MaHoaDon", typeof(string));
            dataTable.Columns.Add("MaSanPham", typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));
            dataTable.Columns.Add("DonGia", typeof(int));
            dataTable.Columns.Add("ThanhTien", typeof(int));
            dataTable.Columns.Add("GhiChu", typeof(string));

            foreach (var item in chiTietHoaDons)
            {
                var row = dataTable.NewRow();
                row["MaHoaDon"] = item.MaHoaDon;
                row["MaSanPham"] = item.MaSanPham;
                row["SoLuong"] = item.SoLuong;
                row["DonGia"] = item.DonGia;
                row["ThanhTien"] = item.ThanhTien;
                row["GhiChu"] = item.GhiChu;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

    }
}
