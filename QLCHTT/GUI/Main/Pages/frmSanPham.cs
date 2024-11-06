using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using QLCHTT.BUS;
using QLCHTT.DAO;
using Sunny.UI;

namespace QLCHTT.GUI.Main.Pages
{
    public partial class frmSanPham : UIPage
    {
        SanPhamBUS sanphamBUS;
        BaoHanhBUS baoHanhBUS;
        DanhMucBUS danhMucBUS;
        public frmSanPham()
        {
            InitializeComponent();
            sanphamBUS = new SanPhamBUS();
            baoHanhBUS = new BaoHanhBUS();
            danhMucBUS = new DanhMucBUS();
            loadSanPham();
            loadCBBaoHanh();
            loadDanhMuc();
        }
        private void loadCBBaoHanh()
        {
            cbBaoHanh.DataSource = null;
            DataTable baoHanh = baoHanhBUS.getAll();
            baoHanh.Columns.Add("ThoiGianBaoHanhHT", typeof(string));
            foreach (DataRow row in baoHanh.Rows)
            {
                row["ThoiGianBaoHanhHT"] = row["ThoiGianBaoHanh"].ToString() + " tháng";
            }
            cbBaoHanh.DataSource = baoHanh;
            cbBaoHanh.DisplayMember = "ThoiGianBaoHanhHT";
            cbBaoHanh.ValueMember = "MaBaoHanh";
        }
        private void loadDanhMuc()
        {
            cbDanhMuc.DataSource = null;
            DataTable danhMuc = danhMucBUS.getAll();
            cbDanhMuc.DataSource = danhMuc;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
        }

        private void loadSanPham()
        {
            DataTable dt = sanphamBUS.getAll();
            dtgSanPham.DataSource = dt;

            if (dtgSanPham.Columns.Count > 0)
            {
                dtgSanPham.Columns[0].HeaderText = "Mã sản phẩm";
                dtgSanPham.Columns[1].HeaderText = "Mã bảo hành";
                dtgSanPham.Columns[2].HeaderText = "Tên sản phẩm";
                dtgSanPham.Columns[3].HeaderText = "Mã danh mục";
                dtgSanPham.Columns[4].HeaderText = "Mô tả";
                dtgSanPham.Columns[5].HeaderText = "Giá bán";
                dtgSanPham.Columns[6].HeaderText = "Ngày sản xuất";
                dtgSanPham.Columns[7].HeaderText = "Xuất xứ";

            }
            dtgSanPham.ClearSelection();

        }

        private void dtgSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgSanPham.SelectedRows[0];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                string maBaoHanh = selectedRow.Cells["MaBaoHanh"].Value.ToString();
                string tenSanPham = selectedRow.Cells["TenSanPham"].Value.ToString();
                int maDanhMuc = int.Parse(selectedRow.Cells["MaDanhMuc"].Value.ToString());
                string moTa = selectedRow.Cells["MoTa"].Value.ToString();
                DateTime ngaySanXuat = DateTime.Parse(selectedRow.Cells["NgaySanXuat"].Value.ToString());
                string xuatXu = selectedRow.Cells["XuatXu"].Value.ToString();
                int giaBan = int.Parse(selectedRow.Cells["GiaBan"].Value.ToString());

                txtGiaBan.Text = giaBan.ToString("N0") + " VND";
                txtSanPham.Text = tenSanPham;
                cbBaoHanh.SelectedValue = maBaoHanh;
                cbDanhMuc.SelectedValue = maDanhMuc;
                dtpNgaySanXuat.Value = ngaySanXuat;
                txtXuatXu.Text = xuatXu;
                rtxtMoTa.Text = moTa;
            }
        }

        private void btnTimDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimSanPham.Text.Trim()))
            {
                DataTable dt = sanphamBUS.getAll();
                dtgSanPham.DataSource = dt;
            }
            string keyword = txtTimSanPham.Text.Trim();
            DataTable kq = sanphamBUS.searchSanPham(keyword);
            dtgSanPham.DataSource = kq;
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            string tenSanPham = txtSanPham.Text.Trim();
            string baoHanh = cbBaoHanh.SelectedValue.ToString();
            int danhMuc = (int) cbDanhMuc.SelectedValue;
            int giaBan = 0;

            string giaBanText = txtGiaBan.Text.Replace("VND", "").Replace(",", "").Trim();
            if (!int.TryParse(giaBanText, out giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime ngaySanXuat = dtpNgaySanXuat.Value;
                string xuatXu = txtXuatXu.Text;
                string moTa = rtxtMoTa.Text.Trim();
                if (string.IsNullOrEmpty(tenSanPham) ||
                    string.IsNullOrEmpty(baoHanh.ToString()) || string.IsNullOrEmpty(danhMuc.ToString()) || string.IsNullOrEmpty(giaBanText) || string.IsNullOrEmpty(xuatXu))
                {
                    MessageBox.Show("Phải nhập đủ dữ liệu để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm "+tenSanPham+"?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (sanphamBUS.addSanPham(tenSanPham, baoHanh, danhMuc, giaBan, ngaySanXuat, xuatXu, moTa))
                        {
                            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void btnReloadDanhMuc_Click(object sender, EventArgs e)
        {
            loadCBBaoHanh();
            loadDanhMuc();
            loadSanPham();
            txtSanPham.Text = txtGiaBan.Text = txtXuatXu.Text = rtxtMoTa.Text = cbBaoHanh.Text = cbDanhMuc.Text = "";

        }

        private void dtgSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgSanPham.Columns[e.ColumnIndex].Name == "GiaBan" && e.Value != null)
            {
                int thanhTien;
                if (int.TryParse(e.Value.ToString(), out thanhTien))
                {
                    e.Value = thanhTien.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (dtgSanPham.SelectedRows.Count > 0)
            {
                // Remove string interpolation and use string concatenation
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các sản phẩm đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isAllThanhCong = true;
                    foreach (DataGridViewRow selectedRow in dtgSanPham.SelectedRows)
                    {
                        string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                
                        if (!sanphamBUS.deleteSanPham(maSanPham))
                        {
                            isAllThanhCong = false;
                            MessageBox.Show("Xóa sản phẩm " + selectedRow.Cells["TenSanPham"].Value.ToString() + " thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (isAllThanhCong)
                    {
                        MessageBox.Show("Xóa các sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có một số sản phẩm không thể xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    loadSanPham();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (dtgSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgSanPham.SelectedRows[0];
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                string tenSanPham = txtSanPham.Text.Trim();
                string baoHanh = cbBaoHanh.SelectedValue.ToString();
                int danhMuc = (int) cbDanhMuc.SelectedValue;
                int giaBan = 0;

                string giaBanText = txtGiaBan.Text.Replace("VND", "").Replace(",", "").Trim();
                if (!int.TryParse(giaBanText, out giaBan))
                {
                    MessageBox.Show("Giá bán không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DateTime ngaySanXuat = dtpNgaySanXuat.Value;
                    string xuatXu = txtXuatXu.Text;
                    string moTa = rtxtMoTa.Text.Trim();
                    if (string.IsNullOrEmpty(tenSanPham) ||
                        string.IsNullOrEmpty(baoHanh.ToString()) || string.IsNullOrEmpty(danhMuc.ToString()) || string.IsNullOrEmpty(giaBanText) || string.IsNullOrEmpty(xuatXu))
                    {
                        MessageBox.Show("Phải nhập đủ dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm "+tenSanPham+"?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (sanphamBUS.updateSanPham(maSanPham, tenSanPham, baoHanh, danhMuc, giaBan, ngaySanXuat, xuatXu, moTa))
                            {
                                MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadSanPham();
                            }
                            else
                            {
                                MessageBox.Show("Sửa sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnExportDanhMuc_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "SanPhamFile";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    try
                    {
                        ExportExcelSanPham(filePath);
                        MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: "+ex.Message, "Lỗi", MessageBoxButtons.OK);
                    }
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void ExportExcelSanPham(string filePath)
        {
            IWorkbook wb = new XSSFWorkbook();
            ISheet sheet = wb.CreateSheet("SanPham");

            IRow rowhead = sheet.CreateRow(0);
            for (int i = 0; i < dtgSanPham.Columns.Count; i++)
            {
                rowhead.CreateCell(i).SetCellValue(dtgSanPham.Columns[i].HeaderText);
            }

            for (int i = 0; i < dtgSanPham.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dtgSanPham.Columns.Count; j++)
                {
                    if (dtgSanPham.Rows[i].Cells[j].Value != null)
                    {
                        row.CreateCell(j).SetCellValue(dtgSanPham.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        row.CreateCell(j).SetCellValue(string.Empty);
                    }
                }
            }

            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                wb.Write(stream);
            }
        }


        private void frmSanPham_Initialize(object sender, EventArgs e)
        {
            loadCBBaoHanh();
            loadDanhMuc();
            loadSanPham();
        }

        private void uiLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
