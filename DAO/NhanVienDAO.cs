using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    public class NhanVienDAO
    {
        QLCHTTDataContext QLCHTT = new QLCHTTDataContext();
        public DataTable getDataTable()
        {
            var result = from nv in QLCHTT.NhanViens
                         select nv;

            return ToDataTableUtils.ToDataTable(result.ToList());
        }
        public DataTable getChucVu()
        {
            var result = (from nv in QLCHTT.NhanViens
                          select nv.ChucVu).Distinct().ToList();

            var dataTable = new DataTable("ChucVu");
            dataTable.Columns.Add("TenChucVu", typeof(string));

            foreach (var item in result)
            {
                dataTable.Rows.Add(item);
            }

            return dataTable;
        }

        public bool xoaNhanVien(string maNhanVien) { 
            var nhanVien = QLCHTT.NhanViens.SingleOrDefault(nv => nv.MaNhanVien == maNhanVien);

            if (nhanVien != null)
            {
                QLCHTT.NhanViens.DeleteOnSubmit(nhanVien);
                QLCHTT.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool addNhanVien(string ten, string gioitinh, DateTime ngaySinh, string sdt, string chucVu, decimal mucLuong, string taiKhoan, string matKhau, byte[] hinhAnh)
        {
            var nhanVien = new NhanVien
            {
                TenNhanVien = ten,
                GioiTinh = gioitinh,
                NgaySinh = ngaySinh,
                SoDienThoai = sdt,
                ChucVu = chucVu,
                MucLuong = (int)mucLuong,
                TaiKhoan = taiKhoan,
                MatKhau = matKhau,
                HinhAnh = hinhAnh
            };

            QLCHTT.NhanViens.InsertOnSubmit(nhanVien);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool updateNhanVien(string ma, string ten, string gioitinh, DateTime ngaySinh, string sdt, string chucVu, decimal mucLuong, string taiKhoan, string matKhau, byte[] hinhAnh)
        {
            var nhanVien = QLCHTT.NhanViens.SingleOrDefault(nv => nv.MaNhanVien == ma);
            if (nhanVien == null) return false;

            nhanVien.TenNhanVien = ten;
            nhanVien.GioiTinh = gioitinh;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.SoDienThoai = sdt;
            nhanVien.ChucVu = chucVu;
            nhanVien.MucLuong = (int)mucLuong;
            nhanVien.TaiKhoan = taiKhoan;
            nhanVien.MatKhau = matKhau;
            if (hinhAnh != null)
            {
                nhanVien.HinhAnh = hinhAnh;
            }

            QLCHTT.SubmitChanges();
            return true;
        }

        public DataTable searchDataTable(string keyword)
        {
            var result = from nv in QLCHTT.NhanViens
                         where nv.TenNhanVien.Contains(keyword) || nv.SoDienThoai.Contains(keyword)
                         select nv;

            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public DataTable locNhanVien(string chucVu)
        {
            var result = from nv in QLCHTT.NhanViens
                         where nv.ChucVu == chucVu
                         select nv;

            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public bool trungTaiKhoan(string taiKhoan)
        {
            return QLCHTT.NhanViens.Any(nv => nv.TaiKhoan == taiKhoan);
        }

        public bool trungSoDienThoai(string sdt)
        {
            return QLCHTT.NhanViens.Any(nv => nv.SoDienThoai == sdt);
        }

        public DataTable lay1NhanVien(string ma)
        {
            var result = from nv in QLCHTT.NhanViens
                         where nv.MaNhanVien == ma
                         select nv;

            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public bool update1NhanVien(string ma, string ten, string gioitinh, DateTime ngaySinh, string sdt, string chucVu, decimal mucLuong, byte[] hinhAnh)
        {
            var nhanVien = QLCHTT.NhanViens.SingleOrDefault(nv => nv.MaNhanVien == ma);
            if (nhanVien == null) return false;

            nhanVien.TenNhanVien = ten;
            nhanVien.GioiTinh = gioitinh;
            nhanVien.NgaySinh = ngaySinh;
            nhanVien.SoDienThoai = sdt;
            nhanVien.ChucVu = chucVu;
            nhanVien.MucLuong = (int)mucLuong;
            if (hinhAnh != null)
            {
                nhanVien.HinhAnh = hinhAnh;
            }

            QLCHTT.SubmitChanges();
            return true;
        }

        public bool doiMatKhau(string taiKhoan, string matKhau)
        {
            var nhanVien = QLCHTT.NhanViens.SingleOrDefault(nv => nv.TaiKhoan == taiKhoan);
            if (nhanVien == null) return false;

            nhanVien.MatKhau = matKhau;
            QLCHTT.SubmitChanges();
            return true;
        }

    }
}
