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
using Xceed.Document.NET;

namespace QLCHDT.GUI.Main
{
    public partial class frmThongKeKhuyenMai : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        public frmThongKeKhuyenMai()
        {
            InitializeComponent();
            khuyenMaiBUS = new KhuyenMaiBUS();
            loadform();
            
            cbThang.SelectedIndex = 0;
            cbNam.SelectedIndex = 0;

        }
        private void loadform()
        {
            DataTable dt = khuyenMaiBUS.thongKeKhuyenMaiAll();
            dtgThongKe.DataSource = dt;

            if (dtgThongKe.Columns.Count > 0)
            {
                dtgThongKe.Columns[0].HeaderText = "Mã khuyến mãi";
                dtgThongKe.Columns[1].HeaderText = "Tên chương trình";
                dtgThongKe.Columns[2].HeaderText = "Số lượng đơn hàng dùng mã";
                dtgThongKe.Columns[3].HeaderText = "Doanh thu";
                dtgThongKe.Columns[4].HeaderText = "Ngày bắt đầu";
                dtgThongKe.Columns[5].HeaderText = "Ngày kết thúc";
            }

            var option = new UIPieOption();
            option.Title.Text = "Thống Kê Tất Cả Chương Trình Khuyến Mãi";
            option.Title.Top = UITopAlignment.Top;
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Bottom;
            option.Legend.Left = UILeftAlignment.Left;

            var series = new UIPieSeries();
            series.Name = "Thống Kê";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            foreach (DataRow row in dt.Rows)
            {
                string tenChuongTrinh = row["TenChuongTrinh"].ToString();
                int doanhThu = int.Parse(row["DoanhThuMangLai"].ToString());
                series.AddData(tenChuongTrinh, doanhThu);
                option.Legend.AddData(tenChuongTrinh);
            }

            option.Series.Clear();
            option.Series.Add(series);

            PieChart.SetOption(option);
        }

        private void dtgThongKe_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgThongKe.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgThongKe.SelectedRows[0];

                // Get the values from the selected row and handle potential nulls
                string maKhuyenMai = selectedRow.Cells["MaKhuyenMai"].Value != null ? selectedRow.Cells["MaKhuyenMai"].Value.ToString() : string.Empty;
                string tenChuongTrinh = selectedRow.Cells["TenChuongTrinh"].Value != null ? selectedRow.Cells["TenChuongTrinh"].Value.ToString() : string.Empty;
        
                int soLuongDon = selectedRow.Cells["SoDonHangSuDung"].Value != null ? int.Parse(selectedRow.Cells["SoDonHangSuDung"].Value.ToString()) : 0;
                int doanhThu = selectedRow.Cells["DoanhThuMangLai"].Value != null ? int.Parse(selectedRow.Cells["DoanhThuMangLai"].Value.ToString()) : 0;

                // Default to DateTime.Now for the start and end dates
                DateTime ngayBatDau = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime ngayBD;
                if (DateTime.TryParse(selectedRow.Cells["NgayBatDau"].Value != null ? selectedRow.Cells["NgayBatDau"].Value.ToString() : null, out ngayBD))
                {
                    ngayBatDau = ngayBD;
                }

                DateTime ngayKetThuc = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                DateTime ngayKT;
                if (DateTime.TryParse(selectedRow.Cells["NgayKetThuc"].Value != null ? selectedRow.Cells["NgayKetThuc"].Value.ToString() : null, out ngayKT))
                {
                    ngayKetThuc = ngayKT;
                }

                // Set the values to the controls
                cbMaKhuyenMai.Text = maKhuyenMai;
                txtTenChuongTrinh.Text = tenChuongTrinh;
                txtSoDon.Text = soLuongDon.ToString();
                txtDoanhThu.Text = doanhThu.ToString();
                dtpNgayKetThuc.Value = ngayKetThuc;
                dptNgayBatDau.Value = ngayBatDau;
            }
        }


        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbThang.Text.Trim()) && !string.IsNullOrEmpty(cbNam.Text.Trim()))
            {
                int thang = int.Parse(cbThang.Text);
                int nam = int.Parse(cbNam.Text);

                DataTable dt = khuyenMaiBUS.thongKeKhuyenMai(thang, nam);
                dtgThongKe.DataSource = dt;

                if (dtgThongKe.Columns.Count > 0)
                {
                    dtgThongKe.Columns[0].HeaderText = "Mã khuyến mãi";
                    dtgThongKe.Columns[1].HeaderText = "Tên chương trình";
                    dtgThongKe.Columns[2].HeaderText = "Số lượng đơn hàng dùng mã";
                    dtgThongKe.Columns[3].HeaderText = "Doanh thu";
                }

                var option = new UIPieOption();
                option.Title.Text = "Thống Kê Chương Trình Khuyến Mãi Tháng + "+thang + "/"+ nam;
                option.Title.Top = UITopAlignment.Top;
                option.Title.Left = UILeftAlignment.Center;
                option.ToolTip.Visible = true;

                option.Legend = new UILegend();
                option.Legend.Orient = UIOrient.Vertical;
                option.Legend.Top = UITopAlignment.Bottom;
                option.Legend.Left = UILeftAlignment.Left;

                var series = new UIPieSeries();
                series.Name = "Thống Kê";
                series.Center = new UICenter(50, 55);
                series.Radius = 70;
                series.Label.Show = true;

                foreach (DataRow row in dt.Rows)
                {
                    string tenChuongTrinh = row["TenChuongTrinh"].ToString();
                    int doanhThu = int.Parse(row["DoanhThuMangLai"].ToString());

                    option.Legend.AddData(tenChuongTrinh);
                    series.AddData(tenChuongTrinh, doanhThu);
                }

                option.Series.Clear();
                option.Series.Add(series);

                PieChart.SetOption(option);
            }
        }

        private void btnReaload_Click(object sender, EventArgs e)
        {
            loadform();
        }
        bool daIn = false;
        private void btnInThongke_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbThang.Text);
            int nam = int.Parse(cbNam.Text);
            if (MessageBox.Show("Bạn có chắc chắn in thống kê tháng "+thang+"/"+nam+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable dt = khuyenMaiBUS.thongKeKhuyenMai(thang, nam);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in hóa đơn.");
                    return;
                }
                else
                {
                    inHoaDonBanHang(thang, nam);
                    daIn = true;
                    if(daIn)
                    {
                        MessageBox.Show("In báo cáo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void inHoaDonBanHang(int thang, int nam)
        {
            DataTable dt = khuyenMaiBUS.inThongKeKhuyenMai(thang, nam);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn.");
                return;
            }
            else
            {
                rptThongKeKhuyenMai rpKhuyenMai = new rptThongKeKhuyenMai();
                rpKhuyenMai.SetDataSource(dt);

                frmInThongKeKhuyenMai inKhuyenMai = new frmInThongKeKhuyenMai();
                inKhuyenMai.crystalReportViewer1.ReportSource = rpKhuyenMai;

                inKhuyenMai.FormClosed += (s, e) =>
                {
                    daIn = true;
                };

                inKhuyenMai.ShowDialog();
            }
        }
    }
}
