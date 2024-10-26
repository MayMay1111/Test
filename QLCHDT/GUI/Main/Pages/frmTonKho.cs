using QLCHDT.BUS;
using QLCHDT.DAO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using QLCHDT.GUI.Report;

namespace QLCHDT.GUI.Main.Pages
{
    public partial class frmTonKho : UIPage
    {
        TonKhoBUS tonKhoBUS;

        public frmTonKho()
        {
            InitializeComponent();
            tonKhoBUS = new TonKhoBUS();
            LoadDataDanhMuc();
        }
        private void LoadDataDanhMuc()
        {
            try
            {
                DataTable dtDanhMuc = tonKhoBUS.getAll();
                dgvtonkho.DataSource = dtDanhMuc;

                if (dgvtonkho.Columns.Count > 0)
                {
                    dgvtonkho.Columns[0].HeaderText = "Mã sản phẩm";
                    dgvtonkho.Columns[1].HeaderText = "Tên sản phẩm";
                    dgvtonkho.Columns[2].HeaderText = "Số lượng nhập";
                    dgvtonkho.Columns[3].HeaderText = "Số lượng xuất";
                    dgvtonkho.Columns[4].HeaderText = "Số lượng trả";

                }
                dgvtonkho.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvtonkho_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtonkho.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvtonkho.SelectedRows[0];
                txttensp.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtsoluongnhap.Text = selectedRow.Cells["SoLuongNhap"].Value.ToString();      
                txtsoluongxuat.Text = selectedRow.Cells["SoLuongXuat"].Value.ToString();
                int soluongnhap = int.Parse(selectedRow.Cells["SoLuongNhap"].Value.ToString());
                int soluongxuat = int.Parse(selectedRow.Cells["SoLuongXuat"].Value.ToString());
                int soluongtra = int.Parse(selectedRow.Cells["SoLuongTraHang"].Value.ToString());
                int soluongcon = soluongnhap - soluongxuat + soluongtra;
                txtsoluongcon.Text = soluongcon.ToString();


            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttim.Text))
            {
                DataTable dt = tonKhoBUS.getAll();
                dgvtonkho.DataSource = dt;
            }
            else
            {
                string keyword = txttim.Text.Trim();
                DataTable result = tonKhoBUS.timTonKho(keyword);
                dgvtonkho.DataSource = result;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            inPhieuTon();
        }
        private void inPhieuTon()
        {
        
            DataTable dt = tonKhoBUS.Intonkho();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn.");
                return;
            }
            else
            {
                rptTonKho giaoHang = new rptTonKho();
                giaoHang.SetDataSource(dt);

                frmInPhieuTon inPhieuGiao = new frmInPhieuTon();

                inPhieuGiao.reportTonKho.ReportSource = giaoHang;

                inPhieuGiao.ShowDialog(); 
            }
        }

        private void frmTonKho_Initialize(object sender, EventArgs e)
        {
            LoadDataDanhMuc();
        }
    }
}
