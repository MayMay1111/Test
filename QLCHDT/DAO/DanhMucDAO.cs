using Microsoft.SqlServer.Server;
using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class DanhMucDAO
    {
        private SQLConnect connect;

        public DanhMucDAO()
        {
            connect = new SQLConnect();
        }

        public DataTable getAll()
        {
            string query = "SELECT * FROM DANHMUC";
            return connect.getDataTable(query);
        }

        public bool addDanhMuc(string tenDanhMuc, string moTa)
        {
            string query = string.Format("INSERT INTO DanhMuc (TenDanhMuc, MoTa) VALUES (N'{0}', N'{1}')", tenDanhMuc, moTa);
            return connect.ExecuteNonQuery(query);
        }

        public bool updateDanhMuc(int maDanhMuc, string tenDanhMuc, string moTa)
        {
            string query = string.Format("UPDATE DanhMuc SET TenDanhMuc = N'{0}', MoTa = N'{1}' WHERE MaDanhMuc = {2}", tenDanhMuc, moTa, maDanhMuc);
            return connect.ExecuteNonQuery(query);
        }

        public bool deleteDanhMuc(int maDanhMuc)
        {
            string query = string.Format("DELETE FROM DanhMuc WHERE MaDanhMuc = {0}", maDanhMuc);
            return connect.ExecuteNonQuery(query);
        }

        public DataTable searchDanhMuc(string key)
        {
            string query = string.Format("SELECT * FROM DanhMuc WHERE TenDanhMuc LIKE N'%{0}%' OR MaDanhMuc LIKE '%{0}%'", key);
            return connect.getDataTable(query);
        }

        public int tongSanPham(int maDanhMuc)
        {
            string query = string.Format(@"
        SELECT COUNT(sp.MaSanPham) AS TongSoSanPham
        FROM 
            DanhMuc dm
        LEFT JOIN 
            SanPham sp
        ON 
            dm.MaDanhMuc = sp.MaDanhMuc
        WHERE 
            dm.MaDanhMuc = {0}
        GROUP BY 
            dm.MaDanhMuc", maDanhMuc);
            object result = connect.GetData(query);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }



    }
}
