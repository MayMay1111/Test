﻿using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;
using QuanLyBanHangTheThao.DTO;

namespace QLCHTT.DAO
{
    public class GiaoHangDAO
    {
        QLCHTTDataContext QLCHTT;
        public GiaoHangDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }

        public DataTable getAll()
        {
            var query = from p in QLCHTT.GiaoHangs
                        join n in QLCHTT.NhanViens on p.NhanVienGiao equals n.MaNhanVien into employees
                        from n in employees.DefaultIfEmpty()
                        select new DonGiaoHangDTO
                        {
                            MaGiaoHang = p.MaGiaoHang,
                            MaHoaDon = p.MaHoaDon,
                            NhanVienGiao = n.TenNhanVien,
                            NgayGiao = p.NgayGiao,
                            DiaChi = p.DiaChi,
                            TinhTrang = p.TinhTrang
                        };

            return ToDataTableUtils.ToDataTable(query.ToList());
        }

        public DataTable timGiaoHang(string key)
        {
            var query = from p in QLCHTT.GiaoHangs
                        join n in QLCHTT.NhanViens on p.NhanVienGiao equals n.MaNhanVien into employees
                        from n in employees.DefaultIfEmpty()
                        where p.MaGiaoHang.Contains(key) ||
                              p.MaHoaDon.Contains(key) ||
                              n.TenNhanVien.Contains(key) ||
                              (p.NgayGiao.HasValue && p.NgayGiao.Value.ToString().Contains(key)) ||
                              p.DiaChi.Contains(key)
                        select new DonGiaoHangDTO
                        {
                            MaGiaoHang = p.MaGiaoHang,
                            MaHoaDon = p.MaHoaDon,
                            NhanVienGiao = n.TenNhanVien,
                            NgayGiao = p.NgayGiao,
                            DiaChi = p.DiaChi,
                            TinhTrang = p.TinhTrang
                        };

            return ToDataTable(query.ToList());
        }

        public bool suaGiaoHang(string nhanVienGiao, string tinhTrang, string magh, DateTime ngayGiao)
        {
            DateTime ngayGiaoDate = new DateTime(ngayGiao.Year, ngayGiao.Month, ngayGiao.Day);
            var giaoHang = QLCHTT.GiaoHangs.SingleOrDefault(p => p.MaGiaoHang == magh);
            if (giaoHang != null)
            {
                giaoHang.NhanVienGiao = nhanVienGiao;
                giaoHang.NgayGiao = ngayGiao;
                giaoHang.TinhTrang = tinhTrang;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool addGiaoHang(string maHoaDon, DateTime? ngayGiao, string diaChi)
        {
            var maxGiaoHang = QLCHTT.GiaoHangs
            .OrderByDescending(gh => gh.MaGiaoHang)
            .FirstOrDefault();

            string newMaGiaoHang;
            if (maxGiaoHang != null)
            {
                int lastNumber = int.Parse(maxGiaoHang.MaGiaoHang.Substring(2));
                newMaGiaoHang = "GH" + (lastNumber + 1).ToString("D8");
            }
            else
            {
                newMaGiaoHang = "GH00000001";
            }
            GiaoHang newGiaoHang = new GiaoHang
            {
                MaGiaoHang = newMaGiaoHang,
                MaHoaDon = maHoaDon,
                NgayGiao = ngayGiao,
                DiaChi = diaChi
            };
            QLCHTT.GiaoHangs.InsertOnSubmit(newGiaoHang);
            QLCHTT.SubmitChanges();
            return true;
        }

        public string layMaPhieuMoiNhat()
        {
            var maPhieuMoiNhat = QLCHTT.GiaoHangs
                .OrderByDescending(p => int.Parse(p.MaGiaoHang.Substring(2)))
                .Select(p => p.MaGiaoHang)
                .FirstOrDefault();
            return maPhieuMoiNhat;
        }

        private DataTable ToDataTable(List<DonGiaoHangDTO> giaoHangs)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("MaGiaoHang", typeof(string));
            dataTable.Columns.Add("MaHoaDon", typeof(string));
            dataTable.Columns.Add("TenNhanVien", typeof(string));
            dataTable.Columns.Add("NgayGiao", typeof(DateTime));
            dataTable.Columns.Add("DiaChi", typeof(string));
            dataTable.Columns.Add("TinhTrang", typeof(string));

            foreach (var item in giaoHangs)
            {
                var row = dataTable.NewRow();
                row["MaGiaoHang"] = item.MaGiaoHang;
                row["MaHoaDon"] = item.MaHoaDon;
                row["TenNhanVien"] = item.NhanVienGiao;
                row["NgayGiao"] = item.NgayGiao;
                row["DiaChi"] = item.DiaChi;
                row["TinhTrang"] = item.TinhTrang;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }


    }
}
