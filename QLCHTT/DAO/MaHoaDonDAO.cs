using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    internal class MaHoaDonDAO
    {
        QLCHTTDataContext QLCHTT;
        public MaHoaDonDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll()
        {
            var result = from gh in QLCHTT.GiaoHangs
                         select gh;
            return ToDataTableUtils.ToDataTable(result.ToList());
        }
    }
}
