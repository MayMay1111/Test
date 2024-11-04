using QLCHTT.BUS;
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

namespace QLCHTT.GUI.Pages
{
    public partial class frmTraHang : UIPage
    {
        TraHangBUS trahang = new TraHangBUS();
        private string MaSP;
        private int soLuong;
        public frmTraHang()
        {
            InitializeComponent();
            loadDataHDTraHang();
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            bool check = trahang.timHoaDon(txtHD.Text.Trim());
            if (check)
            {
                txtKhachHang.Text = trahang.layTenKhachHangTrongHoaDon(txtHD.Text);
                txtSDT.Text = trahang.laySDTKhachHangTrongHoaDon(txtHD.Text);
                DataTable dt = trahang.layChiTietSanPham(txtHD.Text);
                dgvSanPhamTrongHD.DataSource = dt;
                dataBind(dt);
            }
            else
            {
                MessageBox.Show("Không tìm mã hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataBind(DataTable dt)
        {
            txtTenSP.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();

            txtTenSP.DataBindings.Add("Text", dt, "TenSanPham");
            txtSoLuong.DataBindings.Add("Text", dt, "SoLuong");
            txtDonGia.DataBindings.Add("Text", dt, "DonGia");

            
        }
        private void frmTraHang_Load(object sender, EventArgs e)
        {
            txtKhachHang.Enabled = false;
            txtSDT.Enabled = false;
            txtTenSP.Enabled = false;
            txtDonGia.Enabled = false;
            txtNgayTra.Enabled = false;
        }
        private void UpdateTotalAmount()
        {
            decimal tong = 0;
            bool check = false;
            DateTime time = DateTime.Now;
            foreach (DataGridViewRow row in dgvChiTietTraHang.Rows)
            {
                if (row.Cells["SoLuongSP"].Value != null && row.Cells["DonGiaSP"].Value != null)
                {
                    decimal soLuong = Convert.ToDecimal(row.Cells["SoLuongSP"].Value);
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGiaSP"].Value);
                    decimal thanhTien = soLuong * donGia;

                    if (trahang.kiemTraHangTrong30Ngay(txtHD.Text))
                    {
                        tong += thanhTien;
                    }
                    else
                    {
                        tong += thanhTien * (decimal)0.5;
                        check = true;
                    }
                }
            }
            if (check)
            {
                MessageBox.Show("Hóa đơn mua hàng này đã vượt quá 30 ngày nên mọi sản phẩm trả lại sẽ bị trừ 50%", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            txtSoTienPhaiTra.Text = tong.ToString() ; 
        }
        private void dgvSanPhamTrongHD_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvSanPhamTrongHD.CurrentRow != null)
            {
                MaSP = dgvSanPhamTrongHD.CurrentRow.Cells["Column1"].Value.ToString();
                try
                {
                    soLuong = int.Parse(dgvSanPhamTrongHD.CurrentRow.Cells["SoLuong"].Value.ToString());

                }
                catch { return; }
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow newRow in dgvChiTietTraHang.Rows)
            {
                if (newRow.Cells["TenSP"].Value != null &&
                    newRow.Cells["TenSP"].Value.ToString() == txtTenSP.Text)
                {
                    MessageBox.Show("Sản phẩm này đã có trong danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int soluongtextbox = int.Parse(txtSoLuong.Value.ToString());
            if(soluongtextbox > soLuong)
            {
                MessageBox.Show("Số lượng sản phẩm theo vào không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] row = new string[]
            {
                MaSP, txtTenSP.Text, soluongtextbox.ToString(), txtDonGia.Text, txtLyDo.Text
            };
            txtLyDo.Text = string.Empty;
            dgvChiTietTraHang.Rows.Add(row);
            UpdateTotalAmount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietTraHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvChiTietTraHang.SelectedRows[0];
                dgvChiTietTraHang.Rows.Remove(selectedRow);
                MessageBox.Show("Đã xóa sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateTotalAmount();
        }

        private void uiDataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvChiTietTraHang_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void luuTatCaChiTietDonHang()
        {
            
            foreach(DataGridViewRow row in dgvChiTietTraHang.Rows)
            {
                if (!row.IsNewRow)
                {
                    string mahd = txtHD.Text;
                    DateTime time = DateTime.Now;
                    string masp = row.Cells["MaSanPham"].Value.ToString();
                    int soluong = int.Parse(row.Cells["SoLuongSP"].Value.ToString());
                    string dongia = row.Cells["DonGiaSP"].Value.ToString();
                    string lydo = row.Cells["LyDo"].Value.ToString();
                    trahang.themChiTietTraHang(mahd, time, masp, soluong, lydo);
                }
            }
        }
        private void btnLuuHDTraHang_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            decimal tong = decimal.Parse(txtSoTienPhaiTra.Text);
            if(txtHD.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (trahang.luuHDTraHang(txtHD.Text, time))
                {
                    luuTatCaChiTietDonHang();
                    MessageBox.Show("Lưu hóa đơn trả hàng thành công?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    loadDataHDTraHang();               
                }
                else
                {
                    MessageBox.Show("Lưu hóa đơn trả hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (trahang.capnhatTongTien(tong, txtHD.Text, time))
                {

                }
                else
                {
                    MessageBox.Show("Cập nhật tiền thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }
        private void loadDataHDTraHang()
        {
            DataTable dt = trahang.allHDTraHang();
            dgvTraHangvaChiTiet.DataSource = dt;
            dataBindTraHang(dt);
        }
        private void dataBindTraHang(DataTable dt)
        {
            txtMaTraHang.DataBindings.Clear();
            txtNgayTra.DataBindings.Clear();
            txtmaHDTrongTraHang.DataBindings.Clear();
            txtTenSPTrongTraHang.DataBindings.Clear();
            txtSoLuongTrongDonHang.DataBindings.Clear();
            txtLyDoTrongTraHang.DataBindings.Clear();

            txtMaTraHang.DataBindings.Add("Text", dt, "MaTraHang");
            txtNgayTra.DataBindings.Add("Text", dt, "NgayTra");
            txtmaHDTrongTraHang.DataBindings.Add("Text", dt, "MaHoaDon");
            txtTenSPTrongTraHang.DataBindings.Add("Text", dt, "TenSanPham");
            txtSoLuongTrongDonHang.DataBindings.Add("Text", dt, "SoLuong");
            txtLyDoTrongTraHang.DataBindings.Add("Text", dt, "LyDo");
        }

        private void btnSuaHDTraHang_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn sửa hóa đơn trả hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (edit == DialogResult.Yes)
            {
                if(trahang.suaHDTraHang(txtMaTraHang.Text, txtLyDoTrongTraHang.Text))
                {
                    MessageBox.Show("Sửa hóa đơn trả hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa hóa đơn trả hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            loadDataHDTraHang();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int soluongtrongtexbox = int.Parse(txtSoLuong.Text);
            if(soluongtrongtexbox != soLuong)
            {
                MessageBox.Show("Số lượng bị sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtSoLuong_ValueChanged(object sender, int value)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = trahang.timHDTraHang(txtMaTraHang.Text);
            dgvTraHangvaChiTiet.DataSource = dt;
            dataBindTraHang(dt);
        }

        private void btnXoaHDTraHang_Click(object sender, EventArgs e)
        {
            DialogResult edit;
            edit = MessageBox.Show("Bạn có muốn xóa hóa đơn trả hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (edit == DialogResult.Yes)
            {
                if (trahang.xoaHDTraHang(txtMaTraHang.Text))
                {
                    MessageBox.Show("Xóa hóa đơn trả hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn trả hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            loadDataHDTraHang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvChiTietTraHang.Rows.Clear();

            DataTable dt1 = (DataTable)dgvSanPhamTrongHD.DataSource;

            if (dt1 != null)
            {
                dt1.Clear();
            }
            txtHD.Text = string.Empty;
            txtKhachHang.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtLyDo.Text = string.Empty;
        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
