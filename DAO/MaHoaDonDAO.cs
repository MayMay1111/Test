using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    public class MaHoaDonDAO
    {
        QLCHTTDataContext QLCHTT;
        public MaHoaDonDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll()
        {
            var result = from hd in QLCHTT.GiaoHangs
                         select hd;
            return ToDataTableUtils.ToDataTable(result.ToList());
        }
    }
}
