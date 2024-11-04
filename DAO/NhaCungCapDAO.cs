using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCHTT.Utils;

namespace QLCHTT.DAO
{
    public class NhaCungCapDAO
    {
        QLCHTTDataContext QLCHTT;
        public NhaCungCapDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }
        public DataTable getAll()
        {
            var result = from ncc in QLCHTT.NhaCungCaps
                         select ncc;
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

        public bool addNhaCungCap(string tenNhaCungCap, string nguoiLienHe, string diaChi, string soDienThoai)
        {
            var newNhaCungCap = new NhaCungCap
            {
                TenNhaCungCap = tenNhaCungCap,
                NguoiLienHe = nguoiLienHe,
                DiaChi = diaChi,
                SoDienThoai = soDienThoai,
            };

            QLCHTT.NhaCungCaps.InsertOnSubmit(newNhaCungCap);
            QLCHTT.SubmitChanges();
            return true;
        }

        public bool updateNhaCungCap(int maNhaCungCap, string tenNhaCungCap, string nguoiLienHe, string diaChi, string soDienThoai)
        {
            var nhaCungCap = QLCHTT.NhaCungCaps.SingleOrDefault(ncc => ncc.MaNhaCungCap == maNhaCungCap);
            if (nhaCungCap == null) return false;

            nhaCungCap.TenNhaCungCap = tenNhaCungCap;
            nhaCungCap.NguoiLienHe = nguoiLienHe;
            nhaCungCap.DiaChi = diaChi;
            nhaCungCap.SoDienThoai = soDienThoai;

            QLCHTT.SubmitChanges();
            return true;
        }

        public bool deleteNhaCungCap(int maNhaCungCap)
        {
            var nhaCungCap = QLCHTT.NhaCungCaps.SingleOrDefault(ncc => ncc.MaNhaCungCap == maNhaCungCap);
            if (nhaCungCap == null) return false;

            QLCHTT.NhaCungCaps.DeleteOnSubmit(nhaCungCap);
            QLCHTT.SubmitChanges();
            return true;
        }

        public DataTable searchNhaCungCap(string key)
        {
            var result = from ncc in QLCHTT.NhaCungCaps
                         where ncc.TenNhaCungCap.Contains(key)
                            || ncc.MaNhaCungCap.ToString().Contains(key)
                            || ncc.NguoiLienHe.Contains(key)
                            || ncc.SoDienThoai.Contains(key)
                            || ncc.DiaChi.Contains(key)
                         select ncc;
            return ToDataTableUtils.ToDataTable(result.ToList());
        }

    }
}
