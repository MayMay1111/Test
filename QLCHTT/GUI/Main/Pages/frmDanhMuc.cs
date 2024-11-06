using QLCHTT.BUS;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Threading;
using QLCHTT.DAO;
using System.Text.RegularExpressions;

namespace QLCHTT.GUI.Pages
{
    public partial class frmDanhMuc : UIPage
    {
        DanhMucBUS danhMucBUS;
        NhaCungCapBUS nhaCungCapBUS;
        public frmDanhMuc()
        {
            InitializeComponent();
            danhMucBUS = new DanhMucBUS();
            nhaCungCapBUS = new NhaCungCapBUS();
            LoadDataDanhMuc();
            LoadDataNhaCungCap();
        }

        private bool checkSDT(string phoneNumber)
        {
            string sdt = @"^0[0-9]{9,10}$";
            return Regex.IsMatch(phoneNumber, sdt);
        }

        private void LoadDataNhaCungCap()
        {
            try
            {
                DataTable dtNhaCungCap = nhaCungCapBUS.getAll();
                dtgNhaCungCap.DataSource = dtNhaCungCap;
                if (dtgNhaCungCap.Columns.Count > 0)
                {
                    dtgNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
                    dtgNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
                    dtgNhaCungCap.Columns[2].HeaderText = "Người liên hệ";
                    dtgNhaCungCap.Columns[3].HeaderText = "Số điện thoại";
                    dtgNhaCungCap.Columns[4].HeaderText = "Địa chỉ";
                }
                dtgNhaCungCap.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDataDanhMuc()
        {
            try
            {
                DataTable dtDanhMuc = danhMucBUS.getAll();
                dtgDanhMuc.DataSource = dtDanhMuc;
                if (dtgDanhMuc.Columns.Count > 0)
                {
                    dtgDanhMuc.Columns[0].HeaderText = "Mã danh mục";
                    dtgDanhMuc.Columns[1].HeaderText = "Tên danh mục";
                    dtgDanhMuc.Columns[2].HeaderText = "Mô tả";
                }
                dtgDanhMuc.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDanhMuc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgDanhMuc.SelectedRows[0];
                int maDanhMuc = int.Parse(selectedRow.Cells["MaDanhMuc"].Value.ToString());
                txtTenDanhMuc.Text = selectedRow.Cells["TenDanhMuc"].Value.ToString();
                rtxtMoTa.Text = selectedRow.Cells["MoTa"].Value.ToString();

                txtSoSanPham.Text = danhMucBUS.tongSanPham(maDanhMuc).ToString();

            }
        }
       private void btnExportDanhMuc_Click(object sender, EventArgs e)
        {
            // Use a background thread for exporting
            Thread thread = new Thread(new ThreadStart(ExportDanhMuc));
            thread.SetApartmentState(ApartmentState.STA); // Set the apartment state
            thread.Start(); // Start the thread
        }

        private void ExportDanhMuc()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = "DanhMucFile";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;

                try
                {
                    ExportExcelDanhMuc(filePath);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportExcelDanhMuc(string filePath)
        {
            IWorkbook wb = new XSSFWorkbook(); // Create new workbook
            ISheet sheet = wb.CreateSheet("DanhMuc"); // Create sheet

            // Create header row
            IRow rowhead = sheet.CreateRow(0);
            for (int i = 0; i < dtgDanhMuc.Columns.Count; i++)
            {
                rowhead.CreateCell(i).SetCellValue(dtgDanhMuc.Columns[i].HeaderText);
            }

            // Populate data rows
            for (int i = 0; i < dtgDanhMuc.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dtgDanhMuc.Columns.Count; j++)
                {
                    row.CreateCell(j).SetCellValue(dtgDanhMuc.Rows[i].Cells[j].Value != null ? dtgDanhMuc.Rows[i].Cells[j].Value.ToString() : "");
                }
            }

            // Write to file
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                wb.Write(stream); // Write workbook to the file
            }
        }

        private void ExportExcelNhaCungCap(string filePath)
        {
            IWorkbook workbook = new XSSFWorkbook(); // Create new workbook
            ISheet sheet = workbook.CreateSheet("NhaCungCap"); // Create sheet

            // Create header row
            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dtgNhaCungCap.Columns.Count; i++)
            {
                headerRow.CreateCell(i).SetCellValue(dtgNhaCungCap.Columns[i].HeaderText);
            }

            // Populate data rows
            for (int i = 0; i < dtgNhaCungCap.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dtgNhaCungCap.Columns.Count; j++)
                {
                    row.CreateCell(j).SetCellValue(dtgNhaCungCap.Rows[i].Cells[j].Value != null ? dtgNhaCungCap.Rows[i].Cells[j].Value.ToString() : "");
                }
            }

            // Write to file
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream); // Write workbook to the file
            }
        }


        private void btnReloadDanhMuc_Click(object sender, EventArgs e)
        {
            LoadDataDanhMuc();
            txtTenDanhMuc.Text = rtxtMoTa.Text = txtSoSanPham.Text = "";
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = txtTenDanhMuc.Text.Trim();
            string moTa = rtxtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(tenDanhMuc))
            {
                MessageBox.Show("Tên danh mục không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm danh mục " + tenDanhMuc + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (danhMucBUS.addDanhMuc(tenDanhMuc, moTa))
                {
                    MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataDanhMuc();
                }
                else
                {
                    MessageBox.Show("Thêm danh mục thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (dtgDanhMuc.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các danh mục đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isAllThanhCong = true;

                    foreach (DataGridViewRow selectedRow in dtgDanhMuc.SelectedRows)
                    {
                        int maDanhMuc = int.Parse(selectedRow.Cells["MaDanhMuc"].Value.ToString());

                        if (!danhMucBUS.deleteDanhMuc(maDanhMuc))
                        {
                            isAllThanhCong = false;
                            MessageBox.Show("Xóa danh mục " + selectedRow.Cells["TenDanhMuc"].Value.ToString() + " thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (isAllThanhCong)
                    {
                        MessageBox.Show("Xóa các danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có một số danh mục không thể xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LoadDataDanhMuc();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            string tenNhaCungCap = txtTenNhaCungCap.Text.Trim();
            string nguoiLienHe = txtNguoiLienHe.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(tenNhaCungCap) || string.IsNullOrEmpty(nguoiLienHe) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!checkSDT(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhà cung cấp " + tenNhaCungCap + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (nhaCungCapBUS.addNhaCungCap(tenNhaCungCap, nguoiLienHe, diaChi, soDienThoai))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (dtgNhaCungCap.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các nhà cung cấp đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool isAllThanhCong = true;

                    foreach (DataGridViewRow selectedRow in dtgNhaCungCap.SelectedRows)
                    {
                        int maNhaCungCap = int.Parse(selectedRow.Cells["MaNhaCungCap"].Value.ToString());

                        if (!nhaCungCapBUS.deleteNhaCungCap(maNhaCungCap))
                        {
                            isAllThanhCong = false;
                            MessageBox.Show("Xóa nhà cung cấp " + selectedRow.Cells["TenNhaCungCap"].Value.ToString() + " thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (isAllThanhCong)
                    {
                        MessageBox.Show("Xóa các nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có một số nhà cung cấp không thể xóa được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    LoadDataNhaCungCap();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            if (dtgNhaCungCap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgNhaCungCap.SelectedRows[0];
                int maNhaCungCap = int.Parse(selectedRow.Cells["MaNhaCungCap"].Value.ToString());
                string tenNhaCungCap = txtTenNhaCungCap.Text.Trim();
                string nguoiLienHe = txtNguoiLienHe.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string soDienThoai = txtSoDienThoai.Text.Trim();

                if (string.IsNullOrEmpty(tenNhaCungCap) || string.IsNullOrEmpty(nguoiLienHe) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai))
                {
                    MessageBox.Show("Tên nhà cung cấp không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!checkSDT(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn sửa nhà cung cấp " + tenNhaCungCap + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (nhaCungCapBUS.updateNhaCungCap(maNhaCungCap, tenNhaCungCap, nguoiLienHe, diaChi, soDienThoai))
                    {
                        MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhà cung cấp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dtgNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgNhaCungCap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgNhaCungCap.SelectedRows[0];
                txtTenNhaCungCap.Text = selectedRow.Cells["TenNhaCungCap"].Value.ToString();
                txtNguoiLienHe.Text = selectedRow.Cells["NguoiLienHe"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();

            }
        }

        private void btnExportNhaCungCap_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "NhaCungCapFile";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    try
                    {
                        ExportExcelNhaCungCap(filePath);
                        MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    }
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnTimNhaCungCap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimNhaCungCap.Text.Trim()))
            {
                DataTable get = nhaCungCapBUS.getAll();
                dtgNhaCungCap.DataSource = get;
            }
            else
            {
                string keyword = txtTimNhaCungCap.Text.Trim();
                DataTable kq = nhaCungCapBUS.searchNhaCungCap(keyword);
                dtgNhaCungCap.DataSource = kq;
            }
        }

        private void btnReloadNhaCungCap_Click(object sender, EventArgs e)
        {
            LoadDataNhaCungCap();
            txtTenNhaCungCap.Text = txtNguoiLienHe.Text = txtDiaChi.Text = txtSoDienThoai.Text = txtEmail.Text = "";
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (dtgDanhMuc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgDanhMuc.SelectedRows[0];
                int maDanhMuc = int.Parse(selectedRow.Cells["MaDanhMuc"].Value.ToString());
                string tenDanhMuc = txtTenDanhMuc.Text.Trim();
                string moTa = rtxtMoTa.Text.Trim();

                if (string.IsNullOrEmpty(tenDanhMuc))
                {
                    MessageBox.Show("Tên danh mục không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn sửa danh mục " + tenDanhMuc + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (danhMucBUS.updateDanhMuc(maDanhMuc, tenDanhMuc, moTa))
                    {
                        MessageBox.Show("Sửa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataDanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Sửa danh mục thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnTimDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimDanhMuc.Text.Trim()))
            {
                DataTable get = danhMucBUS.getAll();
                dtgDanhMuc.DataSource = get;
            }
            string keyword = txtTimDanhMuc.Text.Trim();
            DataTable kq = danhMucBUS.searchDanhMuc(keyword);
            dtgDanhMuc.DataSource = kq;
        }
    }
}
