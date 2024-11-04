using QLCHTT.BUS;
using QLCHTT.DTO;
using QLCHTT.GUI.Pages;
using SixLabors.ImageSharp.Processing;
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
    public partial class frmDangNhapPage : UIPage
    {
        private DangNhapBUS dangNhapBUS;
        public frmDangNhapPage()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            txtmatkhau.PasswordChar = '*';
        }

        private void frmDangNhapPage_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtdangnhap.Text.Trim();
            string matKhau = txtmatkhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            bool kq = dangNhapBUS.DangNhap(taiKhoan, matKhau);

            if (kq)
            {
                User.TaiKhoan = taiKhoan;
                MessageBox.Show("Đăng nhập thành công.");
                frmMain mainForm = new frmMain(taiKhoan);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác.");
            }
        }

        private void chkhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (txtmatkhau.PasswordChar == '*')
                txtmatkhau.PasswordChar = '\0';
            else
                txtmatkhau.PasswordChar = '*';
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhapPage_Initialize(object sender, EventArgs e)
        {
                
        }
    }
}
