using QLCHDT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.BUS
{
    public class InPhieuGiaoBUS
    {
        InPhieuGiaoDAO inPhieuGiaoDAO;
        public InPhieuGiaoBUS()
        {
            inPhieuGiaoDAO = new InPhieuGiaoDAO();
        }
        public DataTable inPhieuGiao(string maPhieu)
        {
            return inPhieuGiaoDAO.inPhieuGiao(maPhieu);
        }
    }
}
