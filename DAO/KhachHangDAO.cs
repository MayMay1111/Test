
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class KhachHangDAO
    {
        QLCHTTDataContext QLCHTT = new QLCHTTDataContext();

        public DataTable AllKhachHang()
        {
            var query = from kh in QLCHTT.KhachHangs
                        where kh.TrangThai == "show"
                        select new
                        {
                            kh.MaKhachHang,
                            kh.TenKhachHang,
                            kh.NgaySinh,
                            kh.SoDienThoai,
                            kh.DiemTichLuy
                        };
            return ToDataTable(query.ToList());
        }

        public bool themKhachHang(string tenKH, DateTime ngaySinh, string sdt)
        {
            var khachHang = new KhachHang
            {
                TenKhachHang = tenKH,
                NgaySinh = ngaySinh,
                SoDienThoai = sdt,
                DiemTichLuy = 0,
                TrangThai = "show"
            };
            QLCHTT.KhachHangs.InsertOnSubmit(khachHang);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool suaKhachHang(string maKHHT, string tenKH, DateTime ngaySinh, string sdt, int diem)
        {
            var kh = QLCHTT.KhachHangs.SingleOrDefault(k => k.MaKhachHang == maKHHT);
            if (kh != null)
            {
                kh.TenKhachHang = tenKH;
                kh.NgaySinh = ngaySinh;
                kh.SoDienThoai = sdt;
                kh.DiemTichLuy = diem;
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaKhachHang(string maKHHT)
        {
            var kh = QLCHTT.KhachHangs.SingleOrDefault(k => k.MaKhachHang == maKHHT);
            if (kh != null)
            {
                kh.TrangThai = "hide";
                QLCHTT.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool kiemTraSDT(string sdt)
        {
            return QLCHTT.KhachHangs.Any(k => k.SoDienThoai == sdt);
        }

        public DataTable locKhachHangAn(int trangthai)
        {
            var query = from kh in QLCHTT.KhachHangs
                        where (trangthai == 0 && kh.TrangThai == "show") || (trangthai == 1 && kh.TrangThai == "hide")
                        select new
                        {
                            kh.MaKhachHang,
                            kh.TenKhachHang,
                            kh.NgaySinh,
                            kh.SoDienThoai,
                            kh.DiemTichLuy
                        };
            return ToDataTable(query.ToList());
        }

        public DataTable search(string str)
        {
            var query = from kh in QLCHTT.KhachHangs
                        where (kh.TenKhachHang.Contains(str) || kh.SoDienThoai.Contains(str)) && kh.TrangThai == "show"
                        select new
                        {
                            kh.MaKhachHang,
                            kh.TenKhachHang,
                            kh.NgaySinh,
                            kh.SoDienThoai,
                            kh.DiemTichLuy
                        };
            return ToDataTable(query.ToList());
        }

        public string layTenKhachHangSDT(string soDienThoai)
        {
            return (from k in QLCHTT.KhachHangs
                    where k.SoDienThoai == soDienThoai
                    select k.TenKhachHang).SingleOrDefault();
        }

        public int layDiemKhachHangSDT(string soDienThoai)
        {
            var result = (from k in QLCHTT.KhachHangs
                    where k.SoDienThoai == soDienThoai
                    select k.DiemTichLuy).SingleOrDefault();
            if (result == null)
            {
                return 0;
            }
            return (int)result;
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
