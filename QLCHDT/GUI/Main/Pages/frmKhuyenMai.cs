using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using QLCHDT.BUS;
using Sunny.UI;
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

namespace QLCHDT.GUI.Main.Pages
{
    public partial class frmKhuyenMai : UIPage
    {
        KhuyenMaiBUS khuyenMaiBUS;
        public frmKhuyenMai()
        {
            InitializeComponent();
            khuyenMaiBUS = new KhuyenMaiBUS();
            loadform();
        }

        private void loadform()
        {
            DataTable dt = khuyenMaiBUS.getAll();
            dtgKhuyenMai.DataSource = dt;

            if (dtgKhuyenMai.Columns.Count > 0)
            {
                dtgKhuyenMai.Columns[0].HeaderText = "Mã khuyến mãi";
                dtgKhuyenMai.Columns[1].HeaderText = "Tên chương trình";
                dtgKhuyenMai.Columns[2].HeaderText = "Giá trị khuyến mãi";
                dtgKhuyenMai.Columns[3].HeaderText = "Mô tả";
                dtgKhuyenMai.Columns[4].HeaderText = "Ngày bắt đầu";
                dtgKhuyenMai.Columns[5].HeaderText = "Ngày kết thúc";
                dtgKhuyenMai.Columns[6].HeaderText = "Điều kiện áp dụng";
                dtgKhuyenMai.Columns[7].HeaderText = "Giá trị đơn hàng tối thiểu";

            }
            dtgKhuyenMai.ClearSelection();
        }

        private void dtgKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgKhuyenMai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgKhuyenMai.SelectedRows[0];

                string maKhuyenMai = selectedRow.Cells["MaKhuyenMai"].Value != null ? selectedRow.Cells["MaKhuyenMai"].Value.ToString() : "";
                string tenChuongtrinh = selectedRow.Cells["TenChuongTrinh"].Value != null ? selectedRow.Cells["TenChuongTrinh"].Value.ToString() : "";
                string moTa = selectedRow.Cells["MoTa"].Value != null ? selectedRow.Cells["MoTa"].Value.ToString() : "";
                string dieuKien = selectedRow.Cells["DieuKienApDung"].Value != null ? selectedRow.Cells["DieuKienApDung"].Value.ToString() : "";

                float giaTriKhuyenMai = 0;
                if (selectedRow.Cells["GiaTriKhuyenMai"].Value != null)
                {
                    float.TryParse(selectedRow.Cells["GiaTriKhuyenMai"].Value.ToString(), out giaTriKhuyenMai);
                }

                int giaTriToiThieu = 0;
                if (selectedRow.Cells["GiaTriDonHangToiThieu"].Value != null)
                {
                    int.TryParse(selectedRow.Cells["GiaTriDonHangToiThieu"].Value.ToString(), out giaTriToiThieu);
                }

                DateTime ngayBatDau = DateTime.Now;
                if (selectedRow.Cells["NgayBatDau"].Value != null)
                {
                    DateTime.TryParse(selectedRow.Cells["NgayBatDau"].Value.ToString(), out ngayBatDau);
                }

                DateTime ngayKetThuc = DateTime.Now;
                if (selectedRow.Cells["NgayKetThuc"].Value != null)
                {
                    DateTime.TryParse(selectedRow.Cells["NgayKetThuc"].Value.ToString(), out ngayKetThuc);
                }

                txtDonHangToiThieu.Text = giaTriToiThieu.ToString("N0") + " VND";
                txtGiaTriKhuyenMai.Text = giaTriKhuyenMai.ToString();
                txtTenKhuyenMai.Text = tenChuongtrinh;
                txtMaKhuyenMai.Text = maKhuyenMai;
                dptNgayBatDau.Value = ngayBatDau;
                dtpNgayKetThuc.Value = ngayKetThuc;
                rtxtDieuKien.Text = dieuKien;
                rtxtMieuTa.Text = moTa;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaKhuyenMai.Text) && !string.IsNullOrEmpty(txtTenKhuyenMai.Text) &&
                !string.IsNullOrEmpty(txtGiaTriKhuyenMai.Text) && !string.IsNullOrEmpty(txtDonHangToiThieu.Text) &&
                !string.IsNullOrEmpty(rtxtDieuKien.Text) && !string.IsNullOrEmpty(rtxtMieuTa.Text))
            {
                DateTime ngayBatDau = dptNgayBatDau.Value;
                DateTime ngayKetThuc = dtpNgayKetThuc.Value;
                if (ngayBatDau > ngayKetThuc)
                {
                    MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string maKhuyenMai = txtMaKhuyenMai.Text.Trim();
                    string tenChuongTrinh = txtTenKhuyenMai.Text.Trim();
                    float giaTriKhuyenMai = float.Parse(txtGiaTriKhuyenMai.Text.Trim());
                    string moTa = rtxtMieuTa.Text.Trim();
                    string dieuKien = rtxtDieuKien.Text.Trim();
                    int giaTriToiThieu = 0;

                    string giaTriText = txtDonHangToiThieu.Text.Replace("VND", "").Replace(",", "").Trim();
                    if (!int.TryParse(giaTriText, out giaTriToiThieu))
                    {
                        MessageBox.Show("Giá bán không hợp lệ, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (maKhuyenMai.Length > 13)
                    {
                        MessageBox.Show("Mã khuyến mãi tối đa 13 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (khuyenMaiBUS.checkTrungMa(maKhuyenMai))
                    {
                        MessageBox.Show("Mã khuyến mãi này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn thêm khuyến mãi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (khuyenMaiBUS.addKhuyenMai(maKhuyenMai, tenChuongTrinh, giaTriKhuyenMai, moTa, ngayBatDau, ngayKetThuc, dieuKien, giaTriToiThieu))
                            {
                                MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadform();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaKhuyenMai.Text))
            {
                DateTime ngayKetThuc = dtpNgayKetThuc.Value;
                if (ngayKetThuc >= DateTime.Now)
                {
                    MessageBox.Show("Không thể xóa chương trình khuyến mãi đang diễn ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (khuyenMaiBUS.deleteKhuyenMai(txtMaKhuyenMai.Text.Trim()))
                        {
                            MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadform();
                        }
                        else
                        {
                            MessageBox.Show("Xóa khuyến mãi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaKhuyenMai.Text) && !string.IsNullOrEmpty(txtTenKhuyenMai.Text) &&
                !string.IsNullOrEmpty(txtGiaTriKhuyenMai.Text) && !string.IsNullOrEmpty(txtDonHangToiThieu.Text) &&
                !string.IsNullOrEmpty(rtxtDieuKien.Text) && !string.IsNullOrEmpty(rtxtMieuTa.Text))
            {
                DateTime ngayBatDau = dptNgayBatDau.Value;
                DateTime ngayKetThuc = dtpNgayKetThuc.Value;
                if (ngayBatDau > ngayKetThuc)
                {
                    MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string maKhuyenMai = txtMaKhuyenMai.Text.Trim();
                    string tenChuongTrinh = txtTenKhuyenMai.Text.Trim();
                    float giaTriKhuyenMai = float.Parse(txtGiaTriKhuyenMai.Text.Trim());
                    string moTa = rtxtMieuTa.Text.Trim();
                    string dieuKien = rtxtDieuKien.Text.Trim();
                    int giaTriToiThieu = 0;

                    string giaTriText = txtDonHangToiThieu.Text.Replace("VND", "").Replace(",", "").Trim();
                    if (!int.TryParse(giaTriText, out giaTriToiThieu))
                    {
                        MessageBox.Show("Giá bán không hợp lệ, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn sửa khuyến mãi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (khuyenMaiBUS.updatekhuyenMai(maKhuyenMai, tenChuongTrinh, giaTriKhuyenMai, moTa, ngayBatDau, ngayKetThuc, dieuKien, giaTriToiThieu))
                            {
                                MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadform();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadform();
            txtDonHangToiThieu.Text = txtGiaTriKhuyenMai.Text = txtMaKhuyenMai.Text = txtTenKhuyenMai.Text = rtxtDieuKien.Text = rtxtMieuTa.Text = "";
        }

        private void btnTimDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimSanPham.Text.Trim()))
            {
                DataTable dt = khuyenMaiBUS.getAll();
                dtgKhuyenMai.DataSource = dt;
            }
            string keyword = txtTimSanPham.Text.Trim();
            DataTable kq = khuyenMaiBUS.searchKhuyenMai(keyword);
            dtgKhuyenMai.DataSource = kq;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "KhuyenMaiFile";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    try
                    {
                        ExportToExcelKhuyenMai(filePath);
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
        private void ExportToExcelKhuyenMai(string filePath)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("KhuyenMai");

            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dtgKhuyenMai.Columns.Count; i++)
            {
                headerRow.CreateCell(i).SetCellValue(dtgKhuyenMai.Columns[i].HeaderText);
            }

            for (int i = 0; i < dtgKhuyenMai.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dtgKhuyenMai.Columns.Count; j++)
                {
                    if (dtgKhuyenMai.Rows[i].Cells[j].Value != null)
                    {
                        row.CreateCell(j).SetCellValue(dtgKhuyenMai.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        row.CreateCell(j).SetCellValue("");
                    }
                }
            }

            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream);
            }
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeKhuyenMai thongKe = new frmThongKeKhuyenMai();
            thongKe.Show();
        }
    }
}
