using QLCHTT.BUS;
using QLCHTT.DAO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTT.GUI.Pages
{
    public partial class frmThongTinKhachHang : UIPage
    {
        DataTable dtKhachHang = new DataTable();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        
        public string maKhachHangHienTai;
        public string soDTHienTai;
        public frmThongTinKhachHang()
        {
            InitializeComponent();
            loadData();
            
        }

        private void loadData()
        {
            dgvKhachHang.DataSource = null;
            DataTable dt = khachHangBUS.getAll();
            dgvKhachHang.DataSource = dt;
            dataBinDing(dt);
            
        }
        private void dataBinDing(DataTable dt)
        {
            txtTenKH.DataBindings.Clear();
           
            txtSDT.DataBindings.Clear();
            txtNgaySinh.DataBindings.Clear();
            txtDiemTichLuy.DataBindings.Clear();

            txtTenKH.DataBindings.Add("text", dt, "TenKhachHang");
           
            txtSDT.DataBindings.Add("text", dt, "SoDienThoai");
            txtNgaySinh.DataBindings.Add("text", dt, "NgaySinh");
            txtDiemTichLuy.DataBindings.Add("text", dt, "DiemTichLuy");
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                maKhachHangHienTai = dgvKhachHang.CurrentRow.Cells["Column1"].Value.ToString();
                soDTHienTai = dgvKhachHang.CurrentRow.Cells["Column4"].Value.ToString();
            }
        }
        private bool isEmpty(string s)
        {
            return s.Length <= 0;
        }
        private bool checkInput_IsEmpty()
        {
            if(isEmpty(txtTenKH.Text) || isEmpty(txtNgaySinh.Text) || isEmpty(txtSDT.Text))
            {
                return true;
            }
            return false;
        }
        private bool ValiDateEmail(string email)
        {
            try
            {
                MailAddress check = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
 

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = khachHangBUS.search(txtSearch.Text);

            dgvKhachHang.DataSource = dt;
            dataBinDing(dt);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cboLocKH.SelectedIndex == 0)
            {
                btnAnKH.Visible = true;      
                btnHienKH.Visible = false;  
                DataTable dt = khachHangBUS.locKhachHangAn(0);
                dgvKhachHang.DataSource = dt;
                dataBinDing(dt);
            }
            else if (cboLocKH.SelectedIndex == 1)
            {
                btnAnKH.Visible = false;     
                btnHienKH.Visible = true;   
                DataTable dt = khachHangBUS.locKhachHangAn(1);
                dgvKhachHang.DataSource = dt;
                dataBinDing(dt);
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            bool check = checkInput_IsEmpty();
            if (check)
            {
                MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (khachHangBUS.kiemTraSDT(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (khachHangBUS.themKH(txtTenKH.Text, txtNgaySinh.Text, txtSDT.Text))
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    loadData();
                }

            }

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn sửa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (edit == DialogResult.Yes)
            {
                bool check = checkInput_IsEmpty();
                if (check)
                {
                    MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (khachHangBUS.kiemTraSDT(txtSDT.Text) && !txtSDT.Text.Equals(soDTHienTai))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (khachHangBUS.suaKH(maKhachHangHienTai, txtTenKH.Text, txtNgaySinh.Text, txtSDT.Text, txtDiemTichLuy.Text))
                        {
                            MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        loadData();
                    }

                }
            }

        }

        private void btnAnKH_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn Ẩn khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (edit == DialogResult.Yes)
            {
                if (khachHangBUS.xoaKH(maKhachHangHienTai, txtTenKH.Text, txtNgaySinh.Text, txtSDT.Text, txtDiemTichLuy.Text))
                {
                    MessageBox.Show("Ẩn khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ẩn khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadData();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            txtTenKH.Text = string.Empty;

            txtSDT.Text = string.Empty;

            txtDiemTichLuy.Text = "0";
            txtNgaySinh.Text = string.Empty;

        }

        private void btnHienKH_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn Hiện khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (edit == DialogResult.Yes)
            {
                if (khachHangBUS.hienKH(maKhachHangHienTai, txtTenKH.Text, txtNgaySinh.Text, txtSDT.Text, txtDiemTichLuy.Text))
                {
                    MessageBox.Show("Hiện khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hiện khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dt = khachHangBUS.locKhachHangAn(1);
                dgvKhachHang.DataSource = dt;
                dataBinDing(dt);
            }
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinKhachHang_Initialize(object sender, EventArgs e)
        {
            
        }
    }
}
