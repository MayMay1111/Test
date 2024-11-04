using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrypt;

namespace QLCHTT.DAO
{
    public class DangNhapDAO
    {
        QLCHTTDataContext QLCHTT;

        public DangNhapDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }

        public bool DangNhap(string taiKhoan, string matKhau)
        {
            try
            {
                // Use LINQ to check for the user in the NhanVien table
                var userCount = QLCHTT.NhanViens
                    .Count(nv => nv.TaiKhoan == taiKhoan && nv.MatKhau == matKhau);

                return userCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string MaHoaMatKhau(string matKhau)
        {
            ScryptEncoder scryptEncoder = new ScryptEncoder();
            return scryptEncoder.Encode(matKhau);
        }

        // Uncomment and refactor this method to use LINQ if needed
        // public void TaoTaiKhoan(string taiKhoan, string matKhau, string tenNhanVien, string soDienThoai, string email, string chucVu)
        // {
        //     try
        //     {
        //         string hashedPassword = MaHoaMatKhau(matKhau);
        //         NhanVien newNhanVien = new NhanVien
        //         {
        //             TaiKhoan = taiKhoan,
        //             MatKhau = hashedPassword,
        //             TenNhanVien = tenNhanVien,
        //             SoDienThoai = soDienThoai,
        //             Email = email,
        //             ChucVu = chucVu
        //         };
        //         QLCHTT.NhanVien.InsertOnSubmit(newNhanVien);
        //         QLCHTT.SubmitChanges();
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //     }
        // }

        public string layChucVu(string taiKhoan)
        {
            // Use LINQ to fetch the ChucVu for the provided TaiKhoan
            return QLCHTT.NhanViens
                .Where(nv => nv.TaiKhoan == taiKhoan)
                .Select(nv => nv.ChucVu)
                .FirstOrDefault();
        }

        public string layMaNhanVien(string taiKhoan)
        {
            // Use LINQ to fetch the MaNhanVien for the provided TaiKhoan
            return QLCHTT.NhanViens
                .Where(nv => nv.TaiKhoan == taiKhoan)
                .Select(nv => nv.MaNhanVien)
                .FirstOrDefault();
        }

        public string layTenNhanVienTuMa(string ma)
        {
            return QLCHTT.NhanViens
                .Where(nv => nv.MaNhanVien == ma)
                .Select(nv => nv.TenNhanVien)
                .FirstOrDefault();
        }

    }
}
