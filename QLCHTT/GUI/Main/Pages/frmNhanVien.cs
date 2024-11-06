using QLCHTT.BUS;
using QLCHTT.DAO;
using QuanLyBanHangTheThao.DTO;
using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using System.Collections.Generic;

namespace QLCHTT.GUI.Pages
{
    public partial class frmNhanVien : UIPage
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        NhanVienDAO nvDAO = new NhanVienDAO();
        DataTable dtNV = new DataTable();
        private string maNhanVienHienTai;
        private string taiKhoanHienTai;
        private string soDienThoaiHienTai;
        private byte[] currentImageBytes;

        public frmNhanVien()
        {
            dtNV = nvDAO.getDataTable();
            InitializeComponent();
            loadDataNV();
            loadCBO_ChucVu();
            DataColumn[] key = new DataColumn[1]; 
            key[0] = dtNV.Columns[0]; 
            dtNV.PrimaryKey = key;
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;

        }
        private void loadDataNV()
        {
            dtNV = nvDAO.getDataTable();
            if (!dtNV.Columns.Contains("maNhanVien"))
            {
                MessageBox.Show("Cột maNhanVien không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtNV.PrimaryKey = new DataColumn[] { dtNV.Columns["maNhanVien"] };
            dgvNhanVien.DataSource = dtNV;
            if (dgvNhanVien.Columns.Contains("HinhAnh"))
            {
                dgvNhanVien.Columns["HinhAnh"].Visible = false;
            }

            dataBinding(dtNV);
        }



        private void dataBinding(DataTable dt)
        {
            txtTenNV.DataBindings.Clear();
            txtNgaySinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtSoDT.DataBindings.Clear();
            txtMucLuong.DataBindings.Clear();
            cboChucVu.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            imgNhanVien.DataBindings.Clear(); 

            txtTenNV.DataBindings.Add("Text", dt, "TenNhanVien");
            txtNgaySinh.DataBindings.Add("Text", dt, "NgaySinh");
            txtGioiTinh.DataBindings.Add("Text", dt, "GioiTinh");
            txtSoDT.DataBindings.Add("Text", dt, "SoDienThoai");
            txtMucLuong.DataBindings.Add("Text", dt, "MucLuong");
            cboChucVu.DataBindings.Add("SelectedItem", dt, "ChucVu");
            txtTaiKhoan.DataBindings.Add("Text", dt, "TaiKhoan");
            txtMatKhau.DataBindings.Add("Text", dt, "MatKhau");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            imgNhanVien.Image = null;

            txtTenNV.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtSoDT.Text = string.Empty;
            cboChucVu.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtMucLuong.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtGioiTinh.Text = string.Empty;

            txtMatKhau.Enabled = true;
            txtMatKhau.Enabled = true;
            
        }

        private bool isEmpty(string s)
        {
            return s.Length <= 0;
        }
        private int checkInput()
        {
            if (isEmpty(txtTenNV.Text) || isEmpty(txtSoDT.Text) || isEmpty(txtNgaySinh.Text) || isEmpty(txtMatKhau.Text) || isEmpty(txtMatKhau.Text) || isEmpty(cboChucVu.SelectedValue.ToString()) || isEmpty(txtMucLuong.Text))
            {
                return -1;
            }
            return 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int kiemtraInput = checkInput();
            byte[] hinhAnh = this.currentImageBytes;
            if (kiemtraInput == -1)
            {
                MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nvDAO.trungTaiKhoan(txtMatKhau.Text))
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(nvDAO.trungSoDienThoai(txtSoDT.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtSoDT.Text.Length != 10)
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DateTime ngaySinh;
                    decimal mucLuong;

                    if (DateTime.TryParse(txtNgaySinh.Text, out ngaySinh) && decimal.TryParse(txtMucLuong.Text, out mucLuong))
                    {
                        if (nhanVienBUS.addNhanVien(txtTenNV.Text, txtGioiTinh.Text, ngaySinh, txtSoDT.Text, cboChucVu.SelectedValue.ToString(), mucLuong, txtMatKhau.Text, txtMatKhau.Text, hinhAnh))
                        {
                            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDataNV();

                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh hoặc mức lương không đúng định dạng");
                    }
                }
                
            }
            loadDataNV();
        }
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = false;
            txtMatKhau.Enabled = false;
            if (dgvNhanVien.CurrentRow != null)
            {
                maNhanVienHienTai = dgvNhanVien.CurrentRow.Cells["Column1"].Value.ToString();
                taiKhoanHienTai = dgvNhanVien.CurrentRow.Cells["Column6"].Value.ToString();
                soDienThoaiHienTai = dgvNhanVien.CurrentRow.Cells["Column5"].Value.ToString();


                DataRowView drv = dgvNhanVien.CurrentRow.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    byte[] imageBytes = drv["HinhAnh"] as byte[];
                    if (imageBytes != null)
                    {
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            imgNhanVien.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        imgNhanVien.Image = null; 
                    }

                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn sửa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(edit == DialogResult.Yes)
            {
                byte[] hinhAnh = this.currentImageBytes;
                int kiemtraInput = checkInput();
                if (kiemtraInput == -1)
                {
                    MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSoDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (nvDAO.trungSoDienThoai(txtSoDT.Text) && !txtSoDT.Text.Equals(soDienThoaiHienTai))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadDataNV();
                    return;
                }
                DateTime ngaySinh;
                decimal mucLuong;

                if (DateTime.TryParse(txtNgaySinh.Text, out ngaySinh) && decimal.TryParse(txtMucLuong.Text, out mucLuong))
                {
                    if (nhanVienBUS.updateNhanVien(maNhanVienHienTai, txtTenNV.Text, txtGioiTinh.Text, ngaySinh, txtSoDT.Text, cboChucVu.SelectedValue.ToString(), mucLuong, txtMatKhau.Text, txtMatKhau.Text, hinhAnh))
                    {
                        MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày sinh hoặc mức lương không đúng định dạng");
                }
                loadDataNV();
                
            }    
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult del;
            del = MessageBox.Show("Bạn muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (del == DialogResult.Yes)
            {
                DataRow row = dtNV.Rows.Find(maNhanVienHienTai);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    row.Delete();
                    bool kq = nvDAO.xoaNhanVien(maNhanVienHienTai);
                    if (kq)
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataNV();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = nvDAO.searchDataTable(txtSearch.Text);
            dgvNhanVien.DataSource = dt;
            dataBinding(dt);
        }
        private void loadCBO_ChucVu()
        {
            List<string> ChucVu = new List<string>
            {
                "Nhân viên bán hàng",
                "Nhân viên quản lý hàng hóa",
                "Nhân viên bảo hành",
                "Nhân viên marketing",
                "Nhân viên thống kê",
                "Quản lý"
            };
            cboLocNV.DataSource = ChucVu;
            cboChucVu.DataSource = ChucVu;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DataTable dt = nvDAO.locNhanVien(cboLocNV.Text);
            dgvNhanVien.DataSource = dt;
            dataBinding(dt);
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';

        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void imgNhanVien_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    imgNhanVien.Image = Image.FromFile(filePath);
                    byte[] imageBytes = ImageToByteArray(Image.FromFile(filePath));
                    this.currentImageBytes = imageBytes;
                }
            }
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
        }

        private void uiTableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
