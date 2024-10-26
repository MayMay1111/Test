using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class KhuyenMaiDAO
    {
        SQLConnect connect;
        public KhuyenMaiDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "SELECT * FROM KhuyenMai";
            return connect.getDataTable(query);

        }
        public DataTable GetKhuyenMaiHopLe(int tongTien, DateTime ngayHienTai)
        {
            string query = string.Format(@"SELECT MaKhuyenMai, TenChuongTrinh 
                                    FROM KhuyenMai 
                                    WHERE '{0}' BETWEEN NgayBatDau AND NgayKetThuc 
                                    AND GiaTriDonHangToiThieu <= {1} OR MaKhuyenMai = 'KHONG'",
                                            ngayHienTai.ToString("yyyy-MM-dd"), tongTien);

            return connect.getDataTable(query);
        }

        public float giaTriKhuyenMai(string maKhuyenMai)
        {
            float giaTriKhuyenMai = 0;

            string query = string.Format("SELECT GiaTriKhuyenMai FROM KhuyenMai WHERE MaKhuyenMai = '{0}'", maKhuyenMai);
            object result = connect.GetData(query);
            if (result != null && result != DBNull.Value)
            {
                if (float.TryParse(result.ToString(), out giaTriKhuyenMai))
                {
                    return giaTriKhuyenMai;
                }
            }
            return giaTriKhuyenMai;
        }

        public string moTaKhuyenMai(string maKhuyenMai)
        {
            string query = string.Format("SELECT MoTa FROM KhuyenMai WHERE MaKhuyenMai = '{0}'", maKhuyenMai);
            string kq = (string)connect.GetData(query);
            return kq;
        }

        public bool checkTrungMa(string maKhuyenMai)
        {
            string query = string.Format("SELECT COUNT(*) FROM KhuyenMai WHERE MaKhuyenMai = '{0}'", maKhuyenMai);
            int kq = Convert.ToInt32(connect.GetData(query));
            return kq > 0;
        }

        public bool addKhuyenMai(string maKhuyenMai, string tenChuongTrinh, float giaTriKhuyenMai, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien, int giaTriToiThieu)
        {
            string query = string.Format("INSERT INTO KhuyenMai (MaKhuyenMai, TenChuongTrinh, GiaTriKhuyenMai, MoTa, NgayBatDau, NgayKetThuc, DieuKienApDung, GiaTriDonHangToiThieu) " +
                                          "VALUES (N'{0}', N'{1}', {2}, N'{3}', '{4}', '{5}', N'{6}', {7})",
                                          maKhuyenMai, tenChuongTrinh, giaTriKhuyenMai, moTa, ngayBatDau, ngayKetThuc, dieuKien, giaTriToiThieu);
            return connect.ExecuteNonQuery(query);
        }

        public bool updateKhuyenMai(string maKhuyenMai, string tenChuongTrinh, float giaTriKhuyenMai, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string dieuKien, int giaTriToiThieu)
        {
            string query = string.Format("UPDATE KhuyenMai SET TenChuongTrinh = N'{0}', GiaTriKhuyenMai = {1}, MoTa = N'{2}', NgayBatDau = '{3}', NgayKetThuc = '{4}', DieuKienApDung = N'{5}', GiaTriDonHangToiThieu = {6} " +
                                          "WHERE MaKhuyenMai = '{7}'",
                                          tenChuongTrinh, giaTriKhuyenMai, moTa, ngayBatDau, ngayKetThuc, dieuKien, giaTriToiThieu, maKhuyenMai);
            return connect.ExecuteNonQuery(query);
        }

        public bool deleteKhuyenMai(string maKhuyenMai)
        {
            string query = string.Format("DELETE FROM KhuyenMai WHERE MaKhuyenMai = '{0}'", maKhuyenMai);
            return connect.ExecuteNonQuery(query);
        }

        public DataTable searchKhuyenMai(string key)
        {
            string query = string.Format("SELECT * FROM KhuyenMai WHERE MaKhuyenMai LIKE '%{0}%' OR TenChuongTrinh LIKE N'%{0}%'", key);
            return connect.getDataTable(query);
        }

        public DataTable thongKeKhuyenMai(int thang, int nam)
        {
            string query = string.Format(@"SELECT 
                                    KM.MaKhuyenMai AS MaKhuyenMai,
                                    KM.TenChuongTrinh AS TenChuongTrinh,
                                    COUNT(HD.MaHoaDon) AS SoDonHangSuDung,
                                    SUM(HD.TongTien) AS DoanhThuMangLai,
                                    KM.NgayBatDau AS NgayBatDau,
                                    KM.NgayKetThuc AS NgayKetThuc
                                   FROM 
                                    HoaDon HD
                                   INNER JOIN 
                                    KhuyenMai KM ON HD.MaKhuyenMai = KM.MaKhuyenMai
                                   WHERE 
                                    MONTH(HD.NgayLapHoaDon) = {0} AND YEAR(HD.NgayLapHoaDon) = {1}
                                   GROUP BY 
                                    KM.MaKhuyenMai, KM.TenChuongTrinh, KM.NgayBatDau, KM.NgayKetThuc", thang, nam);
            return connect.getDataTable(query);
        }

        public DataTable thongKeKhuyenMaiAll()
        {
            string query = @"SELECT 
                        KM.MaKhuyenMai AS MaKhuyenMai,
                        KM.TenChuongTrinh AS TenChuongTrinh,
                        COUNT(HD.MaHoaDon) AS SoDonHangSuDung,
                        COALESCE(SUM(HD.TongTien), 0) AS DoanhThuMangLai,
                        KM.NgayBatDau AS NgayBatDau,
                        KM.NgayKetThuc AS NgayKetThuc
                    FROM 
                        KhuyenMai KM
                    LEFT JOIN 
                        HoaDon HD ON KM.MaKhuyenMai = HD.MaKhuyenMai
                    GROUP BY 
                        KM.MaKhuyenMai, KM.TenChuongTrinh, KM.NgayBatDau, KM.NgayKetThuc;";
            return connect.getDataTable(query);
        }

        public DataTable inThongKeKhuyenMai(int thang, int nam)
        {
            string query = string.Format(@"SELECT 
                                    KM.MaKhuyenMai AS MaKhuyenMai,
                                    KM.TenChuongTrinh AS TenChuongTrinh,
                                    COUNT(HD.MaHoaDon) AS SoDonHangSuDung,
                                    SUM(HD.TongTien) AS DoanhThuMangLai,
                                    CAST(KM.NgayBatDau AS DATE) AS NgayBatDau,
                                    CAST(KM.NgayKetThuc AS DATE) AS NgayKetThuc, 
                                    CAST({0} AS VARCHAR(4)) AS Thang,
                                    CAST({1} AS VARCHAR(4)) AS Nam
                                   FROM 
                                    HoaDon HD
                                   INNER JOIN 
                                    KhuyenMai KM ON HD.MaKhuyenMai = KM.MaKhuyenMai
                                   WHERE 
                                    MONTH(HD.NgayLapHoaDon) = {0} AND YEAR(HD.NgayLapHoaDon) = {1}
                                   GROUP BY 
                                    KM.MaKhuyenMai, KM.TenChuongTrinh, KM.NgayBatDau, KM.NgayKetThuc", thang, nam);
            return connect.getDataTable(query);
        }

    }
}
