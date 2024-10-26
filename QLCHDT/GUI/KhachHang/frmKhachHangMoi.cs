using NPOI.SS.Formula.Functions;
using QLCHDT.BUS;
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

namespace QLCHDT.GUI.KhachHang
{
    public partial class frmKhachHangMoi : Form
    {
        KhachHangBUS khachHangBUS;
        public string SoDienThoai { get; set; }
        public frmKhachHangMoi()
        {
            InitializeComponent();
            khachHangBUS = new KhachHangBUS();
        }

        private void frmKhachHangMoi_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "yyyy-MM-dd";

            txtSoDienThoai.Text = SoDienThoai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTenKKhachHang.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string tenKhachHang = txtHoTenKKhachHang.Text.Trim();
                string soDienThoai = txtSoDienThoai.Text.Trim();
                DateTime ngaySinh = dtpNgaySinh.Value;
                bool addKhachHang = khachHangBUS.addKhachHang(tenKhachHang, ngaySinh, soDienThoai);
                if(addKhachHang)
                {
                    MessageBox.Show("Thêm khách hàng mới thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            string sdt = txtSoDienThoai.Text;

            if (sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Clear();
                txtSoDienThoai.Focus();
            }
        }
    }
}
