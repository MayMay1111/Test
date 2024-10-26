using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.GUI.Main
{
    public partial class frmInPhieuTon : Form
    {
        public frmInPhieuTon()
        {
            InitializeComponent();
        }

        private void frmInPhieuTon_Load(object sender, EventArgs e)
        {

            this.reportTonKho.RefreshReport();
        }
    }
}
