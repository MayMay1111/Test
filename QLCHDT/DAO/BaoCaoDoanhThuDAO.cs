using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    internal class BaoCaoDoanhThuDAO
    {
        SQLConnect connect;
        string connectionString = SQLConnect.connectString;
        public BaoCaoDoanhThuDAO()
        {
            connect = new SQLConnect();
        }

        public Dictionary<int, int> LoadDataToChart(int selectedYear)
        {
            string query = @"
                            SELECT 
                                MONTH(NgayLapHoaDon) AS Month,
                                SUM(TongTien) AS TotalAmount
                            FROM 
                                HoaDon
                            WHERE
                                YEAR(NgayLapHoaDon) = @SelectedYear
                            GROUP BY 
                                MONTH(NgayLapHoaDon)
                            ORDER BY 
                                MONTH(NgayLapHoaDon)";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedYear", selectedYear); // Thêm tham số cho năm
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            Dictionary<int, int> monthTotals = new Dictionary<int, int>();

            foreach (DataRow row in dataTable.Rows)
            {
                int month = Convert.ToInt32(row["Month"]);
                int totalAmount = Convert.ToInt32(row["TotalAmount"]);
                monthTotals[month] = totalAmount;
            }

            return monthTotals;
        }

        public Dictionary<int, int> GetWeeklyTotals(int month, int year)
        {
            Dictionary<int, int> weeklyTotals = new Dictionary<int, int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    ((DAY(NgayLapHoaDon) - 1) / 7 + 1) AS Week,
                                    SUM(TongTien) AS Total
                                 FROM 
                                    HoaDon
                                 WHERE 
                                    MONTH(NgayLapHoaDon) = @Month 
                                    AND YEAR(NgayLapHoaDon) = @Year
                                 GROUP BY 
                                    ((DAY(NgayLapHoaDon) - 1) / 7 + 1)
                                 ORDER BY 
                                    Week";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int week = reader.GetInt32(0);
                            int total = reader.GetInt32(1);
                            weeklyTotals[week] = total;
                        }
                    }
                }
            }

            return weeklyTotals;
        }
    }
}
