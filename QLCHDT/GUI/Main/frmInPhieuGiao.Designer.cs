namespace QLCHDT.GUI.Main
{
    partial class frmInPhieuGiao
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
            this.reportGiaoHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportGiaoHang
            // 
            this.reportGiaoHang.ActiveViewIndex = -1;
            this.reportGiaoHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportGiaoHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportGiaoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportGiaoHang.Location = new System.Drawing.Point(0, 0);
            this.reportGiaoHang.Name = "reportGiaoHang";
            this.reportGiaoHang.Size = new System.Drawing.Size(800, 379);
            this.reportGiaoHang.TabIndex = 0;
            this.reportGiaoHang.Load += new System.EventHandler(this.reportGiaoHang_Load);
            // 
            // frmInPhieuGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.reportGiaoHang);
            this.Name = "frmInPhieuGiao";
            this.Text = "frmInPhieuGiao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInPhieuGiao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer reportGiaoHang;
    }
}