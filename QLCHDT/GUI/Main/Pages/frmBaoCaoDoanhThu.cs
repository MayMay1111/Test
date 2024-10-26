using QLCHDT.BUS;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLCHDT.GUI.Pages
{
    public partial class frmBaoCaoDoanhThu : UIPage
    {
        BaoCaoDoanhThuBUS baocaoBUS = new BaoCaoDoanhThuBUS();
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            int selectedYear = dateTimePicker2.Value.Year;
            Dictionary<int, int> monthTotals = baocaoBUS.LoadDataToChart(selectedYear);
            bieuDoDoanhThuTheoNam(monthTotals);
            UpdateChart2();
        }
        private void bieuDoDoanhThuTheoNam(Dictionary<int, int> monthTotals)
        {
            // Xóa điểm dữ liệu cũ
            chart_DTTNam.Series[0].Points.Clear();
            chart_DTTNam.Series[0]["PointWidth"] = "0.4";

            // Tính tổng doanh thu của năm
            int totalYearAmount = 0;

            for (int month = 1; month <= 12; month++)
            {
                int totalAmount = monthTotals.ContainsKey(month) ? monthTotals[month] : 0;
                totalYearAmount += totalAmount; // Cộng vào tổng doanh thu năm

                chart_DTTNam.Series[0].Points.AddXY("Tháng " + month, totalAmount);
                var point = chart_DTTNam.Series[0].Points[chart_DTTNam.Series[0].Points.Count - 1];
                point.Label = totalAmount.ToString("#,##0");
                point.LabelAngle = 0;
                point.LabelForeColor = Color.Black;
            }

            // Thiết lập giới hạn trục Y
            chart_DTTNam.ChartAreas[0].AxisY.Minimum = 0;
            chart_DTTNam.ChartAreas[0].AxisY.Maximum = 50000000;

            // Định dạng trục Y
            chart_DTTNam.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0 VNĐ";

            // Thiết lập trục X
            chart_DTTNam.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart_DTTNam.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_DTTNam.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;

            // Đặt khoảng cách giữa các nhãn trên trục X
            chart_DTTNam.ChartAreas[0].AxisX.Interval = 1.8;

            // Thiết lập nhãn tùy chỉnh trên trục X
            chart_DTTNam.ChartAreas[0].AxisX.CustomLabels.Clear();
            for (int month = 1; month <= 12; month++)
            {
                chart_DTTNam.ChartAreas[0].AxisX.CustomLabels.Add(month - 0.5, month + 1, "Tháng " + month);
            }

            // Làm mới biểu đồ để hiển thị
            chart_DTTNam.Invalidate();

            // Cập nhật Label tongdt
            int selectedYear = dateTimePicker2.Value.Year; // Giả sử bạn đang sử dụng DateTimePicker2 để chọn năm
            grDoanhThuNam.Text = "Tổng doanh thu năm " + selectedYear;
            tongdt.Text = totalYearAmount.ToString("#,##0 VNĐ");
        }

        private void UpdateChart2()
        {
            int selectedMonth = dateTimePicker1.Value.Month;
            int selectedYear = dateTimePicker1.Value.Year;

            chart_DTTTuan.Series[0].Points.Clear();

            Dictionary<int, int> weeklyTotals = baocaoBUS.GetWeeklyTotals(selectedMonth, selectedYear);

            Label[] labels = { tuan1, tuan2, tuan3, tuan4 };
            grDoanhThuThang.Text = "Doanh thu tháng " + selectedMonth;

            for (int week = 1; week <= 4; week++)
            {
                int totalAmount = weeklyTotals.ContainsKey(week) ? weeklyTotals[week] : 0;
                chart_DTTTuan.Series[0].Points.AddXY("Tuần " + week, totalAmount);
                labels[week - 1].Text = "Doanh thu tuần " + week + ": " + totalAmount.ToString("#,##0 VNĐ");

                var point = chart_DTTTuan.Series[0].Points[chart_DTTTuan.Series[0].Points.Count - 1];
                point.Label = totalAmount.ToString("#,##0 VNĐ");
                point.LabelForeColor = Color.Black;
            }

            chart_DTTTuan.ChartAreas[0].AxisY.Minimum = 0;
            chart_DTTTuan.ChartAreas[0].AxisY.Maximum = 10000000;
            chart_DTTTuan.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0 VNĐ";

            chart_DTTTuan.ChartAreas[0].AxisX.Interval = 1;
            chart_DTTTuan.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart_DTTTuan.ChartAreas[0].AxisX.IsLabelAutoFit = false;

            chart_DTTTuan.Invalidate();
        }









        private void frmBaoCaoDoanhThu_Initialize(object sender, EventArgs e)
        {

        }

        private void uiBarChart1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            UpdateChart2();
        }

        private void btnDoanhThuTheoNam_Click(object sender, EventArgs e)
        {
            int selectedYear = dateTimePicker2.Value.Year;

            Dictionary<int, int> monthTotals = baocaoBUS.LoadDataToChart(selectedYear);

            bieuDoDoanhThuTheoNam(monthTotals);
        }
    }
}
