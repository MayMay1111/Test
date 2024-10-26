using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class BaoHanhDAO
    {
        SQLConnect connect;
        public BaoHanhDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll()
        {
            string query = "SELECT * FROM BaoHanh";
            return connect.getDataTable(query);
        }
    }
}
