using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHTT.BUS;
using QLCHTT.GUI.DangNhap;
using QLCHTT.GUI.Main.Pages;
using QLCHTT.GUI.Pages;
using Sunny.UI;

namespace QLCHTT
{
    public partial class frmMain : UIAsideHeaderMainFrame
    {
        private string taiKhoan;
        DangNhapBUS dangNhapBUS;
        public static string maNhanVienDangNhap;
        public frmMain(string taiKhoan)
        {
            InitializeComponent();

            this.taiKhoan = taiKhoan;
            dangNhapBUS = new DangNhapBUS();
            KiemTraQuyen();


        }

        public string TaiKhoan
        {
            get { return taiKhoan; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTenDangNhap.Text = taiKhoan;
            maNhanVienDangNhap = dangNhapBUS.layMaNhanVien(taiKhoan);

        }

        private void KiemTraQuyen()
        {
            string chucVu = dangNhapBUS.layChucVu(taiKhoan);

            if (chucVu == "Nhân viên bán hàng")
            {
                int pageIndex = 1000;
                TreeNode root = Aside.CreateNode("QUẢN LÝ KHÁCH HÀNG", 61451, 24, pageIndex);

                pageIndex = 2000;
                root = Aside.CreateNode("QUẢN LÝ GIAO DỊCH", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmBanHang(), ++pageIndex));

                Aside.NodeMouseClick += Aside_NodeMouseClick;
            }
            if (chucVu == "Nhân viên quản lý hàng hóa")
            {
                int pageIndex = 1000;
                TreeNode root = Aside.CreateNode("QUẢN LÝ SẢN PHẨM", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmDanhMuc(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmSanPham(), ++pageIndex));
                Aside.NodeMouseClick += Aside_NodeMouseClick;

                pageIndex = 2000;
                root = Aside.CreateNode("QUẢN LÝ GIAO DỊCH", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmNhapHang(), ++pageIndex));
                Aside.NodeMouseClick += Aside_NodeMouseClick;
            }
            if (chucVu == "Nhân viên bảo hành")
            {
                int pageIndex = 1000;
                TreeNode root = Aside.CreateNode("QUẢN LÝ GIAO DỊCH", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmYeuCauBaoHanh(), ++pageIndex));
                Aside.NodeMouseClick += Aside_NodeMouseClick;
            }
            if (chucVu == "Nhân viên marketing")
            {
                int pageIndex = 1000;
                TreeNode root = Aside.CreateNode("KHUYẾN MÃI", 61451, 24, pageIndex);
                Aside.NodeMouseClick += Aside_NodeMouseClick;
            }
            if (chucVu == "Nhân viên thống kê")
            {
                int pageIndex = 8000;
                TreeNode root = Aside.CreateNode("BÁO CÁO DOANH THU", 61451, 24, pageIndex);

                Aside.NodeMouseClick += Aside_NodeMouseClick;
            }
            if (chucVu == "Quản lý")
            {
                int pageIndex = 1000;
                TreeNode root = Aside.CreateNode("QUẢN LÝ SẢN PHẨM", 61451, 24, pageIndex);

                Aside.CreateChildNode(root, AddPage(new frmDanhMuc(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmSanPham(), ++pageIndex));

                pageIndex = 2000;
                root = Aside.CreateNode("QUẢN LÝ KHÁCH HÀNG", 61451, 24, pageIndex);

                pageIndex = 3000;
                root = Aside.CreateNode("QUẢN LÝ GIAO DỊCH", 61451, 24, pageIndex);
                Aside.CreateChildNode(root, AddPage(new frmBanHang(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmNhapHang(), ++pageIndex));
                Aside.CreateChildNode(root, AddPage(new frmYeuCauBaoHanh(), ++pageIndex));

                pageIndex = 4000;
                root = Aside.CreateNode("KHUYẾN MÃI", 61451, 24, pageIndex);

                pageIndex = 5000;
                root = Aside.CreateNode("KHO HÀNG", 61451, 24, pageIndex);


                pageIndex = 7000;
                root = Aside.CreateNode("NHÂN VIÊN", 61451, 24, pageIndex);

                pageIndex = 8000;
                root = Aside.CreateNode("BÁO CÁO DOANH THU", 61451, 24, pageIndex);

                pageIndex = 9000;
                root = Aside.CreateNode("QUẢN LÝ GIAO HÀNG", 61451, 24, pageIndex);

                Aside.NodeMouseClick += Aside_NodeMouseClick;
            }
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Aside_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "NHÂN VIÊN")
            {

                var page = new frmNhanVien();
                AddPage(page, 7000);
                SelectPage(7000);
            }
            else if (e.Node.Text == "QUẢN LÝ KHÁCH HÀNG")
            {
                var page = new frmThongTinKhachHang();
                AddPage(page, 2000);
                SelectPage(2000);
            }
            else if (e.Node.Text == "QUẢN LÝ GIAO HÀNG")
            {
                var page = new frmGiaoHang();
                AddPage(page, 9000);
                SelectPage(9000);
            }
            else if (e.Node.Text == "KHO HÀNG")
            {
                var page = new frmTonKho();
                AddPage(page, 5000);
                SelectPage(5000);
            }
            else if (e.Node.Text == "BÁO CÁO DOANH THU")
            {
                var page = new frmBaoCaoDoanhThu();
                AddPage(page, 8000);
                SelectPage(8000);
            }
            else if (e.Node.Text == "KHUYẾN MÃI")
            {
                var page = new frmKhuyenMai();
                AddPage(page, 4000);
                SelectPage(4000);
            }
        }

        private void avaNhanVien_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien nv = new frmThongTinNhanVien();
            nv.ShowDialog();
        }

        private void avaNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                ToolStripMenuItem logoutItem = new ToolStripMenuItem("Đăng xuất");

                logoutItem.Click += (s, ev) =>
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();

                        frmDangNhap loginForm = new frmDangNhap();
                        loginForm.Show();
                    }
                };
                menu.Items.Add(logoutItem);
                menu.Show(avaNhanVien, new System.Drawing.Point(e.X, e.Y));
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}