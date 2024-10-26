using NPOI.HSSF.Record;
using NPOI.SS.Formula.Functions;
using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class KhachHangDAO
    {
        SQLConnect db = new SQLConnect();
        public static string strKhachHang = "select MaKhachHang, TenKhachHang, NgaySinh, SoDienThoai, DiemTichLuy from KhachHang where TrangThai = 'show'";
        DataTable dtKhachHang = new DataTable();

        public void checkPrimaryKey()
        {
            dtKhachHang = db.getDataTable(strKhachHang);
            DataColumn[] key = new DataColumn[1];
            key[0] = dtKhachHang.Columns[0];
            dtKhachHang.PrimaryKey = key;
        }
        public DataTable AllKhachHang()
        {
            dtKhachHang = db.getDataTable(strKhachHang);
            return dtKhachHang;
        }
        public bool themKhachHang(string tenKH, string ngaySinh, string sdt)
        {
            string query = "INSERT INTO KhachHang (TenKhachHang, NgaySinh, SoDienThoai, DiemTichLuy, TrangThai) " +
                           "VALUES (N'" + tenKH + "', '" + ngaySinh + "', '" + sdt + "', 0, 'show')";
            return db.ExecuteNonQuery(query);
        }

        public bool suaKhachHang(string maKHHT, string tenKH, string ngaySinh, string sdt, string diem)
        {
            string query = "UPDATE KhachHang SET TenKhachHang = N'" + tenKH + "', NgaySinh = '" + ngaySinh +
                           "', SoDienThoai = '" + sdt + "', DiemTichLuy = '" + diem +
                           "' WHERE MaKhachHang = '" + maKHHT + "'";
            return db.ExecuteNonQuery(query);
        }

        public bool xoaKhachHang(string maKHHT, string tenKH, string ngaySinh, string sdt, string diem)
        {
            string query = "UPDATE KhachHang SET TenKhachHang = N'" + tenKH + "', NgaySinh = '" + ngaySinh +
                           "', SoDienThoai = '" + sdt + "', DiemTichLuy = '" + diem +
                           "', TrangThai = 'hide' WHERE MaKhachHang = '" + maKHHT + "'";
            return db.ExecuteNonQuery(query);
        }

        public bool hienKhachHang(string maKHHT, string tenKH, string ngaySinh, string sdt, string diem)
        {
            string query = "UPDATE KhachHang SET TenKhachHang = N'" + tenKH + "', NgaySinh = '" + ngaySinh +
                           "', SoDienThoai = '" + sdt + "', DiemTichLuy = '" + diem +
                           "', TrangThai = 'show' WHERE MaKhachHang = '" + maKHHT + "'";
            return db.ExecuteNonQuery(query);
        }

        public bool kiemTraSDT(string sdt)
        {
            string sql = "select count(*) from KhachHang where SoDienThoai = '" + sdt + "'";
            int check = (int)db.GetData(sql);
            return check > 0;
        }

        public DataTable locKhachHangAn(int trangthai)
        {
            if (trangthai == 0)
            {
                dtKhachHang = db.getDataTable(strKhachHang);
                return dtKhachHang;
            }
            if (trangthai == 1)
            {
                string sql = "select MaKhachHang, TenKhachHang, NgaySinh, SoDienThoai, DiemTichLuy from KhachHang where TrangThai = 'hide'";
                dtKhachHang = db.getDataTable(sql);
                return dtKhachHang;
            }
            return dtKhachHang;
        }

        public DataTable search(string str)
        {
            string sql = "select MaKhachHang, TenKhachHang, NgaySinh, SoDienThoai, DiemTichLuy from KhachHang " +
                         "where (TenKhachHang like N'%" + str + "%' OR SoDienThoai LIKE '%" + str + "%') " +
                         "and TrangThai = 'show'";
            dtKhachHang = db.getDataTable(sql);
            return dtKhachHang;
        }

        public string layTenKhachHangSDT(string soDienThoai)
        {
            try
            {
                string query = "SELECT TenKhachHang FROM KhachHang WHERE SoDienThoai = '" + soDienThoai + "'";
                string kq = (string)db.GetData(query);
                return kq;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string layMaKhachHangSDT(string soDienThoai)
        {
            string query = "SELECT MaKhachHang FROM KhachHang WHERE SoDienThoai = '" + soDienThoai + "'";
            string kq = (string)db.GetData(query);
            return kq;
        }

        public int layDiemTichLuyKhachHangSDT(string soDienThoai)
        {
            string query = "SELECT DiemTichLuy FROM KhachHang WHERE SoDienThoai = '" + soDienThoai + "'";
            int kq = (int)db.GetData(query);
            return kq;
        }

        public bool addKhachHang(string tenKhachHang, DateTime ngaySinh, string soDienThoai)
        {
            string query = "INSERT INTO KhachHang (TenKhachHang, NgaySinh, SoDienThoai, TrangThai) " +
                           "values (N'" + tenKhachHang + "','" + ngaySinh.ToString("yyyy-MM-dd") + "','" + soDienThoai + "', 'show')";
            return db.ExecuteNonQuery(query);
        }

        public string layTenKhachHang(string ma)
        {
            string query = "SELECT TenKhachHang FROM KhachHang WHERE MaKhachHang = '" + ma + "'";
            string kq = (string)db.GetData(query);
            return kq;
        }


    }
}
