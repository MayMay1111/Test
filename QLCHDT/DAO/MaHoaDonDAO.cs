using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class MaHoaDonDAO
    {
        SQLConnect connect;
        public MaHoaDonDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "SELECT * FROM GiaoHang";
            return connect.getDataTable(query);
        }
    }
}
