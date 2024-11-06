using QLCHTT.BUS;
using QLCHTT.DAO;
using QLCHTT.GUI.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTT.GUI.Main.Pages
{
    public partial class frmThongTinNhanVien : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        private byte[] currentImageBytes;
        private string mkCu;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
            loadData();

        }
        private void loadData()
        {
            DataTable dt = nhanVienBUS.lay1NhanVien(frmMain.maNhanVienDangNhap);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txtTenNV.Text = row["TenNhanVien"].ToString();
                txtGioiTinh.Text = row["GioiTinh"].ToString();
                txtNgaySinh.Text = Convert.ToDateTime(row["NgaySinh"]).ToString("yyyy-MM-dd");
                txtSoDienThoai.Text = row["SoDienThoai"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtChucVu.Text = row["ChucVu"].ToString();
                txtMucLuong.Text = row["MucLuong"].ToString();
                txtTaiKhoan.Text = row["TaiKhoan"].ToString();
                mkCu = row["MatKhau"].ToString();
                if (row["HinhAnh"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[]) row["HinhAnh"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
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
        private void uiLabel7_Click(object sender, EventArgs e)
        {

        }

        private void uiGroupBox2_Click(object sender, EventArgs e)
        {

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
        private bool isEmpty(string s)
        {
            return s.Length <= 0;
        }
        private int checkInput()
        {
            if (isEmpty(txtTenNV.Text) || isEmpty(txtEmail.Text) || isEmpty(txtSoDienThoai.Text) || isEmpty(txtNgaySinh.Text) || isEmpty(txtTaiKhoan.Text) || isEmpty(txtChucVu.Text) || isEmpty(txtMucLuong.Text))
            {
                return -1;
            }
            return 0;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn sửa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (edit == DialogResult.Yes)
            {
                byte[] hinhAnh = this.currentImageBytes;
                int kiemtraInput = checkInput();
                if (kiemtraInput == -1)
                {
                    MessageBox.Show("Thông tin không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValiDateEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSoDienThoai.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime ngaySinh;
                decimal mucLuong;
                string stdHienTai = txtSoDienThoai.Text;
                if (nhanVienDAO.trungSoDienThoai(txtSoDienThoai.Text) && !txtSoDienThoai.Text.Equals(stdHienTai))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadData();
                    return;
                }
                if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtMucLuong.Text, out mucLuong))
                {
                    MessageBox.Show("Mức lương phải là số thập phân. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nhanVienDAO.update1NhanVien(frmMain.maNhanVienDangNhap, txtTenNV.Text, txtGioiTinh.Text, ngaySinh, txtSoDienThoai.Text, txtChucVu.Text, mucLuong, hinhAnh))
                {
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sửa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadData();

            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

            grDoiMatKhau.Visible = true;
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
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {

            string mkMoi = txtMatKhauMoi.Text;
            if (mkCu != txtMatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu cũ bị sai ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nhanVienBUS.doiMatKhau(txtTaiKhoan.Text, txtMatKhauMoi.Text))
            {
                MessageBox.Show("Đổi tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Đổi tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void grDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            grDoiMatKhau.Visible = false;

        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = '*';
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = '*';
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form main = Application.OpenForms["frmMain"];
                if (main != null)
                {
                    main.Close();
                }
                this.Close();
                Application.Restart();
            }
        }
    }
}
