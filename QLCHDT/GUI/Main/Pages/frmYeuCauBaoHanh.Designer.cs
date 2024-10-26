namespace QLCHDT.GUI.Pages
{
    partial class frmYeuCauBaoHanh
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.dtgBaoHanh = new Sunny.UI.UIDataGridView();
            this.uiTableLayoutPanel5 = new Sunny.UI.UITableLayoutPanel();
            this.btnThemYeuCauBH = new Sunny.UI.UISymbolButton();
            this.btnXoaYeuCauBH = new Sunny.UI.UISymbolButton();
            this.btnReloadYCBH = new Sunny.UI.UISymbolButton();
            this.btnSuaYeuCauBH = new Sunny.UI.UISymbolButton();
            this.btnExportYCBH = new Sunny.UI.UISymbolButton();
            this.uiTableLayoutPanel6 = new Sunny.UI.UITableLayoutPanel();
            this.btnTimDanhMuc = new Sunny.UI.UISymbolButton();
            this.txtTimSanPham = new Sunny.UI.UITextBox();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.cbSanPham = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.cbMaHoaDon = new Sunny.UI.UIComboBox();
            this.txtMaVach = new Sunny.UI.UITextBox();
            this.txtNgayMua = new Sunny.UI.UITextBox();
            this.cbTrangThai = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.rtxtLyDo = new Sunny.UI.UIRichTextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtNgayYeuCau = new Sunny.UI.UITextBox();
            this.errorHanBaoHanh = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInDonBaoHanh = new Sunny.UI.UISymbolButton();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoHanh)).BeginInit();
            this.uiTableLayoutPanel5.SuspendLayout();
            this.uiTableLayoutPanel6.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHanBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.uiTableLayoutPanel1.ColumnCount = 1;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.dtgBaoHanh, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel5, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel6, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel2, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 4;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.10368F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.354515F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.18394F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1234, 897);
            this.uiTableLayoutPanel1.TabIndex = 1;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // dtgBaoHanh
            // 
            this.dtgBaoHanh.AllowUserToAddRows = false;
            this.dtgBaoHanh.AllowUserToDeleteRows = false;
            this.dtgBaoHanh.AllowUserToResizeColumns = false;
            this.dtgBaoHanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgBaoHanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBaoHanh.BackgroundColor = System.Drawing.Color.White;
            this.dtgBaoHanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaoHanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBaoHanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBaoHanh.EnableHeadersVisualStyles = false;
            this.dtgBaoHanh.Font = new System.Drawing.Font("Arial", 12F);
            this.dtgBaoHanh.GridColor = System.Drawing.Color.Black;
            this.dtgBaoHanh.Location = new System.Drawing.Point(3, 404);
            this.dtgBaoHanh.MultiSelect = false;
            this.dtgBaoHanh.Name = "dtgBaoHanh";
            this.dtgBaoHanh.ReadOnly = true;
            this.dtgBaoHanh.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaoHanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgBaoHanh.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtgBaoHanh.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgBaoHanh.RowTemplate.Height = 28;
            this.dtgBaoHanh.SelectedIndex = -1;
            this.dtgBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBaoHanh.Size = new System.Drawing.Size(1228, 490);
            this.dtgBaoHanh.StripeOddColor = System.Drawing.Color.Silver;
            this.dtgBaoHanh.TabIndex = 20;
            this.dtgBaoHanh.SelectionChanged += new System.EventHandler(this.dtgBaoHanh_SelectionChanged);
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
            this.uiTableLayoutPanel5.Controls.Add(this.btnThemYeuCauBH, 0, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnXoaYeuCauBH, 1, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnReloadYCBH, 3, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnSuaYeuCauBH, 2, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnExportYCBH, 4, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnInDonBaoHanh, 5, 0);
            this.uiTableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel5.Location = new System.Drawing.Point(3, 339);
            this.uiTableLayoutPanel5.Name = "uiTableLayoutPanel5";
            this.uiTableLayoutPanel5.RowCount = 1;
            this.uiTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel5.Size = new System.Drawing.Size(1228, 59);
            this.uiTableLayoutPanel5.TabIndex = 19;
            this.uiTableLayoutPanel5.TagString = null;
            // 
            // btnThemYeuCauBH
            // 
            this.btnThemYeuCauBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemYeuCauBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemYeuCauBH.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnThemYeuCauBH.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnThemYeuCauBH.FillColorGradient = true;
            this.btnThemYeuCauBH.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnThemYeuCauBH.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemYeuCauBH.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemYeuCauBH.Font = new System.Drawing.Font("Arial", 12F);
            this.btnThemYeuCauBH.Location = new System.Drawing.Point(3, 3);
            this.btnThemYeuCauBH.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemYeuCauBH.Name = "btnThemYeuCauBH";
            this.btnThemYeuCauBH.Size = new System.Drawing.Size(198, 53);
            this.btnThemYeuCauBH.Symbol = 61525;
            this.btnThemYeuCauBH.SymbolSize = 30;
            this.btnThemYeuCauBH.TabIndex = 1;
            this.btnThemYeuCauBH.Tag = "";
            this.btnThemYeuCauBH.TagString = "";
            this.btnThemYeuCauBH.Text = "Thêm";
            this.btnThemYeuCauBH.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnThemYeuCauBH.TipsText = "Thêm";
            this.btnThemYeuCauBH.Click += new System.EventHandler(this.btnThemYeuCauBH_Click);
            // 
            // btnXoaYeuCauBH
            // 
            this.btnXoaYeuCauBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaYeuCauBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoaYeuCauBH.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnXoaYeuCauBH.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnXoaYeuCauBH.FillColorGradient = true;
            this.btnXoaYeuCauBH.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnXoaYeuCauBH.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaYeuCauBH.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaYeuCauBH.Font = new System.Drawing.Font("Arial", 12F);
            this.btnXoaYeuCauBH.Location = new System.Drawing.Point(207, 3);
            this.btnXoaYeuCauBH.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaYeuCauBH.Name = "btnXoaYeuCauBH";
            this.btnXoaYeuCauBH.Size = new System.Drawing.Size(198, 53);
            this.btnXoaYeuCauBH.Symbol = 559506;
            this.btnXoaYeuCauBH.SymbolSize = 30;
            this.btnXoaYeuCauBH.TabIndex = 2;
            this.btnXoaYeuCauBH.Text = "Xóa";
            this.btnXoaYeuCauBH.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnXoaYeuCauBH.Click += new System.EventHandler(this.btnXoaYeuCauBH_Click);
            // 
            // btnReloadYCBH
            // 
            this.btnReloadYCBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadYCBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReloadYCBH.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnReloadYCBH.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnReloadYCBH.FillColorGradient = true;
            this.btnReloadYCBH.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnReloadYCBH.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnReloadYCBH.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnReloadYCBH.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReloadYCBH.Location = new System.Drawing.Point(615, 3);
            this.btnReloadYCBH.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReloadYCBH.Name = "btnReloadYCBH";
            this.btnReloadYCBH.Size = new System.Drawing.Size(198, 53);
            this.btnReloadYCBH.Symbol = 61473;
            this.btnReloadYCBH.SymbolSize = 30;
            this.btnReloadYCBH.TabIndex = 5;
            this.btnReloadYCBH.Text = "Làm mới";
            this.btnReloadYCBH.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnReloadYCBH.Click += new System.EventHandler(this.btnReloadYCBH_Click);
            // 
            // btnSuaYeuCauBH
            // 
            this.btnSuaYeuCauBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaYeuCauBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuaYeuCauBH.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSuaYeuCauBH.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnSuaYeuCauBH.FillColorGradient = true;
            this.btnSuaYeuCauBH.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnSuaYeuCauBH.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaYeuCauBH.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaYeuCauBH.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSuaYeuCauBH.Location = new System.Drawing.Point(411, 3);
            this.btnSuaYeuCauBH.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSuaYeuCauBH.Name = "btnSuaYeuCauBH";
            this.btnSuaYeuCauBH.Size = new System.Drawing.Size(198, 53);
            this.btnSuaYeuCauBH.Symbol = 557940;
            this.btnSuaYeuCauBH.SymbolSize = 30;
            this.btnSuaYeuCauBH.TabIndex = 3;
            this.btnSuaYeuCauBH.Text = "Sửa";
            this.btnSuaYeuCauBH.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnSuaYeuCauBH.Click += new System.EventHandler(this.btnSuaYeuCauBH_Click);
            // 
            // btnExportYCBH
            // 
            this.btnExportYCBH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportYCBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportYCBH.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnExportYCBH.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnExportYCBH.FillColorGradient = true;
            this.btnExportYCBH.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnExportYCBH.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportYCBH.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportYCBH.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExportYCBH.Location = new System.Drawing.Point(819, 3);
            this.btnExportYCBH.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExportYCBH.Name = "btnExportYCBH";
            this.btnExportYCBH.Size = new System.Drawing.Size(198, 53);
            this.btnExportYCBH.Symbol = 362830;
            this.btnExportYCBH.SymbolSize = 30;
            this.btnExportYCBH.TabIndex = 4;
            this.btnExportYCBH.Text = "Xuất Excel";
            this.btnExportYCBH.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnExportYCBH.Click += new System.EventHandler(this.btnExportYCBH_Click);
            // 
            // uiTableLayoutPanel6
            // 
            this.uiTableLayoutPanel6.ColumnCount = 2;
            this.uiTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.05916F));
            this.uiTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94084F));
            this.uiTableLayoutPanel6.Controls.Add(this.btnTimDanhMuc, 1, 0);
            this.uiTableLayoutPanel6.Controls.Add(this.txtTimSanPham, 0, 0);
            this.uiTableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel6.Location = new System.Drawing.Point(3, 282);
            this.uiTableLayoutPanel6.Name = "uiTableLayoutPanel6";
            this.uiTableLayoutPanel6.RowCount = 1;
            this.uiTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel6.Size = new System.Drawing.Size(1228, 51);
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
            this.btnTimDanhMuc.Location = new System.Drawing.Point(1035, 3);
            this.btnTimDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimDanhMuc.Name = "btnTimDanhMuc";
            this.btnTimDanhMuc.Radius = 1;
            this.btnTimDanhMuc.Size = new System.Drawing.Size(190, 45);
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
            this.txtTimSanPham.Size = new System.Drawing.Size(1024, 41);
            this.txtTimSanPham.TabIndex = 0;
            this.txtTimSanPham.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimSanPham.Watermark = "";
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 4;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.76253F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11422F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22925F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.894F));
            this.uiTableLayoutPanel2.Controls.Add(this.cbSanPham, 1, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel2, 2, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel3, 0, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel4, 2, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel7, 2, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.cbMaHoaDon, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.txtMaVach, 3, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.txtNgayMua, 3, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.cbTrangThai, 3, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel6, 2, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.rtxtLyDo, 3, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel5, 0, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.txtNgayYeuCau, 1, 2);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 4;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(1228, 273);
            this.uiTableLayoutPanel2.TabIndex = 18;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // cbSanPham
            // 
            this.cbSanPham.DataSource = null;
            this.cbSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSanPham.FillColor = System.Drawing.Color.White;
            this.cbSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.cbSanPham.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSanPham.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSanPham.Location = new System.Drawing.Point(209, 54);
            this.cbSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSanPham.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSanPham.Size = new System.Drawing.Size(398, 39);
            this.cbSanPham.SymbolSize = 24;
            this.cbSanPham.TabIndex = 15;
            this.cbSanPham.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSanPham.Watermark = "";
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(199, 49);
            this.uiLabel1.TabIndex = 19;
            this.uiLabel1.Text = "Mã hóa đơn:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(614, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uiLabel2.Size = new System.Drawing.Size(156, 49);
            this.uiLabel2.TabIndex = 20;
            this.uiLabel2.Text = "Ngày mua:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(3, 49);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(199, 49);
            this.uiLabel3.TabIndex = 21;
            this.uiLabel3.Text = "Sản phẩm:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(614, 49);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uiLabel4.Size = new System.Drawing.Size(156, 49);
            this.uiLabel4.TabIndex = 22;
            this.uiLabel4.Text = "Mã vạch:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel7.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(614, 98);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uiLabel7.Size = new System.Drawing.Size(156, 49);
            this.uiLabel7.TabIndex = 25;
            this.uiLabel7.Text = "Trạng thái:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMaHoaDon
            // 
            this.cbMaHoaDon.DataSource = null;
            this.cbMaHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbMaHoaDon.FillColor = System.Drawing.Color.White;
            this.cbMaHoaDon.Font = new System.Drawing.Font("Arial", 12F);
            this.cbMaHoaDon.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbMaHoaDon.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbMaHoaDon.Location = new System.Drawing.Point(209, 5);
            this.cbMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMaHoaDon.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbMaHoaDon.Name = "cbMaHoaDon";
            this.cbMaHoaDon.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbMaHoaDon.Size = new System.Drawing.Size(398, 39);
            this.cbMaHoaDon.SymbolSize = 24;
            this.cbMaHoaDon.TabIndex = 27;
            this.cbMaHoaDon.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbMaHoaDon.Watermark = "";
            this.cbMaHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbMaHoaDon_SelectedIndexChanged);
            // 
            // txtMaVach
            // 
            this.txtMaVach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVach.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaVach.Enabled = false;
            this.txtMaVach.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMaVach.Location = new System.Drawing.Point(777, 54);
            this.txtMaVach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaVach.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaVach.ShowText = false;
            this.txtMaVach.Size = new System.Drawing.Size(447, 39);
            this.txtMaVach.TabIndex = 29;
            this.txtMaVach.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaVach.Watermark = "";
            // 
            // txtNgayMua
            // 
            this.txtNgayMua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayMua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNgayMua.Enabled = false;
            this.txtNgayMua.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNgayMua.Location = new System.Drawing.Point(777, 5);
            this.txtNgayMua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayMua.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNgayMua.Name = "txtNgayMua";
            this.txtNgayMua.Padding = new System.Windows.Forms.Padding(5);
            this.txtNgayMua.ShowText = false;
            this.txtNgayMua.Size = new System.Drawing.Size(447, 39);
            this.txtNgayMua.TabIndex = 31;
            this.txtNgayMua.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNgayMua.Watermark = "";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DataSource = null;
            this.cbTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTrangThai.FillColor = System.Drawing.Color.White;
            this.cbTrangThai.Font = new System.Drawing.Font("Arial", 12F);
            this.cbTrangThai.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đã hoàn tất"});
            this.cbTrangThai.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Location = new System.Drawing.Point(777, 103);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTrangThai.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTrangThai.Size = new System.Drawing.Size(447, 39);
            this.cbTrangThai.SymbolSize = 24;
            this.cbTrangThai.TabIndex = 32;
            this.cbTrangThai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTrangThai.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel6.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(614, 147);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uiLabel6.Size = new System.Drawing.Size(156, 47);
            this.uiLabel6.TabIndex = 24;
            this.uiLabel6.Text = "Lý do:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtLyDo
            // 
            this.rtxtLyDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtLyDo.FillColor = System.Drawing.Color.White;
            this.rtxtLyDo.Font = new System.Drawing.Font("Arial", 12F);
            this.rtxtLyDo.Location = new System.Drawing.Point(777, 152);
            this.rtxtLyDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtLyDo.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtxtLyDo.Name = "rtxtLyDo";
            this.rtxtLyDo.Padding = new System.Windows.Forms.Padding(2);
            this.rtxtLyDo.ScrollBarStyleInherited = false;
            this.rtxtLyDo.ShowText = false;
            this.rtxtLyDo.Size = new System.Drawing.Size(447, 116);
            this.rtxtLyDo.TabIndex = 26;
            this.rtxtLyDo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(3, 98);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(199, 49);
            this.uiLabel5.TabIndex = 33;
            this.uiLabel5.Text = "Ngày yêu cầu:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgayYeuCau
            // 
            this.txtNgayYeuCau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayYeuCau.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNgayYeuCau.Enabled = false;
            this.txtNgayYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNgayYeuCau.Location = new System.Drawing.Point(209, 103);
            this.txtNgayYeuCau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayYeuCau.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNgayYeuCau.Name = "txtNgayYeuCau";
            this.txtNgayYeuCau.Padding = new System.Windows.Forms.Padding(5);
            this.txtNgayYeuCau.ShowText = false;
            this.txtNgayYeuCau.Size = new System.Drawing.Size(398, 39);
            this.txtNgayYeuCau.TabIndex = 34;
            this.txtNgayYeuCau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNgayYeuCau.Watermark = "";
            // 
            // errorHanBaoHanh
            // 
            this.errorHanBaoHanh.ContainerControl = this;
            // 
            // btnInDonBaoHanh
            // 
            this.btnInDonBaoHanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInDonBaoHanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInDonBaoHanh.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnInDonBaoHanh.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnInDonBaoHanh.FillColorGradient = true;
            this.btnInDonBaoHanh.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnInDonBaoHanh.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnInDonBaoHanh.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnInDonBaoHanh.Font = new System.Drawing.Font("Arial", 12F);
            this.btnInDonBaoHanh.Location = new System.Drawing.Point(1023, 3);
            this.btnInDonBaoHanh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnInDonBaoHanh.Name = "btnInDonBaoHanh";
            this.btnInDonBaoHanh.Size = new System.Drawing.Size(202, 53);
            this.btnInDonBaoHanh.Symbol = 57580;
            this.btnInDonBaoHanh.SymbolSize = 30;
            this.btnInDonBaoHanh.TabIndex = 7;
            this.btnInDonBaoHanh.Text = "In Đơn";
            this.btnInDonBaoHanh.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnInDonBaoHanh.Click += new System.EventHandler(this.btnInDonBaoHanh_Click);
            // 
            // frmYeuCauBaoHanh
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1234, 932);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "frmYeuCauBaoHanh";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 358740;
            this.Text = "Quản lý bảo hành";
            this.TitleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.Initialize += new System.EventHandler(this.frmBaoHanh_Initialize);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoHanh)).EndInit();
            this.uiTableLayoutPanel5.ResumeLayout(false);
            this.uiTableLayoutPanel6.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorHanBaoHanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIDataGridView dtgBaoHanh;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel5;
        private Sunny.UI.UISymbolButton btnThemYeuCauBH;
        private Sunny.UI.UISymbolButton btnXoaYeuCauBH;
        private Sunny.UI.UISymbolButton btnReloadYCBH;
        private Sunny.UI.UISymbolButton btnSuaYeuCauBH;
        private Sunny.UI.UISymbolButton btnExportYCBH;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel6;
        private Sunny.UI.UISymbolButton btnTimDanhMuc;
        private Sunny.UI.UITextBox txtTimSanPham;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIComboBox cbSanPham;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIRichTextBox rtxtLyDo;
        private Sunny.UI.UIComboBox cbMaHoaDon;
        private Sunny.UI.UITextBox txtMaVach;
        private Sunny.UI.UITextBox txtNgayMua;
        private Sunny.UI.UIComboBox cbTrangThai;
        private System.Windows.Forms.ErrorProvider errorHanBaoHanh;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtNgayYeuCau;
        private Sunny.UI.UISymbolButton btnInDonBaoHanh;
    }
}