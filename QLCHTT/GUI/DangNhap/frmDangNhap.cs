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

namespace QLCHTT.GUI.DangNhap
{
    public partial class frmDangNhap : UIMainFrame
    {
        public frmDangNhap()
        {
            InitializeComponent();

            var page = new frmDangNhapPage();
            AddPage(page, 5000);
            SelectPage(5000);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
