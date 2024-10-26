using QLCHDT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.BUS
{
    public class InHoaDonBUS
    {
        InHoaDonDAO inHoaDonDAO;
        public InHoaDonBUS()
        {

            inHoaDonDAO = new InHoaDonDAO();
        }
        public DataTable inHoaDon(string maHD)
        {
            return inHoaDonDAO.inHoaDon(maHD);
        }
    }
}
