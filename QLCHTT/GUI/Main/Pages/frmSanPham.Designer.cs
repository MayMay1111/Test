namespace QLCHTT.GUI.Main.Pages
{
    partial class frmSanPham
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
            this.dtgSanPham = new Sunny.UI.UIDataGridView();
            this.uiTableLayoutPanel5 = new Sunny.UI.UITableLayoutPanel();
            this.btnThemSanPham = new Sunny.UI.UISymbolButton();
            this.btnXoaSanPham = new Sunny.UI.UISymbolButton();
            this.btnReloadSanPham = new Sunny.UI.UISymbolButton();
            this.btnSuaDanhMuc = new Sunny.UI.UISymbolButton();
            this.btnExportSanPham = new Sunny.UI.UISymbolButton();
            this.uiTableLayoutPanel6 = new Sunny.UI.UITableLayoutPanel();
            this.btnTimDanhMuc = new Sunny.UI.UISymbolButton();
            this.txtTimSanPham = new Sunny.UI.UITextBox();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtSanPham = new Sunny.UI.UITextBox();
            this.txtGiaBan = new Sunny.UI.UITextBox();
            this.txtXuatXu = new Sunny.UI.UITextBox();
            this.rtxtMoTa = new Sunny.UI.UIRichTextBox();
            this.cbBaoHanh = new Sunny.UI.UIComboBox();
            this.cbNhaCungCap = new Sunny.UI.UIComboBox();
            this.cbDanhMuc = new Sunny.UI.UIComboBox();
            this.dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
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
            this.uiTableLayoutPanel1.Controls.Add(this.dtgSanPham, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel5, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel6, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel2, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 4;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.04572F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.151231F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.447831F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23798F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1223, 853);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.AllowUserToAddRows = false;
            this.dtgSanPham.AllowUserToDeleteRows = false;
            this.dtgSanPham.AllowUserToResizeColumns = false;
            this.dtgSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dtgSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSanPham.EnableHeadersVisualStyles = false;
            this.dtgSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.dtgSanPham.GridColor = System.Drawing.Color.Black;
            this.dtgSanPham.Location = new System.Drawing.Point(3, 435);
            this.dtgSanPham.MultiSelect = false;
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.ReadOnly = true;
            this.dtgSanPham.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgSanPham.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtgSanPham.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgSanPham.RowTemplate.Height = 28;
            this.dtgSanPham.SelectedIndex = -1;
            this.dtgSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSanPham.Size = new System.Drawing.Size(1217, 415);
            this.dtgSanPham.StripeOddColor = System.Drawing.Color.Silver;
            this.dtgSanPham.TabIndex = 20;
            this.dtgSanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgSanPham_CellFormatting);
            this.dtgSanPham.SelectionChanged += new System.EventHandler(this.dtgSanPham_SelectionChanged);
            // 
            // uiTableLayoutPanel5
            // 
            this.uiTableLayoutPanel5.ColumnCount = 5;
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66542F));
            this.uiTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel5.Controls.Add(this.btnThemSanPham, 0, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnXoaSanPham, 1, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnReloadSanPham, 3, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnSuaDanhMuc, 2, 0);
            this.uiTableLayoutPanel5.Controls.Add(this.btnExportSanPham, 4, 0);
            this.uiTableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel5.Location = new System.Drawing.Point(3, 380);
            this.uiTableLayoutPanel5.Name = "uiTableLayoutPanel5";
            this.uiTableLayoutPanel5.RowCount = 1;
            this.uiTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel5.Size = new System.Drawing.Size(1217, 49);
            this.uiTableLayoutPanel5.TabIndex = 19;
            this.uiTableLayoutPanel5.TagString = null;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnThemSanPham.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnThemSanPham.FillColorGradient = true;
            this.btnThemSanPham.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnThemSanPham.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemSanPham.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.btnThemSanPham.Location = new System.Drawing.Point(3, 3);
            this.btnThemSanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(237, 43);
            this.btnThemSanPham.Symbol = 61525;
            this.btnThemSanPham.SymbolSize = 30;
            this.btnThemSanPham.TabIndex = 1;
            this.btnThemSanPham.Tag = "";
            this.btnThemSanPham.TagString = "";
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnThemSanPham.TipsText = "Thêm";
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoaSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnXoaSanPham.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnXoaSanPham.FillColorGradient = true;
            this.btnXoaSanPham.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnXoaSanPham.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaSanPham.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.btnXoaSanPham.Location = new System.Drawing.Point(246, 3);
            this.btnXoaSanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(237, 43);
            this.btnXoaSanPham.Symbol = 559506;
            this.btnXoaSanPham.SymbolSize = 30;
            this.btnXoaSanPham.TabIndex = 2;
            this.btnXoaSanPham.Text = "Xóa";
            this.btnXoaSanPham.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // btnReloadSanPham
            // 
            this.btnReloadSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReloadSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReloadSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnReloadSanPham.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnReloadSanPham.FillColorGradient = true;
            this.btnReloadSanPham.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnReloadSanPham.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnReloadSanPham.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnReloadSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.btnReloadSanPham.Location = new System.Drawing.Point(732, 3);
            this.btnReloadSanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReloadSanPham.Name = "btnReloadSanPham";
            this.btnReloadSanPham.Size = new System.Drawing.Size(237, 43);
            this.btnReloadSanPham.Symbol = 61473;
            this.btnReloadSanPham.SymbolSize = 30;
            this.btnReloadSanPham.TabIndex = 5;
            this.btnReloadSanPham.Text = "Làm mới";
            this.btnReloadSanPham.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnReloadSanPham.Click += new System.EventHandler(this.btnReloadDanhMuc_Click);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuaDanhMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnSuaDanhMuc.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnSuaDanhMuc.FillColorGradient = true;
            this.btnSuaDanhMuc.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnSuaDanhMuc.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaDanhMuc.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaDanhMuc.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(489, 3);
            this.btnSuaDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(237, 43);
            this.btnSuaDanhMuc.Symbol = 557940;
            this.btnSuaDanhMuc.SymbolSize = 30;
            this.btnSuaDanhMuc.TabIndex = 3;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnExportSanPham
            // 
            this.btnExportSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportSanPham.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnExportSanPham.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnExportSanPham.FillColorGradient = true;
            this.btnExportSanPham.FillHoverColor = System.Drawing.Color.RoyalBlue;
            this.btnExportSanPham.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportSanPham.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExportSanPham.Location = new System.Drawing.Point(975, 3);
            this.btnExportSanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExportSanPham.Name = "btnExportSanPham";
            this.btnExportSanPham.Size = new System.Drawing.Size(239, 43);
            this.btnExportSanPham.Symbol = 362830;
            this.btnExportSanPham.SymbolSize = 30;
            this.btnExportSanPham.TabIndex = 4;
            this.btnExportSanPham.Text = "Xuất Excel";
            this.btnExportSanPham.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btnExportSanPham.Click += new System.EventHandler(this.btnExportDanhMuc_Click);
            // 
            // uiTableLayoutPanel6
            // 
            this.uiTableLayoutPanel6.ColumnCount = 2;
            this.uiTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.05916F));
            this.uiTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94084F));
            this.uiTableLayoutPanel6.Controls.Add(this.btnTimDanhMuc, 1, 0);
            this.uiTableLayoutPanel6.Controls.Add(this.txtTimSanPham, 0, 0);
            this.uiTableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel6.Location = new System.Drawing.Point(3, 319);
            this.uiTableLayoutPanel6.Name = "uiTableLayoutPanel6";
            this.uiTableLayoutPanel6.RowCount = 1;
            this.uiTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel6.Size = new System.Drawing.Size(1217, 55);
            this.uiTableLayoutPanel6.TabIndex = 17;
            this.uiTableLayoutPanel6.TagString = null;
            // 
            // btnTimDanhMuc
            // 
            this.btnTimDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimDanhMuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnTimDanhMuc.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.btnTimDanhMuc.FillColorGradient = true;
            this.btnTimDanhMuc.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(157)))));
            this.btnTimDanhMuc.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimDanhMuc.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimDanhMuc.Font = new System.Drawing.Font("Arial", 12F);
            this.btnTimDanhMuc.Location = new System.Drawing.Point(1025, 3);
            this.btnTimDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimDanhMuc.Name = "btnTimDanhMuc";
            this.btnTimDanhMuc.Size = new System.Drawing.Size(189, 49);
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
            this.txtTimSanPham.Size = new System.Drawing.Size(1014, 45);
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
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel3, 0, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel4, 0, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel5, 0, 4);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel7, 2, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel8, 2, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel9, 2, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.txtSanPham, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.txtGiaBan, 3, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.txtXuatXu, 3, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.rtxtMoTa, 1, 4);
            this.uiTableLayoutPanel2.Controls.Add(this.cbBaoHanh, 1, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.cbNhaCungCap, 1, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.cbDanhMuc, 3, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.dtpNgaySanXuat, 1, 3);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.uiTableLayoutPanel2.RowCount = 5;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.19355F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.32258F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(1217, 310);
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
            this.uiLabel1.Size = new System.Drawing.Size(197, 46);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Sản phẩm:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(3, 51);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(197, 46);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Bảo hành:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(3, 97);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(197, 46);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Danh mục:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(3, 143);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(197, 40);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "Ngày sản xuất:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel5.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(3, 186);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(197, 103);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "Mô tả:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel7.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(609, 51);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(154, 46);
            this.uiLabel7.TabIndex = 6;
            this.uiLabel7.Text = "Danh mục:";
            this.uiLabel7.Click += new System.EventHandler(this.uiLabel7_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel8.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(609, 97);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(154, 46);
            this.uiLabel8.TabIndex = 7;
            this.uiLabel8.Text = "Giá bán:";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel9.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(609, 143);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(154, 40);
            this.uiLabel9.TabIndex = 8;
            this.uiLabel9.Text = "Xuất xứ:";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSanPham.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSanPham.Location = new System.Drawing.Point(207, 10);
            this.txtSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSanPham.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Padding = new System.Windows.Forms.Padding(5);
            this.txtSanPham.RectColor = System.Drawing.Color.Black;
            this.txtSanPham.ShowText = false;
            this.txtSanPham.Size = new System.Drawing.Size(395, 36);
            this.txtSanPham.TabIndex = 9;
            this.txtSanPham.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSanPham.Watermark = "";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGiaBan.Font = new System.Drawing.Font("Arial", 12F);
            this.txtGiaBan.Location = new System.Drawing.Point(770, 102);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaBan.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Padding = new System.Windows.Forms.Padding(5);
            this.txtGiaBan.RectColor = System.Drawing.Color.Black;
            this.txtGiaBan.ShowText = false;
            this.txtGiaBan.Size = new System.Drawing.Size(443, 36);
            this.txtGiaBan.TabIndex = 11;
            this.txtGiaBan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGiaBan.Watermark = "";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXuatXu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtXuatXu.Font = new System.Drawing.Font("Arial", 12F);
            this.txtXuatXu.Location = new System.Drawing.Point(770, 148);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXuatXu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Padding = new System.Windows.Forms.Padding(5);
            this.txtXuatXu.RectColor = System.Drawing.Color.Black;
            this.txtXuatXu.ShowText = false;
            this.txtXuatXu.Size = new System.Drawing.Size(443, 33);
            this.txtXuatXu.TabIndex = 12;
            this.txtXuatXu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtXuatXu.Watermark = "";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtMoTa.FillColor = System.Drawing.Color.White;
            this.rtxtMoTa.Font = new System.Drawing.Font("Arial", 12F);
            this.rtxtMoTa.Location = new System.Drawing.Point(207, 191);
            this.rtxtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtMoTa.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Padding = new System.Windows.Forms.Padding(2);
            this.rtxtMoTa.RectColor = System.Drawing.Color.Black;
            this.rtxtMoTa.ScrollBarStyleInherited = false;
            this.rtxtMoTa.ShowText = false;
            this.rtxtMoTa.Size = new System.Drawing.Size(395, 93);
            this.rtxtMoTa.TabIndex = 14;
            this.rtxtMoTa.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBaoHanh
            // 
            this.cbBaoHanh.DataSource = null;
            this.cbBaoHanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbBaoHanh.FillColor = System.Drawing.Color.White;
            this.cbBaoHanh.Font = new System.Drawing.Font("Arial", 12F);
            this.cbBaoHanh.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbBaoHanh.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbBaoHanh.Location = new System.Drawing.Point(207, 56);
            this.cbBaoHanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaoHanh.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbBaoHanh.Name = "cbBaoHanh";
            this.cbBaoHanh.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbBaoHanh.RectColor = System.Drawing.Color.Black;
            this.cbBaoHanh.Size = new System.Drawing.Size(395, 36);
            this.cbBaoHanh.SymbolSize = 24;
            this.cbBaoHanh.TabIndex = 15;
            this.cbBaoHanh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbBaoHanh.Watermark = "";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.DataSource = null;
            this.cbNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbNhaCungCap.FillColor = System.Drawing.Color.White;
            this.cbNhaCungCap.Font = new System.Drawing.Font("Arial", 12F);
            this.cbNhaCungCap.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbNhaCungCap.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbNhaCungCap.Location = new System.Drawing.Point(207, 102);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNhaCungCap.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbNhaCungCap.RectColor = System.Drawing.Color.Black;
            this.cbNhaCungCap.Size = new System.Drawing.Size(395, 36);
            this.cbNhaCungCap.SymbolSize = 24;
            this.cbNhaCungCap.TabIndex = 16;
            this.cbNhaCungCap.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNhaCungCap.Watermark = "";
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DataSource = null;
            this.cbDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDanhMuc.FillColor = System.Drawing.Color.White;
            this.cbDanhMuc.Font = new System.Drawing.Font("Arial", 12F);
            this.cbDanhMuc.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbDanhMuc.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbDanhMuc.Location = new System.Drawing.Point(770, 56);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDanhMuc.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDanhMuc.RectColor = System.Drawing.Color.Black;
            this.cbDanhMuc.Size = new System.Drawing.Size(443, 36);
            this.cbDanhMuc.SymbolSize = 24;
            this.cbDanhMuc.TabIndex = 17;
            this.cbDanhMuc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDanhMuc.Watermark = "";
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(206, 146);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(397, 30);
            this.dtpNgaySanXuat.TabIndex = 18;
            // 
            // frmSanPham
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1223, 888);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "frmSanPham";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 363564;
            this.Text = "Danh sách sản phẩm";
            this.TitleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(142)))));
            this.Initialize += new System.EventHandler(this.frmSanPham_Initialize);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            this.uiTableLayoutPanel5.ResumeLayout(false);
            this.uiTableLayoutPanel6.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel6;
        private Sunny.UI.UISymbolButton btnTimDanhMuc;
        private Sunny.UI.UITextBox txtTimSanPham;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtSanPham;
        private Sunny.UI.UITextBox txtGiaBan;
        private Sunny.UI.UITextBox txtXuatXu;
        private Sunny.UI.UIRichTextBox rtxtMoTa;
        private Sunny.UI.UIComboBox cbBaoHanh;
        private Sunny.UI.UIComboBox cbNhaCungCap;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel5;
        private Sunny.UI.UISymbolButton btnThemSanPham;
        private Sunny.UI.UISymbolButton btnXoaSanPham;
        private Sunny.UI.UISymbolButton btnReloadSanPham;
        private Sunny.UI.UISymbolButton btnSuaDanhMuc;
        private Sunny.UI.UISymbolButton btnExportSanPham;
        private Sunny.UI.UIDataGridView dtgSanPham;
        private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox cbDanhMuc;
    }
}