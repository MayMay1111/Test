namespace QLCHDT.GUI.Main
{
    partial class frmInPhieuTon
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
            this.reportTonKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportTonKho
            // 
            this.reportTonKho.ActiveViewIndex = -1;
            this.reportTonKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportTonKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTonKho.Location = new System.Drawing.Point(0, 0);
            this.reportTonKho.Name = "reportTonKho";
            this.reportTonKho.Size = new System.Drawing.Size(816, 364);
            this.reportTonKho.TabIndex = 0;
            // 
            // frmInPhieuTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 364);
            this.Controls.Add(this.reportTonKho);
            this.Name = "frmInPhieuTon";
            this.Text = "frmInPhieuTon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInPhieuTon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer reportTonKho;
    }
}