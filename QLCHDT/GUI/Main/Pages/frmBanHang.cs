using NPOI.SS.Formula.Functions;
using QLCHDT.BUS;
using QLCHDT.DAO;
using QLCHDT.DTO;
using QLCHDT.GUI.KhachHang;
using QLCHDT.GUI.Main;
using QuanLyBanHangDienTu.DTO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLCHDT.GUI.Pages
{
    public partial class frmBanHang : UIPage
    {
        SanPhamBUS sanPhamBUS;
        KhachHangBUS khachHangBUS;
        KhuyenMaiBUS khuyenMaiBUS;
        DangNhapBUS dangNhapBUS;
        HoaDonBUS hoaDonBUS;
        GiaoHangBUS giaoHangBUS;
        ChiTietHoaDonBUS chiTietHoaDonBUS;
        InHoaDonBUS inHoaDonBUS;

        public frmBanHang()
        {
            InitializeComponent();
            sanPhamBUS = new SanPhamBUS();
            khachHangBUS = new KhachHangBUS();
            khuyenMaiBUS = new KhuyenMaiBUS();
            dangNhapBUS = new DangNhapBUS();
            hoaDonBUS = new HoaDonBUS();
            giaoHangBUS = new GiaoHangBUS();
            chiTietHoaDonBUS = new ChiTietHoaDonBUS();
            inHoaDonBUS = new InHoaDonBUS();
            loadForm();
            loadSanPham();
            loadHoaDon();
            loadChiTietHoaDon();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            loadForm();
            loadSanPham();
            loadGioHang();
            loadCBKhuyenMai();
            foreach (DataGridViewColumn col in dtgGioHang.Columns)
            {
                if (col.Name != "GiaoHang")
                {
                    col.ReadOnly = true;
                }
            }
            dtgGioHang.Columns["GiaoHang"].ReadOnly = false;

            dtgGioHang.RowsAdded += dtgGioHang_RowsAdded;
            dtgGioHang.RowsRemoved += dtgGioHang_RowsRemoved;
            cbMaKhuyenMai.SelectedIndexChanged += cbMaKhuyenMai_SelectedIndexChanged;
        }

        private void loadHoaDon()
        {
            DataTable dt = hoaDonBUS.getAll();
            dtgHoaDon.DataSource = dt;
            if (dtgHoaDon.Columns.Count > 0)
            {
                dtgHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dtgHoaDon.Columns[1].HeaderText = "Mã nhân viên";
                dtgHoaDon.Columns[2].HeaderText = "Mã khách hàng";
                dtgHoaDon.Columns[3].HeaderText = "Mã khuyến mãi";
                dtgHoaDon.Columns[4].HeaderText = "Ngày lập hóa đơn";
                dtgHoaDon.Columns[5].HeaderText = "Điểm đã dùng";
                dtgHoaDon.Columns[6].HeaderText = "Tổng tiền";
                dtgHoaDon.Columns[7].HeaderText = "Phương thức thanh toán";

            }
        }
        private void loadChiTietHoaDon()
        {
            string maHoaDon = txtMaHD.Text.Trim();

            if (maHoaDon == null)
            {
                DataTable dt = chiTietHoaDonBUS.getAll();
                dtgChiTietHD.DataSource = dt;
            }
            else
            {
                DataTable dt = chiTietHoaDonBUS.getChiTietMa(maHoaDon);
                dtgChiTietHD.DataSource = dt;
            }
            if (dtgChiTietHD.Columns.Count > 0)
            {
                dtgChiTietHD.Columns[0].HeaderText = "Mã hóa đơn";
                dtgChiTietHD.Columns[1].HeaderText = "Mã sản phẩm";
                dtgChiTietHD.Columns[2].HeaderText = "Số lượng";
                dtgChiTietHD.Columns[3].HeaderText = "Đơn giá";
                dtgChiTietHD.Columns[4].HeaderText = "Thành tiền";
                dtgChiTietHD.Columns[5].HeaderText = "Ghi chú";
            }
        }
        private void loadForm()
        {
            if (string.IsNullOrEmpty(txtMaHoaDon.Text.Trim()))
            {
                btnThemVaoGioHang.Enabled = btnXoaSanPhamKhoiGio.Enabled = btnThanhToan.Enabled =
               btnTimKhachHang.Enabled = btnDungDiemTichLuy.Enabled = btnThanhToan.Enabled = false;

                lblDiemTichLuy.Enabled = lblHoTenKH.Enabled = lblMaKhuyenMai.Enabled = lblSDT.Enabled = lblDiaChi.Enabled = lblNgayGiaoHang.Enabled = false;

                txtDungDiemTichLuy.Enabled = txtGiamGia.Enabled =
                  cbMaKhuyenMai.Enabled = txtPhiGiao.Enabled =
                  txtSoDienThoai.Enabled = txtTongTien.Enabled = dtpNgayGiaoHang.Enabled = false;

                intSoLuongThem.Enabled = false;
                cbPhuongThucThanhToan.Enabled = false;

                btnLuuTam.Enabled = false;
            }

            else
            {
                btnThemVaoGioHang.Enabled = btnXoaSanPhamKhoiGio.Enabled = btnThanhToan.Enabled =
               btnTimKhachHang.Enabled = btnDungDiemTichLuy.Enabled = btnThanhToan.Enabled = true;

                lblDiemTichLuy.Enabled = lblHoTenKH.Enabled = lblMaKhuyenMai.Enabled = lblSDT.Enabled = lblDiaChi.Enabled = lblNgayGiaoHang.Enabled = true;

                txtDungDiemTichLuy.Enabled = txtGiamGia.Enabled =
                  cbMaKhuyenMai.Enabled = txtPhiGiao.Enabled =
                  txtSoDienThoai.Enabled = txtTongTien.Enabled = txtDiaChiGiao.Enabled = dtpNgayGiaoHang.Enabled = true;

                cbPhuongThucThanhToan.Enabled = true;


                intSoLuongThem.Enabled = true;
                btnLuuTam.Enabled = true;
                btnTaoDon.Enabled = false;

            }
        }
        private void loadSanPham()
        {
            try
            {
                DataTable dtSanPham = sanPhamBUS.getSP();
                if (!dtSanPham.Columns.Contains("SoLuongCon"))
                {
                    dtSanPham.Columns.Add("SoLuongCon", typeof(int));
                }
                foreach (DataRow row in dtSanPham.Rows)
                {
                    string maSanPham = row["MaSanPham"].ToString();
                    int soLuongCon = sanPhamBUS.soLuongCon(maSanPham);
                    row["SoLuongCon"] = soLuongCon;
                }
                dtgDanhSachSanPham.DataSource = dtSanPham;
                if (dtgDanhSachSanPham.Columns.Count > 0)
                {
                    dtgDanhSachSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
                    dtgDanhSachSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
                    dtgDanhSachSanPham.Columns["SoLuongCon"].HeaderText = "Số lượng còn";
                    dtgDanhSachSanPham.Columns["GiaBan"].HeaderText = "Giá bán";

                    dtgDanhSachSanPham.Columns["MaSanPham"].DisplayIndex = 0;
                    dtgDanhSachSanPham.Columns["TenSanPham"].DisplayIndex = 1;
                    dtgDanhSachSanPham.Columns["SoLuongCon"].DisplayIndex = 2;
                    dtgDanhSachSanPham.Columns["GiaBan"].DisplayIndex = 3;

                }
                dtgDanhSachSanPham.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadGioHang()
        {
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "GiaoHang";
            chkColumn.HeaderText = "Giao hàng";

            dtgGioHang.Columns.Add("MaSanPham", "Mã sản phẩm");
            dtgGioHang.Columns.Add("TenSanPham", "Tên sản phẩm");
            dtgGioHang.Columns.Add("SoLuong", "Số lượng");
            dtgGioHang.Columns.Add("DonGia", "Đơn giá");
            dtgGioHang.Columns.Add("ThanhTien", "Thành tiền");
            dtgGioHang.Columns.Add(chkColumn);

        }
        private void tinhtongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["ThanhTien"].Value.ToString()))
                {
                    int thanhTien;
                    if (int.TryParse(row.Cells["ThanhTien"].Value.ToString(), out thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }
            }
            txtTongTien.Text = tongTien.ToString("N0") + " VND";

        }

        private void tinhTongPhaiTra()
        {
            int tongPhaiTra = 0;
            if (!string.IsNullOrEmpty(txtGiamGia.Text) || !string.IsNullOrEmpty(txtDungDiemTichLuy.Text))
            {
                int tongTien;
                int giamGia;
                int diemTichLuy;
                if (int.TryParse(txtTongTien.Text.Replace("VND", "").Replace(",", "").Trim(), out tongTien) && int.TryParse(txtGiamGia.Text.Replace("VND", "").Replace(",", "").Trim(), out giamGia) && int.TryParse(txtDungDiemTichLuy.Text.Replace("VND", "").Replace(",", "").Trim(), out diemTichLuy))
                {
                    tongPhaiTra = tongTien - giamGia - diemTichLuy;
                    if (tongPhaiTra < 0)
                    {
                        tongPhaiTra = 0;
                    }

                }
            }
            txtTongPhaiTra.Text = tongPhaiTra.ToString("N0") + " VND";
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmBanHang_Initialize(object sender, EventArgs e)
        {
            loadCBKhuyenMai();
            loadSanPham();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            btnThemVaoGioHang.Enabled = btnXoaSanPhamKhoiGio.Enabled = btnThanhToan.Enabled =
                 btnTimKhachHang.Enabled = btnDungDiemTichLuy.Enabled = btnThanhToan.Enabled = true;


            lblSDT.Enabled = lblDiemTichLuy.Enabled = lblHoTenKH.Enabled = lblMaKhuyenMai.Enabled = true;

            cbMaKhuyenMai.Enabled = txtSoDienThoai.Enabled = true;

            cbPhuongThucThanhToan.Enabled = true;

            btnLuuTam.Enabled = true;

            btnTaoDon.Enabled = false;

            lapHoaDonMoi();

            intSoLuongThem.Enabled = true;

            txtMaHoaDon.Text = hoaDonBUS.layMaMoiNhat();
        }

        private void lapHoaDonMoi()
        {
            string taiKhoan = User.TaiKhoan;
            if (string.IsNullOrEmpty(taiKhoan))
            {
                MessageBox.Show("Chưa đăng nhập.");
                return;
            }
            string maNhanVien = dangNhapBUS.layMaNhanVien(taiKhoan);
            DateTime ngayMua = DateTime.Now;
            bool kq = hoaDonBUS.hoaDonMoi(maNhanVien, ngayMua);
            if (kq)
            {
                MessageBox.Show("Đã lập một hóa đơn mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lập một hóa đơn mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void lapChiTietHoaDonTam()
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    int donGia = Convert.ToInt32(row.Cells["DonGia"].Value);
                    string ghiChu = "";
                    int thanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                    DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell) row.Cells["GiaoHang"];
                    if (chkCell.Value != null && (bool) chkCell.Value)
                    {
                        ghiChu = "Giao hàng";
                    }
                    bool sanPhamDaTonTai = chiTietHoaDonBUS.kiemTraTrungSanPham(maHoaDon, maSanPham);

                    bool kqChiTiet;
                    if (sanPhamDaTonTai)
                    {
                        kqChiTiet = chiTietHoaDonBUS.updateChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
                    }
                    else
                    {
                        kqChiTiet = chiTietHoaDonBUS.addChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
                    }

                    if (!kqChiTiet)
                    {
                        MessageBox.Show("Có lỗi khi cập nhật chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void dtgDanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDanhSachSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgDanhSachSanPham.SelectedRows[0];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                int giaBan = int.Parse(selectedRow.Cells["GiaBan"].Value.ToString());
                txtGiaBan.Text = giaBan.ToString("N0") + " VND";
                string tenSanPham = sanPhamBUS.layTenSanPham(maSanPham);
                txtSanPham.Text = tenSanPham;
                int soLuongCon = int.Parse(selectedRow.Cells["SoLuongCon"].Value.ToString());
                intSoLuongThem.Maximum = soLuongCon;

            }

        }

        private void txtSoLuongCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void intSoLuongThem_ValueChanged(object sender, int value)
        {

        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            string tenSanPham = txtSanPham.Text;
            string maSanPham = sanPhamBUS.layMaSanPham(tenSanPham);
            int soLuongThem = (int) intSoLuongThem.Value;
            int soLuongCon;
            int donGia;

            string giaBanText = txtGiaBan.Text.Replace("VND", "").Replace(",", "").Trim();
            if (!int.TryParse(giaBanText, out donGia))
            {
                MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtgDanhSachSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgDanhSachSanPham.SelectedRows[0];
                if (!int.TryParse(selectedRow.Cells["SoLuongCon"].Value.ToString(), out soLuongCon))
                {
                    MessageBox.Show("Số lượng còn lại không hợp lệ. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool daCo = false;
                foreach (DataGridViewRow row in dtgGioHang.Rows)
                {
                    if (row.Cells["TenSanPham"].Value.ToString() == tenSanPham)
                    {
                        daCo = true;
                        int soLuongTrongGio = (int) row.Cells["SoLuong"].Value;

                        if (soLuongTrongGio + soLuongThem > soLuongCon)
                        {
                            MessageBox.Show("Bạn đã thêm {soLuongTrongGio} sản phẩm này vào giỏ hàng.\nSản phẩm này chỉ còn {soLuongCon} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        row.Cells["SoLuong"].Value = soLuongTrongGio + soLuongThem;
                        row.Cells["ThanhTien"].Value = (soLuongTrongGio + soLuongThem) * donGia;
                        break;
                    }
                }

                if (!daCo)
                {
                    if (soLuongThem <= soLuongCon)
                    {
                        int thanhTien = soLuongThem * donGia;
                        dtgGioHang.Rows.Add(maSanPham, tenSanPham, soLuongThem, donGia, thanhTien);
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm chỉ còn " +soLuongCon + " sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private bool KiemTraGiaoHang()
        {
            bool coGiaoHang = false;
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell) row.Cells["GiaoHang"];
                    if (chkCell.Value != null && (bool) chkCell.Value)
                    {
                        coGiaoHang = true;
                        break;
                    }
                }
            }

            if (coGiaoHang && string.IsNullOrWhiteSpace(txtDiaChiGiao.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ giao hàng và chọn ngày giao hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChiGiao.Focus();
                return false;
            }

            return true;
        }

        bool daInTemp = false;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTenKhachHang.Text))
            {

                MessageBox.Show("Chưa có thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string taiKhoan = User.TaiKhoan;
                if (string.IsNullOrEmpty(taiKhoan))
                {
                    MessageBox.Show("Chưa đăng nhập.");
                    return;
                }
                string soDienThoai = txtSoDienThoai.Text.Trim();
                string maNhanVien = dangNhapBUS.layMaNhanVien(taiKhoan);
                string maKhachHang = khachHangBUS.layMaKhachHang(soDienThoai);
                string maKhuyenMai = cbMaKhuyenMai.SelectedValue.ToString();
                DateTime ngayMua = DateTime.Now;
                int tongTien;
                int diemTichLuy = 0;
                string maHoaDon = txtMaHoaDon.Text.Trim();
                string diemTichLuyText = txtDungDiemTichLuy.Text.Replace("VND", "").Replace(",", "").Trim();

                if (!string.IsNullOrEmpty(diemTichLuyText))
                {
                    int diemTichLuyint;
                    if (int.TryParse(diemTichLuyText, out diemTichLuyint))
                    {
                        diemTichLuy = (int) (diemTichLuyint / 1000);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị điểm tích lũy không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (int.TryParse(txtTongPhaiTra.Text.Replace("VND", "").Replace(",", "").Trim(), out tongTien))
                {
                    if (tongTien == 0)
                    {
                        MessageBox.Show("Chưa có sản phẩm trong giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!KiemTraGiaoHang())
                            return;
                        else
                        {
                            string phuongThucThanhToan = cbPhuongThucThanhToan.Text;
                            if (string.IsNullOrEmpty(phuongThucThanhToan))
                            {
                                MessageBox.Show("Chưa chọn phương thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bool kq = hoaDonBUS.updateHoaDon(maHoaDon, maKhachHang, maKhuyenMai, tongTien, phuongThucThanhToan, diemTichLuy);
                                if (kq)
                                {
                                    bool coSanPhamGiaoHang = false;
                                    foreach (DataGridViewRow row in dtgGioHang.Rows)
                                    {

                                        string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                                        int donGia = Convert.ToInt32(row.Cells["DonGia"].Value);
                                        string ghiChu = "";
                                        int thanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                                        DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell) row.Cells["GiaoHang"];
                                        if (chkCell.Value != null && (bool) chkCell.Value)
                                        {
                                            ghiChu = "Giao hàng";
                                            coSanPhamGiaoHang = true;
                                        }

                                        bool sanPhamDaTonTai = chiTietHoaDonBUS.kiemTraTrungSanPham(maHoaDon, maSanPham);

                                        bool kqChiTiet;
                                        if (sanPhamDaTonTai)
                                        {
                                            kqChiTiet = chiTietHoaDonBUS.updateChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
                                        }
                                        else
                                        {
                                            kqChiTiet = chiTietHoaDonBUS.addChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien, ghiChu);
                                        }

                                        if (!kqChiTiet)
                                        {
                                            MessageBox.Show("Có lỗi khi thêm chi tiết phiếu mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        clearGioHang();

                                    }
                                    if (coSanPhamGiaoHang)
                                    {
                                        string diaChiGiao = txtDiaChiGiao.Text.Trim();
                                        DateTime ngayGiao = dtpNgayGiaoHang.Value;

                                        bool kqTaoGiaoHang = giaoHangBUS.addGiaoHang(maHoaDon, ngayGiao, diaChiGiao);
                                        if (kqTaoGiaoHang)
                                        {
                                            string maGiaoHang = giaoHangBUS.layMaMoiNhat();
                                            foreach (DataGridViewRow row in dtgGioHang.Rows)
                                            {
                                                if (!row.IsNewRow)
                                                {
                                                    DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell) row.Cells["GiaoHang"];
                                                    if (chkCell.Value != null && (bool) chkCell.Value)
                                                    {
                                                        string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                                                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                                                        bool kqChiTietGiao = giaoHangBUS.addChiTietGiaoHang(maGiaoHang, maSanPham, soLuong);
                                                        if (!kqChiTietGiao)
                                                        {
                                                            MessageBox.Show("Có lỗi khi thêm chi tiết giao hàng.");
                                                            return;
                                                        }
                                                        MessageBox.Show("Đã thêm đơn giao hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        clearGioHang();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Có lỗi khi tạo đơn giao hàng.");
                                            return;
                                        }
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Có lỗi khi tạo phiếu mua.");
                                }
                            }
                            inHoaDonBanHang(maHoaDon);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi chuyển đổi");
                }


            }
            loadHoaDon();
            loadChiTietHoaDon();
        }

        private void inHoaDonBanHang(string maHoaDon)
        {
            DataTable dt = inHoaDonBUS.inHoaDon(maHoaDon);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn.");
                return;
            }

            rptInHoaDon rpHoaDon = new rptInHoaDon();
            rpHoaDon.SetDataSource(dt);
            frmXuatHoaDon frmXuatHoaDon = new frmXuatHoaDon();
            frmXuatHoaDon.crystalInHoaDon.ReportSource = rpHoaDon;
            
            bool inThanhCong = false;
            DialogResult result = frmXuatHoaDon.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    frmXuatHoaDon.crystalInHoaDon.PrintReport();
                    inThanhCong = true;
                    MessageBox.Show("In hóa đơn thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi in hóa đơn: " + ex.Message);
                }
            }

            daInTemp = inThanhCong;

            if (inThanhCong)
            {
                clearGioHang();
            }
        }

        private void clearGioHang()
        {
            dtgGioHang.Rows.Clear();

            btnThemVaoGioHang.Enabled = btnXoaSanPhamKhoiGio.Enabled = btnThanhToan.Enabled =
               btnTimKhachHang.Enabled = btnDungDiemTichLuy.Enabled = btnThanhToan.Enabled = false;

            lblDiemTichLuy.Enabled = lblHoTenKH.Enabled = lblMaKhuyenMai.Enabled = lblSDT.Enabled = lblDiaChi.Enabled = lblNgayGiaoHang.Enabled = false;

            txtDungDiemTichLuy.Enabled = txtGiamGia.Enabled = cbMaKhuyenMai.Enabled = txtPhiGiao.Enabled =
              txtSoDienThoai.Enabled = txtTongTien.Enabled = dtpNgayGiaoHang.Enabled = false;

            cbPhuongThucThanhToan.Enabled = false;

            btnLuuTam.Enabled = false;

            txtDungDiemTichLuy.Text =
            txtGiamGia.Text =
            cbMaKhuyenMai.Text = txtPhiGiao.Text = txtDiemTichLuy.Text = cbPhuongThucThanhToan.Text =
            txtSoDienThoai.Text = txtTongTien.Text = txtHoTenKhachHang.Text = txtMaHoaDon.Text = "";

            txtTongTien.Text = txtTongPhaiTra.Text = txtDungDiemTichLuy.Text = txtGiamGia.Text = "0";

            btnTaoDon.Selected = false;

            btnTaoDon.Enabled = true;

            loadSanPham();
        }

        private void loadCBKhuyenMai()
        {
            cbMaKhuyenMai.DataSource = null;
            try
            {
                string tongTienText = txtTongTien.Text.Replace("VND", "").Replace(",", "").Trim();
                int tongTien;
                if (int.TryParse(tongTienText, out tongTien))
                {
                    DataTable khuyenMaiHopLe = khuyenMaiBUS.GetKhuyenMaiHopLe(tongTien, DateTime.Now);
                    cbMaKhuyenMai.DataSource = khuyenMaiHopLe;
                    cbMaKhuyenMai.DisplayMember = "TenChuongTrinh";
                    cbMaKhuyenMai.ValueMember = "MaKhuyenMai";

                }
                else
                {
                    cbMaKhuyenMai.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải danh sách khuyến mãi: " + ex.Message);
            }
        }


        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tenKhachHang = khachHangBUS.layKhachHangSDT(txtSoDienThoai.Text.Trim());
                if (tenKhachHang == null)
                {
                    DialogResult kq = MessageBox.Show("Khách hàng chưa có thông tin.\n Bạn có muốn thêm khách hàng mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (kq == DialogResult.Yes)
                    {
                        frmKhachHangMoi khachHangMoi = new frmKhachHangMoi();
                        khachHangMoi.SoDienThoai = txtSoDienThoai.Text.Trim();
                        khachHangMoi.Show();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    int diemTichLuy = khachHangBUS.layDiemTichLuyKhachHangSDT(txtSoDienThoai.Text.Trim());

                    txtHoTenKhachHang.Text = tenKhachHang;
                    txtDiemTichLuy.Text = diemTichLuy.ToString();
                }

            }
            //try
            //{
            //    string tenKhachHang = khachHangBUS.layKhachHangSDT(txtSoDienThoai.Text.Trim());
            //    int diemTichLuy = khachHangBUS.layDiemTichLuyKhachHangSDT(txtSoDienThoai.Text.Trim());

            //    txtHoTenKhachHang.Text = tenKhachHang;
            //    txtDiemTichLuy.Text = diemTichLuy.ToString();
            //}
            //catch 
            //{
            //    MessageBox.Show("hehe");
            //}
        }

        private void dtgGioHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tinhtongTien();
            tinhTongPhaiTra();
        }

        private void dtgGioHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tinhtongTien();
            tinhTongPhaiTra();
        }

        private void dtgGioHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgGioHang.Columns[e.ColumnIndex].Name == "ThanhTien" && e.Value != null)
            {
                int thanhTien;
                if (int.TryParse(e.Value.ToString(), out thanhTien))
                {
                    e.Value = thanhTien.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
            if (dtgGioHang.Columns[e.ColumnIndex].Name == "DonGia" && e.Value != null)
            {
                int donGia;
                if (int.TryParse(e.Value.ToString(), out donGia))
                {
                    e.Value = donGia.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
        }



        private void uiTableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            loadCBKhuyenMai();
        }

        private void cbMaKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMaKhuyenMai.SelectedItem != null)
            {
                DataRowView drv = cbMaKhuyenMai.SelectedItem as DataRowView;
                if (drv != null)
                {
                    string maKhuyenMai = drv["MaKhuyenMai"].ToString();
                    float giaTriKhuyenMai = khuyenMaiBUS.giaTriKhuyenMai(maKhuyenMai);
                    string moTa = khuyenMaiBUS.moTaKhuyenMai(maKhuyenMai);
                    int tongTien;
                    if (int.TryParse(txtTongTien.Text.Replace("VND", "").Replace(",", "").Trim(), out tongTien))
                    {
                        float giamGia;
                        if (moTa == "Giảm trực tiếp")
                        {
                            giamGia = giaTriKhuyenMai;
                        }
                        else if (moTa == "Giảm phần trăm")
                        {
                            giamGia = tongTien * giaTriKhuyenMai;
                        }
                        else
                        {
                            giamGia = 0;
                        }
                        txtGiamGia.Text = giamGia.ToString("N0") + " VND";
                    }
                    else
                    {
                        Console.WriteLine("Không thể chuyển đổi tổng tiền thành số");
                    }
                }
            }
        }

        private void btnDungDiemTichLuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTenKhachHang.Text.Trim()))
            {
                MessageBox.Show("Chưa có thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDiemTichLuy.Text == "0")
            {
                MessageBox.Show("Khách hàng chưa có điểm tích lũy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm tích lũy muốn sử dụng vào ô SỬ DỤNG ĐIỂM TÍCH LŨY bên dưới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDungDiemTichLuy.Enabled = true;

            }
            if (txtDungDiemTichLuy.Enabled)
            {
                btnDungDiemTichLuy.Selected = true;
            }

        }

        private void txtDungDiemTichLuy_TextChanged(object sender, EventArgs e)
        {
            tinhTongPhaiTra();
        }

        private void txtDungDiemTichLuy_Leave(object sender, EventArgs e)
        {
            int dungDiem;
            int diemtichLuy;
            if (int.TryParse(txtDungDiemTichLuy.Text.Trim(), out dungDiem) && int.TryParse(txtDiemTichLuy.Text.Trim(), out diemtichLuy))
            {
                if (dungDiem > diemtichLuy)
                {
                    MessageBox.Show("Khách hàng không đủ điểm tích lũy để dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dungDiem > 200)
                {
                    MessageBox.Show("Chỉ được dùng tối đa 200 điểm cho 1 đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    diemtichLuy -= dungDiem;
                    txtDiemTichLuy.Text = diemtichLuy.ToString();
                    int quyDoiTien = dungDiem * 1000;
                    txtDungDiemTichLuy.Text = quyDoiTien.ToString("N0") + " VND";
                    txtDungDiemTichLuy.Enabled = false;
                    btnDungDiemTichLuy.Selected = false;
                }
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            tinhTongPhaiTra();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaSanPhamKhoiGio_Click(object sender, EventArgs e)
        {

            if (dtgGioHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgGioHang.SelectedRows[0];
                string sanPham = selectedRow.Cells["TenSanPham"].Value.ToString();

                DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm" + sanPham + "khỏi giỏ hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtgGioHang.SelectedRows)
                    {
                        dtgGioHang.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        private void btnHuyTaoDonHang_Click(object sender, EventArgs e)
        {
            lapChiTietHoaDonTam();
            clearGioHang();
            loadHoaDon();
            loadChiTietHoaDon();
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimSanPham.Text.Trim()))
            {
                DataTable dtSanPham = sanPhamBUS.getSP();
                if (!dtSanPham.Columns.Contains("SoLuongCon"))
                {
                    dtSanPham.Columns.Add("SoLuongCon", typeof(int));
                }
                foreach (DataRow row in dtSanPham.Rows)
                {
                    string maSanPham = row["MaSanPham"].ToString();
                    int soLuongCon = sanPhamBUS.soLuongCon(maSanPham);
                    row["SoLuongCon"] = soLuongCon;
                }
                dtgDanhSachSanPham.DataSource = dtSanPham;
            }
            string keyword = txtTimSanPham.Text.Trim();
            DataTable kq = sanPhamBUS.searchSanPham(keyword);
            if(!kq.Columns.Contains("SoLuongCon"))
            {
                kq.Columns.Add("SoLuongCon", typeof(int));
            }
            foreach (DataRow row in kq.Rows)
            {
                string maSanPham = row["MaSanPham"].ToString();
                int soLuongCon = sanPhamBUS.soLuongCon(maSanPham);
                row["SoLuongCon"] = soLuongCon;
            }
            dtgDanhSachSanPham.DataSource = kq;
        }

        private void dtgDanhSachSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgDanhSachSanPham.Columns[e.ColumnIndex].Name == "GiaBan" && e.Value != null)
            {
                int thanhTien;
                if (int.TryParse(e.Value.ToString(), out thanhTien))
                {
                    e.Value = thanhTien.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
        }

        private void uiTableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            string sdt = txtSoDienThoai.Text;
            if(string.IsNullOrEmpty(sdt))
            {
                return;
            }

            if (sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Clear();
                txtSoDienThoai.Focus();
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgHoaDon.SelectedRows[0];

                string maHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
                string maKhachHang = selectedRow.Cells["MaKhachHang"].Value.ToString();
                string maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                DateTime ngayLapDon = DateTime.Parse(selectedRow.Cells["NgayLapHoaDon"].Value.ToString());
                string maKhuyenMai = selectedRow.Cells["MaKhuyenMai"].Value.ToString();
                int diemDaDung = 0;
                int tongTien = 0;
                string phuongThucThanhToan = selectedRow.Cells["PhuongThucThanhToan"].Value.ToString() ?? "";
                txtMaHD.Text = maHoaDon;
                txtNV.Text = dangNhapBUS.layTenNhanVien(maNhanVien);
                txtKH.Text = khachHangBUS.layTenKhachHang(maKhachHang);
                txtNgay.Text = ngayLapDon.ToString("dd/MM/yyyy");
                txtKM.Text = maKhuyenMai;
                if (selectedRow.Cells["DiemDaDung"].Value == DBNull.Value || selectedRow.Cells["DiemDaDung"].Value == null)
                {
                    txtDiemDung.Text = "";
                }
                else
                {
                    int.TryParse(selectedRow.Cells["DiemDaDung"].Value.ToString(), out diemDaDung);
                    txtDiemDung.Text = diemDaDung.ToString();
                }
                if (selectedRow.Cells["TongTien"].Value == DBNull.Value || selectedRow.Cells["TongTien"].Value == null)
                {
                    txtTT.Text = "";
                }
                else
                {
                    int.TryParse(selectedRow.Cells["TongTien"].Value.ToString(), out tongTien);
                    txtTT.Text = tongTien.ToString("N0") + " VND";
                }

                txtThanhToan.Text = phuongThucThanhToan;
                loadChiTietHoaDon();


            }
        }

        private void dtgChiTietHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgChiTietHD.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgChiTietHD.SelectedRows[0];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                int soLuong = int.Parse(selectedRow.Cells["SoLuong"].Value.ToString());
                int donGia = int.Parse(selectedRow.Cells["DonGia"].Value.ToString());
                string ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();

                txtSanPhamCT.Text = sanPhamBUS.layTenSanPham(maSanPham);
                txtGhiChuCT.Text = ghiChu;
                txtSoLuongCT.Text = soLuong.ToString();
                txtDonGiaCT.Text = donGia.ToString("N0") + " VND";
            }
            else
            {
                txtSanPhamCT.Text =
                txtGhiChuCT.Text =
                txtSoLuongCT.Text =
                txtDonGiaCT.Text = "";
            }

        }

        private void dtgChiTietHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgChiTietHD.Columns[e.ColumnIndex].Name == "DonGia" && e.Value != null)
            {
                int donGia;
                if (int.TryParse(e.Value.ToString(), out donGia))
                {
                    e.Value = donGia.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
            if (dtgChiTietHD.Columns[e.ColumnIndex].Name == "ThanhTien" && e.Value != null)
            {
                int thanhTien;
                if (int.TryParse(e.Value.ToString(), out thanhTien))
                {
                    e.Value = thanhTien.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            string keyword = txtTimHD.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dtgHoaDon.DataSource = hoaDonBUS.getAll();
            }
            else
            {
                dtgHoaDon.DataSource = hoaDonBUS.searchHoaDon(keyword);
            }
        }

        private void btnSuaDonHang_Click(object sender, EventArgs e)
        {
            if (dtgHoaDon.SelectedRows.Count > 0)
            {
                if (string.IsNullOrEmpty(txtKH.Text.Trim()))
                {
                    tabBanHang.SelectedTab = tabBan;
                    txtMaHoaDon.Text = txtMaHD.Text;
                    loadForm();
                    ChuyenChiTietHoaDonSangGioHang(txtMaHoaDon.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Không thể sửa hóa đơn đã thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChuyenChiTietHoaDonSangGioHang(string maHoaDon)
        {
            DataTable chiTietHoaDon = chiTietHoaDonBUS.getChiTietMa(maHoaDon);
            if (chiTietHoaDon != null && chiTietHoaDon.Rows.Count > 0)
            {
                dtgGioHang.Rows.Clear();
                foreach (DataRow row in chiTietHoaDon.Rows)
                {
                    string maSanPham = row["MaSanPham"].ToString();
                    int soLuong = int.Parse(row["SoLuong"].ToString());
                    int donGia = int.Parse(row["DonGia"].ToString());
                    int thanhTien = int.Parse(row["ThanhTien"].ToString());
                    string tenSanPham = sanPhamBUS.layTenSanPham(maSanPham);
                    dtgGioHang.Rows.Add(maSanPham, tenSanPham, soLuong, donGia, thanhTien);
                }

            }
        }

        private void btnReloadDanhMuc_Click(object sender, EventArgs e)
        {
            loadHoaDon();
            loadChiTietHoaDon();
        }

        private void btnXoaDonHang_Click(object sender, EventArgs e)
        {
            if (dtgHoaDon.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các hóa đơn đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool isAllThanhCong = true;
                    foreach (DataGridViewRow selectedRow in dtgHoaDon.SelectedRows)
                    {
                        string maHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
                        string khachHang = selectedRow.Cells["MaKhachHang"].Value.ToString().Trim();
                        if (string.IsNullOrEmpty(khachHang))
                        {
                            if (!hoaDonBUS.deleteHoaDon(maHoaDon))
                            {
                                isAllThanhCong = false;
                                MessageBox.Show("Xóa hóa đơn "+maHoaDon+ " thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa hóa đơn " +maHoaDon+ " vì đã thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isAllThanhCong = false;
                        }
                    }
                    if (isAllThanhCong)
                    {
                        MessageBox.Show("Đã xóa các hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Một số hóa đơn không thể xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    loadHoaDon();
                    loadChiTietHoaDon();
                }
            }

        }


        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHD.Text.Trim();
            inHoaDonBanHang(maHoaDon);

        }

        private void dtgDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
