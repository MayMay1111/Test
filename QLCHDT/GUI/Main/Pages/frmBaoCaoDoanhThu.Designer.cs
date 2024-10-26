namespace QLCHDT.GUI.Pages
{
    partial class frmBaoCaoDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_DTTNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.grDoanhThuNam = new Sunny.UI.UIGroupBox();
            this.tongdt = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.chart_DTTTuan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new Sunny.UI.UISymbolButton();
            this.grDoanhThuThang = new Sunny.UI.UIGroupBox();
            this.tuan4 = new Sunny.UI.UILabel();
            this.tuan2 = new Sunny.UI.UILabel();
            this.tuan3 = new Sunny.UI.UILabel();
            this.tuan1 = new Sunny.UI.UILabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDoanhThuTheoNam = new Sunny.UI.UISymbolButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DTTNam)).BeginInit();
            this.grDoanhThuNam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DTTTuan)).BeginInit();
            this.grDoanhThuThang.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_DTTNam
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_DTTNam.ChartAreas.Add(chartArea1);
            this.chart_DTTNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart_DTTNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chart_DTTNam.Legends.Add(legend1);
            this.chart_DTTNam.Location = new System.Drawing.Point(3, 370);
            this.chart_DTTNam.Name = "chart_DTTNam";
            this.chart_DTTNam.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.chart_DTTNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_DTTNam.Series.Add(series1);
            this.chart_DTTNam.Size = new System.Drawing.Size(926, 356);
            this.chart_DTTNam.TabIndex = 1;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(0, 35);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1865, 54);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "THỐNG KÊ DOANH THU";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // grDoanhThuNam
            // 
            this.grDoanhThuNam.BackColor = System.Drawing.Color.White;
            this.grDoanhThuNam.Controls.Add(this.tongdt);
            this.grDoanhThuNam.Controls.Add(this.uiLabel2);
            this.grDoanhThuNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.grDoanhThuNam.FillColor = System.Drawing.Color.White;
            this.grDoanhThuNam.Font = new System.Drawing.Font("Arial", 12F);
            this.grDoanhThuNam.Location = new System.Drawing.Point(4, 41);
            this.grDoanhThuNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grDoanhThuNam.MinimumSize = new System.Drawing.Size(1, 1);
            this.grDoanhThuNam.Name = "grDoanhThuNam";
            this.grDoanhThuNam.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grDoanhThuNam.Size = new System.Drawing.Size(455, 297);
            this.grDoanhThuNam.TabIndex = 3;
            this.grDoanhThuNam.Text = null;
            this.grDoanhThuNam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tongdt
            // 
            this.tongdt.Font = new System.Drawing.Font("Arial", 12F);
            this.tongdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tongdt.Location = new System.Drawing.Point(22, 79);
            this.tongdt.Name = "tongdt";
            this.tongdt.Size = new System.Drawing.Size(207, 36);
            this.tongdt.TabIndex = 1;
            this.tongdt.Text = "uiLabel3";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(22, 32);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(221, 38);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Tổng doanh thu";
            // 
            // chart_DTTTuan
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_DTTTuan.ChartAreas.Add(chartArea2);
            this.chart_DTTTuan.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart_DTTTuan.Legends.Add(legend2);
            this.chart_DTTTuan.Location = new System.Drawing.Point(3, 3);
            this.chart_DTTTuan.Name = "chart_DTTTuan";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_DTTTuan.Series.Add(series2);
            this.chart_DTTTuan.Size = new System.Drawing.Size(926, 361);
            this.chart_DTTTuan.TabIndex = 4;
            this.chart_DTTTuan.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(457, 35);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXem.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnXem.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnXem.FillColorGradient = true;
            this.btnXem.Font = new System.Drawing.Font("Arial", 12F);
            this.btnXem.Location = new System.Drawing.Point(466, 3);
            this.btnXem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(458, 32);
            this.btnXem.Symbol = 61568;
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem doanh thu tháng";
            this.btnXem.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // grDoanhThuThang
            // 
            this.grDoanhThuThang.Controls.Add(this.tuan4);
            this.grDoanhThuThang.Controls.Add(this.tuan2);
            this.grDoanhThuThang.Controls.Add(this.tuan3);
            this.grDoanhThuThang.Controls.Add(this.tuan1);
            this.grDoanhThuThang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grDoanhThuThang.FillColor = System.Drawing.Color.White;
            this.grDoanhThuThang.Font = new System.Drawing.Font("Arial", 12F);
            this.grDoanhThuThang.Location = new System.Drawing.Point(4, 43);
            this.grDoanhThuThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grDoanhThuThang.MinimumSize = new System.Drawing.Size(1, 1);
            this.grDoanhThuThang.Name = "grDoanhThuThang";
            this.grDoanhThuThang.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grDoanhThuThang.Size = new System.Drawing.Size(455, 296);
            this.grDoanhThuThang.TabIndex = 7;
            this.grDoanhThuThang.Text = "uiGroupBox2";
            this.grDoanhThuThang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tuan4
            // 
            this.tuan4.Font = new System.Drawing.Font("Arial", 12F);
            this.tuan4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tuan4.Location = new System.Drawing.Point(22, 170);
            this.tuan4.Name = "tuan4";
            this.tuan4.Size = new System.Drawing.Size(435, 23);
            this.tuan4.TabIndex = 3;
            this.tuan4.Text = "uiLabel7";
            // 
            // tuan2
            // 
            this.tuan2.Font = new System.Drawing.Font("Arial", 12F);
            this.tuan2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tuan2.Location = new System.Drawing.Point(22, 87);
            this.tuan2.Name = "tuan2";
            this.tuan2.Size = new System.Drawing.Size(435, 23);
            this.tuan2.TabIndex = 2;
            this.tuan2.Text = "uiLabel6";
            // 
            // tuan3
            // 
            this.tuan3.Font = new System.Drawing.Font("Arial", 12F);
            this.tuan3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tuan3.Location = new System.Drawing.Point(22, 129);
            this.tuan3.Name = "tuan3";
            this.tuan3.Size = new System.Drawing.Size(435, 23);
            this.tuan3.TabIndex = 1;
            this.tuan3.Text = "uiLabel5";
            // 
            // tuan1
            // 
            this.tuan1.Font = new System.Drawing.Font("Arial", 12F);
            this.tuan1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tuan1.Location = new System.Drawing.Point(22, 45);
            this.tuan1.Name = "tuan1";
            this.tuan1.Size = new System.Drawing.Size(435, 23);
            this.tuan1.TabIndex = 0;
            this.tuan1.Text = "uiLabel4";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(457, 35);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // btnDoanhThuTheoNam
            // 
            this.btnDoanhThuTheoNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThuTheoNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThuTheoNam.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDoanhThuTheoNam.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnDoanhThuTheoNam.FillColorGradient = true;
            this.btnDoanhThuTheoNam.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDoanhThuTheoNam.Location = new System.Drawing.Point(466, 3);
            this.btnDoanhThuTheoNam.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDoanhThuTheoNam.Name = "btnDoanhThuTheoNam";
            this.btnDoanhThuTheoNam.Size = new System.Drawing.Size(458, 30);
            this.btnDoanhThuTheoNam.Symbol = 61568;
            this.btnDoanhThuTheoNam.TabIndex = 9;
            this.btnDoanhThuTheoNam.Text = "Xem doanh thu năm";
            this.btnDoanhThuTheoNam.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnDoanhThuTheoNam.Click += new System.EventHandler(this.btnDoanhThuTheoNam_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart_DTTTuan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart_DTTNam, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1865, 734);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grDoanhThuThang, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(935, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71428F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(927, 361);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grDoanhThuNam, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDoanhThuTheoNam, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(935, 370);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.997231F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.00277F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(927, 361);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1865, 823);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uiLabel1);
            this.ExtendSymbolOffset = new System.Drawing.Point(0, 30);
            this.Name = "frmBaoCaoDoanhThu";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Text = "Báo cáo doanh thu";
            this.TitleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.Initialize += new System.EventHandler(this.frmBaoCaoDoanhThu_Initialize);
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DTTNam)).EndInit();
            this.grDoanhThuNam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DTTTuan)).EndInit();
            this.grDoanhThuThang.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DTTNam;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox grDoanhThuNam;
        private Sunny.UI.UILabel tongdt;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DTTTuan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Sunny.UI.UISymbolButton btnXem;
        private Sunny.UI.UIGroupBox grDoanhThuThang;
        private Sunny.UI.UILabel tuan4;
        private Sunny.UI.UILabel tuan2;
        private Sunny.UI.UILabel tuan3;
        private Sunny.UI.UILabel tuan1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Sunny.UI.UISymbolButton btnDoanhThuTheoNam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}