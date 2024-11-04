using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class BaoCaoDoanhThuDAO
    {
        QLCHTTDataContext QLCHTT;
        public BaoCaoDoanhThuDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }

        public Dictionary<int, int> LoadDataToChart(int selectedYear)
        {
            var data = QLCHTT.HoaDons
            .Where(h => h.NgayLapHoaDon.Value.Year == selectedYear)
            .GroupBy(h => h.NgayLapHoaDon.Value.Month)
            .Select(g => new
            {
                Month = g.Key,
                TotalAmount = g.Sum(h => h.TongTien) ?? 0
            })
            .OrderBy(g => g.Month)
            .ToList();

            return data.ToDictionary(d => d.Month, d => d.TotalAmount);
        }

        public Dictionary<int, int> GetWeeklyTotals(int month, int year)
        {
                var weeklyTotals = QLCHTT.HoaDons
                    .Where(h => h.NgayLapHoaDon.Value.Month == month && h.NgayLapHoaDon.Value.Year == year)
                    .GroupBy(h => (h.NgayLapHoaDon.Value.Day - 1) / 7 + 1)
                    .Select(g => new
                    {
                        Week = g.Key,
                        Total = g.Sum(h => h.TongTien) ?? 0
                    })
                    .OrderBy(g => g.Week)
                    .ToList();

                return weeklyTotals.ToDictionary(g => g.Week, g => g.Total);
        }
    }
}
