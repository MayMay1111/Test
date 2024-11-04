namespace QLCHTT.GUI.Main
{
    partial class frmXuatHoaDon
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
            this.crystalInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInHoaDon1 = new QLCHTT.rptInHoaDon();
            this.SuspendLayout();
            // 
            // crystalInHoaDon
            // 
            this.crystalInHoaDon.ActiveViewIndex = -1;
            this.crystalInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crystalInHoaDon.Name = "crystalInHoaDon";
            this.crystalInHoaDon.Size = new System.Drawing.Size(800, 450);
            this.crystalInHoaDon.TabIndex = 0;
            // 
            // frmXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalInHoaDon);
            this.Name = "frmXuatHoaDon";
            this.Text = "In Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalInHoaDon;
        private rptInHoaDon rptInHoaDon1;
    }
}