using System;
using QLCHTT.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLCHTT.BUS
{
    internal class BaoCaoDoanhThuBUS
    {
        BaoCaoDoanhThuDAO baocao;
        public BaoCaoDoanhThuBUS()
        {
            baocao = new BaoCaoDoanhThuDAO();
        }
        public Dictionary<int, int> LoadDataToChart(int selectedYear)
        {
            return baocao.LoadDataToChart(selectedYear);
        }
        public Dictionary<int, int> GetWeeklyTotals(int month, int year)
        {
            return baocao.GetWeeklyTotals(month, year);
        }
    }
}
