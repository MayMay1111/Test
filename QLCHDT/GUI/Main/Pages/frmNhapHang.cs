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

namespace QLCHDT.GUI.Pages
{
    public partial class frmNhapHang : UIPage
    {
        NhaCungCapBUS nhaCungCapBUS;
        SanPhamBUS sanPhamBUS;
        NhapHangBUS nhapHangBUS;
        ChiTietNhapHangBUS chiTietNhapHangBUS;
        public frmNhapHang()
        {
            InitializeComponent();
            nhaCungCapBUS = new NhaCungCapBUS();
            sanPhamBUS = new SanPhamBUS();
            nhapHangBUS = new NhapHangBUS();
            chiTietNhapHangBUS = new ChiTietNhapHangBUS();
            loadMaDatHang();
            loadNhaCungCap();
            loadSanPham();
            loadDonNhap();
            cbTrangThai.SelectedIndex = 1;
            DateTime ngayDat = DateTime.Now;
            txtNgayDat.Text = ngayDat.ToString("dd/MM/yyyy");
        }
        private void loadMaDatHang()
        {
            cbMaDatHang.DataSource = null;
            DataTable dt = nhapHangBUS.getAll();
            cbMaDatHang.DataSource = dt;
            cbMaDatHang.ValueMember = "MaDonDatHang";
            cbMaDatHang.DisplayMember = "MaDonDatHang";
        }
        private void loadNhaCungCap()
        {
            cbNhaCungCap.DataSource = null;
            DataTable ncc = nhaCungCapBUS.getAll();
            cbNhaCungCap.DataSource = ncc;
            cbNhaCungCap.ValueMember = "MaNhaCungCap";
            cbNhaCungCap.DisplayMember = "TenNhaCungCap";
        }

        private void loadSanPham()
        {
            cbSanPham.DataSource = null;
            DataTable sanPham = sanPhamBUS.getAll();
            cbSanPham.DataSource = sanPham;
            cbSanPham.ValueMember = "MaSanPham";
            cbSanPham.DisplayMember = "TenSanPham";
        }
        private void loadDonNhap()
        {
            DataTable dt = nhapHangBUS.getAll();
            dtgNhapHang.DataSource = dt;
            if (dtgNhapHang.Columns.Count > 0)
            {
                dtgNhapHang.Columns["MaDonDatHang"].HeaderText = "Mã đơn đặt hàng";
                dtgNhapHang.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
                dtgNhapHang.Columns["TongTien"].HeaderText = "Tổng tiền";
                dtgNhapHang.Columns["NgayDatHang"].HeaderText = "Ngày đặt hàng";
                dtgNhapHang.Columns["TrangThai"].HeaderText = "TrangThai";
            }
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void frmNhapHang_Initialize(object sender, EventArgs e)
        {
            loadMaDatHang();
            loadNhaCungCap();
            loadSanPham();
        }

        private void dtgNhapHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgNhapHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgNhapHang.SelectedRows[0];
                string maDonDat = selectedRow.Cells["MaDonDatHang"].Value.ToString();
                string maNhaCungCap = selectedRow.Cells["MaNhaCungCap"].Value.ToString();
        
                DateTime ngayDatHang;
                if (DateTime.TryParse(selectedRow.Cells["NgayDatHang"].Value.ToString(), out ngayDatHang))
                {
                    txtNgayDat.Text = ngayDatHang.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayDat.Text = "Ngày không hợp lệ";
                }

                int tongTien;
                if (int.TryParse(selectedRow.Cells["TongTien"].Value.ToString(), out tongTien))
                {
                    txtTongTien.Text = tongTien.ToString("N0") + " VND";
                }
                else
                {
                    txtTongTien.Text = "0 VND";
                }

                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();

                // Assign values to controls
                cbMaDatHang.SelectedValue = maDonDat;
                cbNhaCungCap.SelectedValue = maNhaCungCap;
                txtNgayDat.Text = ngayDatHang.ToString("dd/MM/yyyy");
                txtTongTien.Text = tongTien.ToString("N0") + " VND";
                cbTrangThai.Text = trangThai;
            }
        }

        private void txtGiaBan_Leave(object sender, EventArgs e)
        {
            string input = txtGiaBan.Text.Replace(",", "").Replace(" VND", "").Trim();

            int giaBan;
            if (int.TryParse(input, out giaBan) && giaBan > 0)
            {
                txtGiaBan.Text = giaBan.ToString("N0") + " VND";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return;
            }
        }

        private void tinhThanhTien()
        {
            int giaBan;
            if (int.TryParse(txtGiaBan.Text.Replace(",", "").Replace(" VND", "").Trim(), out giaBan) && intUDSoLuong.Value > 0)
            {
                int soLuong = (int)intUDSoLuong.Value;
                int thanhTien = giaBan * soLuong;

                txtThanhTien.Text = thanhTien.ToString("N0") + " VND";
            }
            else
            {
                txtThanhTien.Text = "0 VND";
            }
        }


        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            tinhThanhTien();
        }

        private void intUDSoLuong_ValueChanged(object sender, int value)
        {
            tinhThanhTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNhaCungCap = cbNhaCungCap.SelectedValue.ToString();
            DateTime ngayDatHang = DateTime.Now;

            if (nhapHangBUS.addDonNhapHang(maNhaCungCap, ngayDatHang))
            {
                MessageBox.Show("Thêm thành công đơn đặt hàng! Vui lòng thêm chi tiết đơn đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDonNhap();
            loadMaDatHang();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            cbTrangThai.SelectedIndex = 1;
    
            string maDonDat = cbMaDatHang.SelectedValue.ToString();
    
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm vào đơn " + maDonDat + " này để đặt hàng?", 
                "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maSanPham = cbSanPham.SelectedValue.ToString();
        
                int soLuong = (int) intUDSoLuong.Value;

                int giaBan;
                if (int.TryParse(txtGiaBan.Text.Replace(",", "").Replace(" VND", "").Trim(), out giaBan))
                {
                    string errorMessage;

                    if (chiTietNhapHangBUS.addChiTietDonNhapHang(maDonDat, maSanPham, soLuong, giaBan, out errorMessage))
                    {
                        MessageBox.Show("Thêm chi tiết đơn đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            loadDonNhap();
            dtgChiTietNH.DataSource = chiTietNhapHangBUS.getAll(maDonDat);
        }


        private void cbMaDatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaDatHang.SelectedItem != null)
            {
                string maDatHang = cbMaDatHang.SelectedValue.ToString();
                DataTable dt = chiTietNhapHangBUS.getAll(maDatHang);
                dtgChiTietNH.DataSource = dt;
                if (dtgChiTietNH.Columns.Count > 0)
                {
                    dtgChiTietNH.Columns["MaDonDatHang"].HeaderText = "Mã đơn đặt hàng";
                    dtgChiTietNH.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
                    dtgChiTietNH.Columns["SoLuong"].HeaderText = "Số lượng";
                    dtgChiTietNH.Columns["DonGia"].HeaderText = "Đơn giá";
                    dtgChiTietNH.Columns["ThanhTien"].HeaderText = "Thành tiền";
                }
            }
        }

        private void dtgChiTietNH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgChiTietNH.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgChiTietNH.SelectedRows[0];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                int soLuong = int.Parse(selectedRow.Cells["SoLuong"].Value.ToString());
                int donGia = int.Parse(selectedRow.Cells["DonGia"].Value.ToString());

                cbSanPham.SelectedValue = maSanPham;
                intUDSoLuong.Value = soLuong;
                txtGiaBan.Text = donGia.ToString("N0") + " VND";
            }
        }

        private void btnSuaDonHang_Click(object sender, EventArgs e)
        {
            string trangThai = cbTrangThai.Text;
            string maDonDat = cbMaDatHang.SelectedValue.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa trạng thái "+trangThai+" vào đơn "+maDonDat+" này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhapHangBUS.updateDonNhapHang(maDonDat, trangThai))
                {
                    MessageBox.Show("Sửa trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi sửa trạng thái đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            loadDonNhap();
            dtgChiTietNH.DataSource = chiTietNhapHangBUS.getAll(maDonDat);
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimHD.Text.Trim()))
            {
                DataTable get = nhapHangBUS.getAll();
                dtgNhapHang.DataSource = get;
            }
            string keyword = txtTimHD.Text.Trim();
            DataTable kq = nhapHangBUS.searchDonNhapHang(keyword);
            dtgNhapHang.DataSource = kq;
        }

        private void btnReloadDanhMuc_Click(object sender, EventArgs e)
        {
            loadDonNhap();
            string maDonDat = cbMaDatHang.SelectedValue.ToString();
            dtgChiTietNH.DataSource = chiTietNhapHangBUS.getAll(maDonDat);
        }
    }
}
