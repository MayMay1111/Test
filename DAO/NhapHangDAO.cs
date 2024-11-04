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
        public DataTable GetAll()
        {
            var results = from ddh in QLCHTT.DonDatHangNhaCungCaps
                          select ddh;

            return ToDataTableUtils.ToDataTable(results.ToList());
        }

        public bool AddDonNhapHang(int maNhaCungCap, DateTime ngayDatHang)
        {
            var donHang = new DonDatHangNhaCungCap
            {
                MaNhaCungCap = maNhaCungCap,
                NgayDatHang = ngayDatHang
            };
            QLCHTT.DonDatHangNhaCungCaps.InsertOnSubmit(donHang);
            QLCHTT.SubmitChanges();
            return true;
        }

        public string LayDonMoi()
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

        public DataTable SearchDonNhapHang(string key)
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

        public bool DeleteDonNhapHang(string maDonDatHang)
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

        public bool UpdateDonNhapHang(string maDonDatHang, string trangThai)
        {
            var donHang = QLCHTT.DonDatHangNhaCungCaps.FirstOrDefault(d => d.MaDonDatHang == maDonDatHang);
            if (donHang != null)
            {
                donHang.TrangThai = trangThai;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

    }
}
