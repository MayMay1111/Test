namespace QLCHTT.GUI.Main.Pages
{
    partial class frmTonKho
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
            this.dgvtonkho = new Sunny.UI.UIDataGridView();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txttensp = new Sunny.UI.UITextBox();
            this.txtsoluongnhap = new Sunny.UI.UITextBox();
            this.txtsoluongcon = new Sunny.UI.UITextBox();
            this.txtsoluongxuat = new Sunny.UI.UITextBox();
            this.uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            this.txttim = new Sunny.UI.UITextBox();
            this.btntim = new Sunny.UI.UISymbolButton();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtonkho)).BeginInit();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.uiTableLayoutPanel4.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 1;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.dgvtonkho, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel2, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel4, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel3, 0, 1);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 4;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1110, 595);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // dgvtonkho
            // 
            this.dgvtonkho.AllowUserToAddRows = false;
            this.dgvtonkho.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvtonkho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtonkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtonkho.BackgroundColor = System.Drawing.Color.White;
            this.dgvtonkho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtonkho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtonkho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtonkho.EnableHeadersVisualStyles = false;
            this.dgvtonkho.Font = new System.Drawing.Font("Arial", 12F);
            this.dgvtonkho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvtonkho.Location = new System.Drawing.Point(3, 273);
            this.dgvtonkho.MultiSelect = false;
            this.dgvtonkho.Name = "dgvtonkho";
            this.dgvtonkho.ReadOnly = true;
            this.dgvtonkho.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtonkho.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtonkho.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F);
            this.dgvtonkho.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtonkho.RowTemplate.Height = 24;
            this.dgvtonkho.SelectedIndex = -1;
            this.dgvtonkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtonkho.Size = new System.Drawing.Size(1104, 319);
            this.dgvtonkho.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvtonkho.TabIndex = 2;
            this.dgvtonkho.SelectionChanged += new System.EventHandler(this.dgvtonkho_SelectionChanged);
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 4;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel3, 2, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel4, 2, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.txttensp, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.txtsoluongnhap, 1, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.txtsoluongcon, 3, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.txtsoluongxuat, 3, 1);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 2;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(1104, 129);
            this.uiTableLayoutPanel2.TabIndex = 3;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(270, 64);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Tên sản phẩm:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel2.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(3, 64);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(270, 65);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Số lượng nhập:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(555, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(270, 64);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Số lượng còn:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(555, 64);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(270, 64);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "Số lượng xuất:";
            // 
            // txttensp
            // 
            this.txttensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttensp.Dock = System.Windows.Forms.DockStyle.Top;
            this.txttensp.Font = new System.Drawing.Font("Arial", 12F);
            this.txttensp.Location = new System.Drawing.Point(280, 5);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttensp.MinimumSize = new System.Drawing.Size(1, 16);
            this.txttensp.Name = "txttensp";
            this.txttensp.Padding = new System.Windows.Forms.Padding(5);
            this.txttensp.RectColor = System.Drawing.Color.Black;
            this.txttensp.ShowText = false;
            this.txttensp.Size = new System.Drawing.Size(268, 54);
            this.txttensp.TabIndex = 4;
            this.txttensp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttensp.Watermark = "";
            // 
            // txtsoluongnhap
            // 
            this.txtsoluongnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluongnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtsoluongnhap.Font = new System.Drawing.Font("Arial", 12F);
            this.txtsoluongnhap.Location = new System.Drawing.Point(280, 69);
            this.txtsoluongnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsoluongnhap.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtsoluongnhap.Name = "txtsoluongnhap";
            this.txtsoluongnhap.Padding = new System.Windows.Forms.Padding(5);
            this.txtsoluongnhap.RectColor = System.Drawing.Color.Black;
            this.txtsoluongnhap.ShowText = false;
            this.txtsoluongnhap.Size = new System.Drawing.Size(268, 55);
            this.txtsoluongnhap.TabIndex = 5;
            this.txtsoluongnhap.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtsoluongnhap.Watermark = "";
            // 
            // txtsoluongcon
            // 
            this.txtsoluongcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluongcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtsoluongcon.Font = new System.Drawing.Font("Arial", 12F);
            this.txtsoluongcon.Location = new System.Drawing.Point(832, 5);
            this.txtsoluongcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsoluongcon.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtsoluongcon.Name = "txtsoluongcon";
            this.txtsoluongcon.Padding = new System.Windows.Forms.Padding(5);
            this.txtsoluongcon.RectColor = System.Drawing.Color.Black;
            this.txtsoluongcon.ShowText = false;
            this.txtsoluongcon.Size = new System.Drawing.Size(268, 54);
            this.txtsoluongcon.TabIndex = 6;
            this.txtsoluongcon.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtsoluongcon.Watermark = "";
            // 
            // txtsoluongxuat
            // 
            this.txtsoluongxuat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluongxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtsoluongxuat.Font = new System.Drawing.Font("Arial", 12F);
            this.txtsoluongxuat.Location = new System.Drawing.Point(832, 69);
            this.txtsoluongxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsoluongxuat.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtsoluongxuat.Name = "txtsoluongxuat";
            this.txtsoluongxuat.Padding = new System.Windows.Forms.Padding(5);
            this.txtsoluongxuat.RectColor = System.Drawing.Color.Black;
            this.txtsoluongxuat.ShowText = false;
            this.txtsoluongxuat.Size = new System.Drawing.Size(268, 55);
            this.txtsoluongxuat.TabIndex = 7;
            this.txtsoluongxuat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtsoluongxuat.Watermark = "";
            // 
            // uiTableLayoutPanel4
            // 
            this.uiTableLayoutPanel4.ColumnCount = 3;
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel4.Controls.Add(this.uiButton1, 1, 0);
            this.uiTableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel4.Location = new System.Drawing.Point(3, 192);
            this.uiTableLayoutPanel4.Name = "uiTableLayoutPanel4";
            this.uiTableLayoutPanel4.RowCount = 1;
            this.uiTableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel4.Size = new System.Drawing.Size(1104, 75);
            this.uiTableLayoutPanel4.TabIndex = 5;
            this.uiTableLayoutPanel4.TagString = null;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton1.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.uiButton1.FillColorGradient = true;
            this.uiButton1.Font = new System.Drawing.Font("Arial", 12F);
            this.uiButton1.Location = new System.Drawing.Point(371, 3);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(362, 69);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "In đơn tồn kho";
            this.uiButton1.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiTableLayoutPanel3
            // 
            this.uiTableLayoutPanel3.ColumnCount = 2;
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uiTableLayoutPanel3.Controls.Add(this.txttim, 0, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.btntim, 1, 0);
            this.uiTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(3, 138);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 1;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(1104, 48);
            this.uiTableLayoutPanel3.TabIndex = 6;
            this.uiTableLayoutPanel3.TagString = null;
            // 
            // txttim
            // 
            this.txttim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttim.Dock = System.Windows.Forms.DockStyle.Top;
            this.txttim.Font = new System.Drawing.Font("Arial", 12F);
            this.txttim.Location = new System.Drawing.Point(4, 5);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttim.MinimumSize = new System.Drawing.Size(1, 16);
            this.txttim.Name = "txttim";
            this.txttim.Padding = new System.Windows.Forms.Padding(5);
            this.txttim.RectColor = System.Drawing.Color.Black;
            this.txttim.ShowText = false;
            this.txttim.Size = new System.Drawing.Size(875, 38);
            this.txttim.TabIndex = 0;
            this.txttim.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttim.Watermark = "";
            // 
            // btntim
            // 
            this.btntim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntim.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btntim.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btntim.FillColorGradient = true;
            this.btntim.Font = new System.Drawing.Font("Arial", 12F);
            this.btntim.Location = new System.Drawing.Point(886, 3);
            this.btntim.MinimumSize = new System.Drawing.Size(1, 1);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(215, 42);
            this.btntim.Symbol = 61442;
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.TipsFont = new System.Drawing.Font("Arial", 9F);
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // frmTonKho
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 630);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "frmTonKho";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Symbol = 61641;
            this.Text = "Tồn Kho";
            this.TitleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.Initialize += new System.EventHandler(this.frmTonKho_Initialize);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtonkho)).EndInit();
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.uiTableLayoutPanel4.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIDataGridView dgvtonkho;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txttensp;
        private Sunny.UI.UITextBox txtsoluongnhap;
        private Sunny.UI.UITextBox txtsoluongcon;
        private Sunny.UI.UITextBox txtsoluongxuat;
        private Sunny.UI.UITextBox txttim;
        private Sunny.UI.UISymbolButton btntim;
        private Sunny.UI.UIButton uiButton1;
    }
}