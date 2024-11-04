using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class ChiTietNhapHangDAO
    {
        QLCHTTDataContext QLCHTT;
        public ChiTietNhapHangDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll(string maDonDatHang)
        {
            var query = from ctd in QLCHTT.ChiTietDonDatHangNhaCungCaps
                        where ctd.MaDonDatHang == maDonDatHang
                        select ctd;

            return ToDataTable(query.ToList());
        }

        public bool addChiTietDonNhapHang(string maDonDatHang, string maSanPham, int soLuong, int donGia, out string errorMessage)
        {
            errorMessage = string.Empty;

            var existingItem = QLCHTT.ChiTietDonDatHangNhaCungCaps
                .FirstOrDefault(ctd => ctd.MaDonDatHang == maDonDatHang && ctd.MaSanPham == maSanPham);

            if (existingItem != null)
            {
                if (existingItem.DonGia != donGia)
                {
                    errorMessage = "Đơn giá không khớp với đơn giá đã lưu. Vui lòng kiểm tra lại.";
                    return false;
                }
                else
                {
                    existingItem.SoLuong += soLuong;
                    existingItem.ThanhTien = existingItem.SoLuong * existingItem.DonGia;
                    QLCHTT.SubmitChanges();
                    return true;
                }
            }
            else
            {
                var newChiTiet = new ChiTietDonDatHangNhaCungCap
                {
                    MaDonDatHang = maDonDatHang,
                    MaSanPham = maSanPham,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    ThanhTien = soLuong * donGia
                };

                QLCHTT.ChiTietDonDatHangNhaCungCaps.InsertOnSubmit(newChiTiet);
                QLCHTT.SubmitChanges();
                return true;
            }
        }

        private DataTable ToDataTable(List<ChiTietDonDatHangNhaCungCap> chiTietDonDatHangNhaCungCaps)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("MaDonDatHang", typeof(string));
            dataTable.Columns.Add("MaSanPham", typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));
            dataTable.Columns.Add("DonGia", typeof(int));
            dataTable.Columns.Add("ThanhTien", typeof(int));

            foreach (var item in chiTietDonDatHangNhaCungCaps)
            {
                var row = dataTable.NewRow();
                row["MaDonDatHang"] = item.MaDonDatHang;
                row["MaSanPham"] = item.MaSanPham;
                row["SoLuong"] = item.SoLuong;
                row["DonGia"] = item.DonGia;
                row["ThanhTien"] = item.ThanhTien;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }



    }
}
