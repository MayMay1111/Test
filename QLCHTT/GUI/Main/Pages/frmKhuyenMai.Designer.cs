namespace QLCHTT.GUI.Main.Pages
{
    partial class frmKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.dtgKhuyenMai = new Sunny.UI.UIDataGridView();
            this.uiTableLayoutPanel5 = new Sunny.UI.UITableLayoutPanel();
            this.btnThem = new Sunny.UI.UISymbolButton();
            this.btnXoa = new Sunny.UI.UISymbolButton();
            this.btnReload = new Sunny.UI.UISymbolButton();
            this.btnSua = new Sunny.UI.UISymbolButton();
            this.btnXuatExcel = new Sunny.UI.UISymbolButton();
            this.uiTableLayoutPanel6 = new Sunny.UI.UITableLayoutPanel();
            this.btnTimDanhMuc = new Sunny.UI.UISymbolButton();
            this.txtTimSanPham = new Sunny.UI.UITextBox();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtMaKhuyenMai = new Sunny.UI.UITextBox();
            this.txtTenKhuyenMai = new Sunny.UI.UITextBox();
            this.txtGiaTriKhuyenMai = new Sunny.UI.UITextBox();
            this.txtDonHangToiThieu = new Sunny.UI.UITextBox();
            this.rtxtDieuKien = new Sunny.UI.UIRichTextBox();
            this.rtxtMieuTa = new Sunny.UI.UIRichTextBox();
            this.dptNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new Sunny.UI.UISymbolButton();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhuyenMai)).BeginInit();
            this.uiTableLayoutPanel5.SuspendLayout();
            this.uiTableLayoutPanel6.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.uiTableLayoutPanel1.ColumnCount = 1;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.dtgKhuyenMai, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel5, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel6, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel2, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 4;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.71564F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.990521F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.398104F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.89573F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1297, 844);
            this.uiTableLayoutPanel1.TabIndex = 1;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // dtgKhuyenMai
            // 
            this.dtgKhuyenMai.AllowUserToAddRows = false;
            this.dtgKhuyenMai.AllowUserToDeleteRows = false;
            this.dtgKhuyenMai.AllowUserToResizeColumns = false;
            this.dtgKhuyenMai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKhuyenMai.BackgroundColor = System.Drawing.Color.White;
            this.dtgKhuyenMai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKhuyenMai.EnableHeadersVisualStyles = false;
            this.dtgKhuyenMai.Font = new System.Drawing.Font("Arial", 12F);
            this.dtgKhuyenMai.GridColor = System.Drawing.Color.Black;
            this.dtgKhuyenMai.Location = new System.Drawing.Point(3, 409);
            this.dtgKhuyenMai.MultiSelect = false;
            this.dtgKhuyenMai.Name = "dtgKhuyenMai";
            this.dtgKhuyenMai.ReadOnly = true;
            this.dtgKhuyenMai.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKhuyenMai.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgKhuyenMai.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtgKhuyenMai.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgKhuyenMai.RowTemplate.Height = 28;
            this.dtgKhuyenMai.SelectedIndex = -1;
            this.dtgKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKhuyenMai.Size = new System.Drawing.Size(1291, 432);
            this.dtgKhuyenMai.StripeOddColor = System.Drawing.Color.Silver;
            this.dtgKhuyenMai.TabIndex = 20;
            this.dtgKhuyenMai.SelectionChanged += new System.EventHandler(this.dtgKhuyenMai_SelectionChanged);
            // 
            // uiTableLayoutPanel5
            // 
            this.uiTableLayoutPanel5.ColumnCount = 6;
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66652F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66652F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66652F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66487F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66945F));
            this.uiTableLayoutPanel5.Controls.Add(this.btnThem, 0, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnXoa, 1, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnReload, 3, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnSua, 2, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnXuatExcel, 4, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnThongKe, 5, 0);
            this.uiTableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel5.Location = new System.Drawing.Point(3, 355);
            this.uiTableLayoutPanel5.Name = "uiTableLayoutPanel5";
            this.uiTableLayoutPanel5.RowCount = 1;
            this.uiTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel5.Size = new System.Drawing.Size(1291, 48);
            this.uiTableLayoutPanel5.TabIndex = 19;
            this.uiTableLayoutPanel5.TagString = null;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnThem.FillColorGradient = true;
            this.btnThem.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F);
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(209, 42);
            this.btnThem.Symbol = 61525;
            this.btnThem.SymbolSize = 30;
            this.btnThem.TabIndex = 1;
            this.btnThem.Tag = "";
            this.btnThem.TagString = "";
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnThem.TipsText = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoa.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.FillColorGradient = true;
            this.btnXoa.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F);
            this.btnXoa.Location = new System.Drawing.Point(218, 3);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(209, 42);
            this.btnXoa.Symbol = 559506;
            this.btnXoa.SymbolSize = 30;
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReload.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnReload.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnReload.FillColorGradient = true;
            this.btnReload.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnReload.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnReload.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnReload.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReload.Location = new System.Drawing.Point(648, 3);
            this.btnReload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(209, 42);
            this.btnReload.Symbol = 61473;
            this.btnReload.SymbolSize = 30;
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Làm mới";
            this.btnReload.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSua.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnSua.FillColorGradient = true;
            this.btnSua.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSua.Location = new System.Drawing.Point(433, 3);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(209, 42);
            this.btnSua.Symbol = 557940;
            this.btnSua.SymbolSize = 30;
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatExcel.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnXuatExcel.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnXuatExcel.FillColorGradient = true;
            this.btnXuatExcel.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnXuatExcel.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnXuatExcel.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnXuatExcel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnXuatExcel.Location = new System.Drawing.Point(863, 3);
            this.btnXuatExcel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(209, 42);
            this.btnXuatExcel.Symbol = 362830;
            this.btnXuatExcel.SymbolSize = 30;
            this.btnXuatExcel.TabIndex = 4;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // uiTableLayoutPanel6
            // 
            this.uiTableLayoutPanel6.ColumnCount = 2;
            this.uiTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.05916F));
            this.uiTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94084F));
            this.uiTableLayoutPanel6.Controls.Add(this.btnTimDanhMuc, 1, 0);
            this.uiTableLayoutPanel6.Controls.Add(this.txtTimSanPham, 0, 0);
            this.uiTableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel6.Location = new System.Drawing.Point(3, 296);
            this.uiTableLayoutPanel6.Name = "uiTableLayoutPanel6";
            this.uiTableLayoutPanel6.RowCount = 1;
            this.uiTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel6.Size = new System.Drawing.Size(1291, 53);
            this.uiTableLayoutPanel6.TabIndex = 17;
            this.uiTableLayoutPanel6.TagString = null;
            // 
            // btnTimDanhMuc
            // 
            this.btnTimDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimDanhMuc.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnTimDanhMuc.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnTimDanhMuc.FillColorGradient = true;
            this.btnTimDanhMuc.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnTimDanhMuc.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimDanhMuc.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimDanhMuc.Font = new System.Drawing.Font("Arial", 12F);
            this.btnTimDanhMuc.Location = new System.Drawing.Point(1088, 3);
            this.btnTimDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimDanhMuc.Name = "btnTimDanhMuc";
            this.btnTimDanhMuc.Radius = 1;
            this.btnTimDanhMuc.Size = new System.Drawing.Size(200, 47);
            this.btnTimDanhMuc.Symbol = 61442;
            this.btnTimDanhMuc.SymbolSize = 30;
            this.btnTimDanhMuc.TabIndex = 1;
            this.btnTimDanhMuc.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnTimDanhMuc.Click += new System.EventHandler(this.btnTimDanhMuc_Click);
            // 
            // txtTimSanPham
            // 
            this.txtTimSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTimSanPham.Location = new System.Drawing.Point(4, 5);
            this.txtTimSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimSanPham.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimSanPham.Name = "txtTimSanPham";
            this.txtTimSanPham.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimSanPham.RectColor = System.Drawing.Color.Black;
            this.txtTimSanPham.ShowText = false;
            this.txtTimSanPham.Size = new System.Drawing.Size(1077, 43);
            this.txtTimSanPham.TabIndex = 0;
            this.txtTimSanPham.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimSanPham.Watermark = "";
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 4;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.56236F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.00465F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7103F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.72269F));
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel3, 0, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel4, 0, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel6, 2, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel7, 2, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel8, 2, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel9, 2, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.txtMaKhuyenMai, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.txtTenKhuyenMai, 3, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.txtGiaTriKhuyenMai, 1, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.txtDonHangToiThieu, 3, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.rtxtDieuKien, 1, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.rtxtMieuTa, 3, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.dptNgayBatDau, 1, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.dtpNgayKetThuc, 3, 2);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.uiTableLayoutPanel2.RowCount = 4;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.85816F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.85816F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.37589F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.9078F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(1291, 287);
            this.uiTableLayoutPanel2.TabIndex = 18;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 5);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(182, 56);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Mã khuyến mãi:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(3, 61);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(182, 56);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Giá trị khuyến mãi:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(3, 117);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(182, 46);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Ngày bắt đầu:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(3, 166);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(182, 69);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "Điều kiện áp dụng:";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel6.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(630, 5);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(171, 56);
            this.uiLabel6.TabIndex = 5;
            this.uiLabel6.Text = "Tên chương trình:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel7.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(630, 61);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(171, 56);
            this.uiLabel7.TabIndex = 6;
            this.uiLabel7.Text = "Áp dụng đơn hàng tối thiểu:";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel8.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(630, 117);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(171, 46);
            this.uiLabel8.TabIndex = 7;
            this.uiLabel8.Text = "Ngày kết thúc:";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel9.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(630, 166);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(171, 40);
            this.uiLabel9.TabIndex = 8;
            this.uiLabel9.Text = "Mô tả:";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaKhuyenMai.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(192, 10);
            this.txtMaKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhuyenMai.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaKhuyenMai.ShowText = false;
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(431, 36);
            this.txtMaKhuyenMai.TabIndex = 9;
            this.txtMaKhuyenMai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaKhuyenMai.Watermark = "";
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenKhuyenMai.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(808, 10);
            this.txtTenKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKhuyenMai.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenKhuyenMai.ShowText = false;
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(479, 36);
            this.txtTenKhuyenMai.TabIndex = 10;
            this.txtTenKhuyenMai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenKhuyenMai.Watermark = "";
            // 
            // txtGiaTriKhuyenMai
            // 
            this.txtGiaTriKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTriKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGiaTriKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaTriKhuyenMai.Location = new System.Drawing.Point(192, 66);
            this.txtGiaTriKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaTriKhuyenMai.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGiaTriKhuyenMai.Name = "txtGiaTriKhuyenMai";
            this.txtGiaTriKhuyenMai.Padding = new System.Windows.Forms.Padding(5);
            this.txtGiaTriKhuyenMai.ShowText = false;
            this.txtGiaTriKhuyenMai.Size = new System.Drawing.Size(431, 36);
            this.txtGiaTriKhuyenMai.TabIndex = 11;
            this.txtGiaTriKhuyenMai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGiaTriKhuyenMai.Watermark = "";
            // 
            // txtDonHangToiThieu
            // 
            this.txtDonHangToiThieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonHangToiThieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDonHangToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonHangToiThieu.Location = new System.Drawing.Point(808, 66);
            this.txtDonHangToiThieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonHangToiThieu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDonHangToiThieu.Name = "txtDonHangToiThieu";
            this.txtDonHangToiThieu.Padding = new System.Windows.Forms.Padding(5);
            this.txtDonHangToiThieu.ShowText = false;
            this.txtDonHangToiThieu.Size = new System.Drawing.Size(479, 36);
            this.txtDonHangToiThieu.TabIndex = 12;
            this.txtDonHangToiThieu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDonHangToiThieu.Watermark = "";
            // 
            // rtxtDieuKien
            // 
            this.rtxtDieuKien.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtDieuKien.FillColor = System.Drawing.Color.White;
            this.rtxtDieuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtDieuKien.Location = new System.Drawing.Point(192, 171);
            this.rtxtDieuKien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtDieuKien.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtxtDieuKien.Name = "rtxtDieuKien";
            this.rtxtDieuKien.Padding = new System.Windows.Forms.Padding(2);
            this.rtxtDieuKien.ScrollBarStyleInherited = false;
            this.rtxtDieuKien.ShowText = false;
            this.rtxtDieuKien.Size = new System.Drawing.Size(431, 111);
            this.rtxtDieuKien.TabIndex = 13;
            this.rtxtDieuKien.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtMieuTa
            // 
            this.rtxtMieuTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtMieuTa.FillColor = System.Drawing.Color.White;
            this.rtxtMieuTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtMieuTa.Location = new System.Drawing.Point(808, 171);
            this.rtxtMieuTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtMieuTa.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtxtMieuTa.Name = "rtxtMieuTa";
            this.rtxtMieuTa.Padding = new System.Windows.Forms.Padding(2);
            this.rtxtMieuTa.ScrollBarStyleInherited = false;
            this.rtxtMieuTa.ShowText = false;
            this.rtxtMieuTa.Size = new System.Drawing.Size(479, 111);
            this.rtxtMieuTa.TabIndex = 14;
            this.rtxtMieuTa.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dptNgayBatDau
            // 
            this.dptNgayBatDau.Dock = System.Windows.Forms.DockStyle.Top;
            this.dptNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptNgayBatDau.Location = new System.Drawing.Point(191, 120);
            this.dptNgayBatDau.Name = "dptNgayBatDau";
            this.dptNgayBatDau.Size = new System.Drawing.Size(433, 35);
            this.dptNgayBatDau.TabIndex = 15;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(807, 120);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(481, 35);
            this.dtpNgayKetThuc.TabIndex = 16;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnThongKe.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnThongKe.FillColorGradient = true;
            this.btnThongKe.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnThongKe.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKe.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 12F);
            this.btnThongKe.Location = new System.Drawing.Point(1078, 3);
            this.btnThongKe.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(210, 42);
            this.btnThongKe.Symbol = 61568;
            this.btnThongKe.SymbolSize = 35;
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1297, 844);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "frmKhuyenMai";
            this.Text = "frmKhuyenMai";
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhuyenMai)).EndInit();
            this.uiTableLayoutPanel5.ResumeLayout(false);
            this.uiTableLayoutPanel6.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIDataGridView dtgKhuyenMai;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel5;
        private Sunny.UI.UISymbolButton btnThem;
        private Sunny.UI.UISymbolButton btnXoa;
        private Sunny.UI.UISymbolButton btnReload;
        private Sunny.UI.UISymbolButton btnSua;
        private Sunny.UI.UISymbolButton btnXuatExcel;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel6;
        private Sunny.UI.UISymbolButton btnTimDanhMuc;
        private Sunny.UI.UITextBox txtTimSanPham;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtMaKhuyenMai;
        private Sunny.UI.UITextBox txtTenKhuyenMai;
        private Sunny.UI.UITextBox txtGiaTriKhuyenMai;
        private Sunny.UI.UITextBox txtDonHangToiThieu;
        private Sunny.UI.UIRichTextBox rtxtDieuKien;
        private Sunny.UI.UIRichTextBox rtxtMieuTa;
        private System.Windows.Forms.DateTimePicker dptNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private Sunny.UI.UISymbolButton btnThongKe;
    }
}