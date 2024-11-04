using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class BaoHanhDAO
    {
        QLCHTTDataContext QLCHTT;
        public BaoHanhDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll()
        {
            var query = from baoHanh in QLCHTT.BaoHanhs
                        select baoHanh;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaBaoHanh", typeof(string));
            dataTable.Columns.Add("ThoiGianBaoHanh", typeof(int));
            dataTable.Columns.Add("GhiChu", typeof(string));

            foreach (var item in query)
            {
                DataRow row = dataTable.NewRow();
                row["MaBaoHanh"] = item.MaBaoHanh;
                row["ThoiGianBaoHanh"] = item.ThoiGianBaoHanh;
                row["GhiChu"] = item.GhiChu;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
