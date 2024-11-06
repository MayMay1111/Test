using QLCHTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    public class MaHoaDonBUS
    {
        MaHoaDonDAO maHoaDonDAO;
        public MaHoaDonBUS()
        {
            maHoaDonDAO = new MaHoaDonDAO();
        }
        public DataTable getAll()
        {
            return maHoaDonDAO.getAll();
        }
    }
}
