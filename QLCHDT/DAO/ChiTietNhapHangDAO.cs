using QuanLyBanHangDienTu.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDT.DAO
{
    public class ChiTietNhapHangDAO
    {
        SQLConnect connect;
        public ChiTietNhapHangDAO()
        {
            connect = new SQLConnect();
        }
        public DataTable getAll(string maDonDatHang)
        {
            string query = string.Format("SELECT * FROM ChiTietDonDatHangNhaCungCap WHERE MaDonDatHang = '{0}'", maDonDatHang);
            return connect.getDataTable(query);
        }

        public bool addChiTietDonNhapHang(string maDonDatHang, string maSanPham, int soLuong, int donGia, out string errorMessage)
        {
            errorMessage = string.Empty;
            string queryCheck = string.Format("SELECT COUNT(*) FROM ChiTietDonDatHangNhaCungCap WHERE MaDonDatHang = '{0}' AND MaSanPham = '{1}'", maDonDatHang, maSanPham);
            int count = (int)connect.GetData(queryCheck);

            if (count > 0)
            {
                string queryCheckTonTai = string.Format("SELECT DonGia FROM ChiTietDonDatHangNhaCungCap WHERE MaDonDatHang = '{0}' AND MaSanPham = '{1}'", maDonDatHang, maSanPham);
                int tonTaiDonGia = (int)connect.GetData(queryCheckTonTai);

                if (tonTaiDonGia != donGia)
                {
                    errorMessage = "Đơn giá không khớp với đơn giá đã lưu. Vui lòng kiểm tra lại.";
                    return false;
                }
                else
                {
                    string querySoLuong = string.Format("UPDATE ChiTietDonDatHangNhaCungCap SET SoLuong = SoLuong + {0}, ThanhTien = (SoLuong + {0}) * DonGia WHERE MaDonDatHang = '{1}' AND MaSanPham = '{2}'", soLuong, maDonDatHang, maSanPham);
                    return connect.ExecuteNonQuery(querySoLuong);
                }
            }
            else
            {
                string queryAdd = string.Format("INSERT INTO ChiTietDonDatHangNhaCungCap (MaDonDatHang, MaSanPham, SoLuong, DonGia, ThanhTien) VALUES ('{0}', '{1}', {2}, {3}, {4})", maDonDatHang, maSanPham, soLuong, donGia, soLuong * donGia);
                return connect.ExecuteNonQuery(queryAdd);
            }
        }



    }
}
