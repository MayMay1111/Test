using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using QLCHTT.BUS;
using QLCHTT.DAO;
using QLCHTT.GUI.Main;
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

namespace QLCHTT.GUI.Pages
{
    public partial class frmYeuCauBaoHanh : UIPage
    {
        YeuCauBaoHanhBUS yeuCauBaoHanhBUS;
        HoaDonBUS hoaDonBUS;
        SanPhamBUS sanPhamBUS;
        public frmYeuCauBaoHanh()
        {
            InitializeComponent();
            yeuCauBaoHanhBUS = new YeuCauBaoHanhBUS();
            hoaDonBUS = new HoaDonBUS();
            sanPhamBUS = new SanPhamBUS();

            loadMaHD();
            loadForm();
            cbTrangThai.SelectedIndex = 0;
        }
        private void loadMaHD()
        {
            cbMaHoaDon.DataSource = null;
            DataTable dt = hoaDonBUS.getAll();
            cbMaHoaDon.DataSource = dt;
            cbMaHoaDon.ValueMember = "MaHoaDon";
            cbMaHoaDon.DisplayMember = "MaHoaDon";
            loadSanPham();
        }
        private void loadSanPham()
        {
            cbSanPham.DataSource = null;
            if (cbMaHoaDon.SelectedValue != null)
            {
                string maHoaDon = cbMaHoaDon.SelectedValue.ToString();
                DataTable sp = hoaDonBUS.laySanPhamTuHoaDon(maHoaDon);
                if (sp != null && sp.Rows.Count > 0)
                {
                    cbSanPham.DataSource = sp;
                    cbSanPham.ValueMember = "MaSanPham";
                    cbSanPham.DisplayMember = "TenSanPham";
                    cbSanPham.SelectedIndex = 0;
                    loadMaVach();
                    baoHanhHopLe(DateTime.Parse(txtNgayMua.Text));
                }
                else
                {

                    cbSanPham.DataSource = null;
                    txtMaVach.Text = string.Empty;
                }
            }
        }

        private void loadMaVach()
        {
            if (cbSanPham.SelectedValue != null)
            {
                string maSanPham = cbSanPham.SelectedValue.ToString();
                string maVach = sanPhamBUS.layMaVach(maSanPham);
                if (maVach != null)
                {
                    txtMaVach.Text = maVach;
                }
                else
                {

                    txtMaVach.Text = string.Empty;
                }
            }
        }


        private void loadForm()
        {
            DataTable dt = yeuCauBaoHanhBUS.getAll();
            dtgBaoHanh.DataSource = dt;

            if (dtgBaoHanh.Columns.Count > 0)
            {
                dtgBaoHanh.Columns[0].HeaderText = "Mã yêu cầu";
                dtgBaoHanh.Columns[1].HeaderText = "Mã hóa đơn";
                dtgBaoHanh.Columns[2].HeaderText = "Mã sản phẩm";
                dtgBaoHanh.Columns[3].HeaderText = "Ngày yêu cầu";
                dtgBaoHanh.Columns[4].HeaderText = "Lý do";
                dtgBaoHanh.Columns[5].HeaderText = "Trạng thái";

            }
        }

        private void frmBaoHanh_Initialize(object sender, EventArgs e)
        {
            loadMaHD();
            loadSanPham();
        }

        private void cbMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaHoaDon.SelectedItem != null)
            {
                DataRowView selectedRow = cbMaHoaDon.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    string maHoaDon = selectedRow["MaHoaDon"].ToString();
                    DateTime ngayMuaa = hoaDonBUS.layNgayMua(maHoaDon);
                    txtNgayMua.Text = ngayMuaa.ToString();

                }

            }
            loadSanPham();
            DateTime ngayMua;
            if (DateTime.TryParse(txtNgayMua.Text, out ngayMua))
            {
                baoHanhHopLe(ngayMua);
            }


        }

        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMaVach();
            DateTime ngayMua;
            if (DateTime.TryParse(txtNgayMua.Text, out ngayMua))
            {
                baoHanhHopLe(ngayMua);
            }
        }

        private void btnThemYeuCauBH_Click(object sender, EventArgs e)
        {
            string maHoaDon = cbMaHoaDon.Text.Trim();
            string maSanPham = cbSanPham.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maHoaDon) || string.IsNullOrEmpty(maSanPham) || string.IsNullOrEmpty(cbTrangThai.Text) || string.IsNullOrEmpty(rtxtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm yêu cầu bảo hành sản phẩm " +cbSanPham.Text + " cho hóa đơn {cbMaHoaDon.Text}?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (errorHanBaoHanh.GetError(cbSanPham) != string.Empty)
                {
                    MessageBox.Show("Không thể thêm yêu cầu bảo hành vì sản phẩm đã hết hạn bảo hành.");
                    return;
                }
                else
                {
                    string lyDo = rtxtLyDo.Text.Trim();
                    string trangThai = cbTrangThai.Text.Trim();
                    if (yeuCauBaoHanhBUS.addYeuCauBaoHanh(maHoaDon, maSanPham, DateTime.Now, lyDo, trangThai))
                    {
                        MessageBox.Show("Thêm yêu cầu bảo hành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm yêu cầu bảo hành thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private bool checkConBaoHanh(DateTime ngayMua, int thoiGianBaoHanh)
        {
            DateTime hetHanBaoHanh = ngayMua.AddMonths(thoiGianBaoHanh);
            return DateTime.Now > hetHanBaoHanh;
        }
        private void baoHanhHopLe(DateTime ngayMua)
        {
            if (cbSanPham.SelectedValue != null)
            {
                string maSanPham = cbSanPham.SelectedValue.ToString();
                int thoiGianBaoHanh = sanPhamBUS.layThoiGianBaoHanh(maSanPham);
                if (checkConBaoHanh(ngayMua, thoiGianBaoHanh))
                {
                    errorHanBaoHanh.SetError(cbSanPham, "Sản phẩm hết hạn bảo hành");
                }
                else
                {
                    errorHanBaoHanh.SetError(cbSanPham, string.Empty);
                }
            }
        }

        private void dtgBaoHanh_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgBaoHanh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgBaoHanh.SelectedRows[0];
                string maHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();
                string maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();
                DateTime ngayYeuCau = DateTime.Parse(selectedRow.Cells["NgayYeuCau"].Value.ToString());
                string lyDo = selectedRow.Cells["LyDo"].Value.ToString();
                string trangThai = selectedRow.Cells["TrangThai"].Value.ToString();

                cbMaHoaDon.SelectedValue = maHoaDon;
                cbSanPham.SelectedValue = maSanPham;
                txtNgayYeuCau.Text = ngayYeuCau.ToString("dd/MM/yyyy");
                rtxtLyDo.Text = lyDo;
                cbTrangThai.SelectedItem = trangThai;
            }
        }

        private void btnXoaYeuCauBH_Click(object sender, EventArgs e)
        {
            if (dtgBaoHanh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgBaoHanh.SelectedRows[0];
                string maYeuCau = selectedRow.Cells["MaYeuCauBaoHanh"].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa yêu cầu bảo hành "+maYeuCau +"?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (yeuCauBaoHanhBUS.deleteYeuCauBaoHanh(maYeuCau))
                    {
                        MessageBox.Show("Xóa yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadForm();
                        loadSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Xóa yêu cầu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn yêu cầu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaYeuCauBH_Click(object sender, EventArgs e)
        {
            if (dtgBaoHanh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgBaoHanh.SelectedRows[0];
                string maYeuCau = selectedRow.Cells["MaYeuCauBaoHanh"].Value.ToString();
                string trangThai = cbTrangThai.SelectedItem.ToString();


                if (string.IsNullOrEmpty(cbMaHoaDon.Text) || string.IsNullOrEmpty(cbSanPham.Text) || string.IsNullOrEmpty(cbTrangThai.Text) || string.IsNullOrEmpty(rtxtLyDo.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa trạng thái cho yêu cầu "+maYeuCau+"?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (yeuCauBaoHanhBUS.updateYeuCauBaoHanh(maYeuCau, trangThai))
                        {
                            MessageBox.Show("Sửa trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadForm();
                        }
                        else
                        {
                            MessageBox.Show("Sửa trạng thái thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void btnReloadYCBH_Click(object sender, EventArgs e)
        {
            loadForm();
            cbMaHoaDon.Text = "";
            cbSanPham.Text = "";
            cbTrangThai.Text = "";
            txtNgayYeuCau.Text = DateTime.Now.ToString();
            txtNgayMua.Text = "";
            txtMaVach.Text = "";
            rtxtLyDo.Text = "";
        }

        private void btnTimDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimSanPham.Text.Trim()))
            {
                DataTable dt = yeuCauBaoHanhBUS.getAll();
                dtgBaoHanh.DataSource = dt;
            }
            string keyword = txtTimSanPham.Text.Trim();
            DataTable kq = yeuCauBaoHanhBUS.searchYeuCauBaoHanh(keyword);
            dtgBaoHanh.DataSource = kq;
        }

        private void btnExportYCBH_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "YeuCauBaoHanhFile";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    try
                    {
                        ExportExcelYeuCauBaoHanh(filePath);
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
        private void ExportExcelYeuCauBaoHanh(string filePath)
        {
            IWorkbook wb = new XSSFWorkbook();
            ISheet sheet = wb.CreateSheet("YeuCauBaoHanh");

            IRow rowhead = sheet.CreateRow(0);
            for (int i = 0; i < dtgBaoHanh.Columns.Count; i++)
            {
                rowhead.CreateCell(i).SetCellValue(dtgBaoHanh.Columns[i].HeaderText);
            }

            for (int i = 0; i < dtgBaoHanh.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dtgBaoHanh.Columns.Count; j++)
                {
                    if (dtgBaoHanh.Rows[i].Cells[j].Value != null)
                    {
                        row.CreateCell(j).SetCellValue(dtgBaoHanh.Rows[i].Cells[j].Value.ToString());
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
        bool daIn = false;
        private void btnInDonBaoHanh_Click(object sender, EventArgs e)
        {
            if (dtgBaoHanh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgBaoHanh.SelectedRows[0];
                string maBaoHanh = selectedRow.Cells["MaYeuCauBaoHanh"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn in đơn bảo hành "+maBaoHanh+ "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable dt = yeuCauBaoHanhBUS.inYeuCauBaoHanh(maBaoHanh);
                    if (dt == null || dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để in đơn bảo hành.");
                        return;
                    }
                    else
                    {
                        inHoaDonBaoHanh(maBaoHanh);
                        daIn = true;
                        if (daIn)
                        {
                            MessageBox.Show("In đơn bảo hành thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void inHoaDonBaoHanh(string ma)
        {
            DataTable dt = yeuCauBaoHanhBUS.inYeuCauBaoHanh(ma);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn.");
                return;
            }
            else
            {
                rptInHoaDonBaoHanh rpBaoHanh = new rptInHoaDonBaoHanh();
                rpBaoHanh.SetDataSource(dt);

                frmInDonBaoHanh inDonBaoHanh = new frmInDonBaoHanh();
                inDonBaoHanh.crystalReportViewer1.ReportSource = rpBaoHanh;

                inDonBaoHanh.FormClosed += (s, e) =>
                {
                    daIn = true;
                };

                inDonBaoHanh.ShowDialog();
            }
        }
    }
}
