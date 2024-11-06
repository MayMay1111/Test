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
    public class NhapHangDAO
    {
        QLCHTTDataContext QLCHTT;
        public NhapHangDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll()
        {
            var results = from ddh in QLCHTT.DonDatHangNhaCungCaps
                          select new
                          {
                              ddh.MaDonDatHang,
                              ddh.MaNhaCungCap,
                              ddh.NgayDatHang,
                              ddh.TongTien,
                              ddh.TrangThai
                          };

            return ToDataTableUtils.ToDataTable(results.ToList());
        }

        public bool addDonNhapHang(int maNhaCungCap, DateTime ngayDatHang)
        {
            var maxDonNhapHang = QLCHTT.DonDatHangNhaCungCaps
            .OrderByDescending(ddh => ddh.MaDonDatHang)
            .FirstOrDefault();

            string newMaDonNhapHang;
            if (maxDonNhapHang != null)
            {
                int lastNumber = int.Parse(maxDonNhapHang.MaDonDatHang.Substring(4));
                newMaDonNhapHang = "DNCC" + (lastNumber + 1).ToString("D6");
            }
            else
            {
                newMaDonNhapHang = "DNCC000001";
            }

            DateTime ngayDatHangDate = new DateTime(ngayDatHang.Year, ngayDatHang.Month, ngayDatHang.Day);

            var donHang = new DonDatHangNhaCungCap
            {
                MaDonDatHang = newMaDonNhapHang,
                MaNhaCungCap = maNhaCungCap,
                NgayDatHang = ngayDatHangDate
            };
            QLCHTT.DonDatHangNhaCungCaps.InsertOnSubmit(donHang);
            QLCHTT.SubmitChanges();
            return true;
        }

        public string layDonMoi()
        {
            var result = QLCHTT.DonDatHangNhaCungCaps
                .OrderByDescending(d => Convert.ToInt32(d.MaDonDatHang.Substring(2)))
                .FirstOrDefault();

            if (result!= null && result.MaDonDatHang != null)
            {
                return result.MaDonDatHang;
            }
            return null;
        }

        public DataTable searchDonNhapHang(string key)
        {
            var results = from ddh in QLCHTT.DonDatHangNhaCungCaps
                          join ctdh in QLCHTT.ChiTietDonDatHangNhaCungCaps on ddh.MaDonDatHang equals ctdh.MaDonDatHang into joined
                          from ctdh in joined.DefaultIfEmpty()
                          join sp in QLCHTT.SanPhams on ctdh.MaSanPham equals sp.MaSanPham into spJoined
                          from sp in spJoined.DefaultIfEmpty()
                          where ddh.MaDonDatHang.Contains(key) ||
                                (sp != null && sp.TenSanPham.Contains(key)) ||
                                ddh.TrangThai.Contains(key)
                          select new
                          {
                              ddh.MaDonDatHang,
                              ddh.MaNhaCungCap,
                              ddh.NgayDatHang,
                              ddh.TongTien,
                              ddh.TrangThai
                          };

            return ToDataTableUtils.ToDataTable(results.Distinct().ToList());
        }

        public bool deleteDonNhapHang(string maDonDatHang)
        {
            var donHang = QLCHTT.DonDatHangNhaCungCaps.FirstOrDefault(d => d.MaDonDatHang == maDonDatHang);
            if (donHang != null)
            {
                QLCHTT.DonDatHangNhaCungCaps.DeleteOnSubmit(donHang);
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool updateDonNhapHang(string maDonDatHang, string trangThai)
        {
            var donHang = QLCHTT.DonDatHangNhaCungCaps.FirstOrDefault(d => d.MaDonDatHang == maDonDatHang);
            if (donHang != null)
            {
                if (donHang.TrangThai == "Đã nhập hàng vào kho")
                {
                    return false;
                }
                if (trangThai == "Đã đặt hàng")
                {
                    var tongTien = QLCHTT.ChiTietDonDatHangNhaCungCaps
                    .Where(ct => ct.MaDonDatHang == maDonDatHang)
                    .Sum(ct => ct.ThanhTien);

                    donHang.TongTien = tongTien;
                }
                donHang.TrangThai = trangThai;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

    }
}
