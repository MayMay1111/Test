using Microsoft.SqlServer.Server;
using QuanLyBanHangTheThao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.DAO
{
    public class DanhMucDAO
    {
        QLCHTTDataContext QLCHTT;

        public DanhMucDAO()
        {
            QLCHTT = new QLCHTTDataContext();
        }

        public DataTable getAll()
        {
            var query = from dm in QLCHTT.DanhMucs
                        select dm;

            return ToDataTable(query.ToList());
        }

        public bool addDanhMuc(string tenDanhMuc, string moTa)
        {
            DanhMuc newDanhMuc = new DanhMuc
            {
                TenDanhMuc = tenDanhMuc,
                MoTa = moTa
            };

            QLCHTT.DanhMucs.InsertOnSubmit(newDanhMuc);
            QLCHTT.SubmitChanges();

            return true; // Always true
        }

        public bool updateDanhMuc(int maDanhMuc, string tenDanhMuc, string moTa)
        {
            var danhMucToUpdate = QLCHTT.DanhMucs.SingleOrDefault(dm => dm.MaDanhMuc == maDanhMuc);
            if (danhMucToUpdate != null)
            {
                danhMucToUpdate.TenDanhMuc = tenDanhMuc;
                danhMucToUpdate.MoTa = moTa;
                QLCHTT.SubmitChanges();
                return true;
            }

            return false; // Not found
        }

        public bool deleteDanhMuc(int maDanhMuc)
        {
            var danhMucToDelete = QLCHTT.DanhMucs.SingleOrDefault(dm => dm.MaDanhMuc == maDanhMuc);
            if (danhMucToDelete != null)
            {
                QLCHTT.DanhMucs.DeleteOnSubmit(danhMucToDelete);
                QLCHTT.SubmitChanges();
                return true;
            }

            return false; // Not found
        }

        public DataTable searchDanhMuc(string key)
        {
            var query = from dm in QLCHTT.DanhMucs
                        where dm.TenDanhMuc.Contains(key) || dm.MaDanhMuc.ToString().Contains(key)
                        select dm;

            return ToDataTable(query.ToList());
        }

        public int tongSanPham(int maDanhMuc)
        {
            var totalProducts = (from dm in QLCHTT.DanhMucs
                                 join sp in QLCHTT.SanPhams on dm.MaDanhMuc equals sp.MaDanhMuc into grouped
                                 where dm.MaDanhMuc == maDanhMuc
                                 select grouped.Count()).FirstOrDefault();

            return totalProducts;
        }
        private DataTable ToDataTable(List<DanhMuc> danhMucs)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("MaDanhMuc", typeof(int));
            dataTable.Columns.Add("TenDanhMuc", typeof(string));
            dataTable.Columns.Add("MoTa", typeof(string));

            foreach (var item in danhMucs)
            {
                var row = dataTable.NewRow();
                row["MaDanhMuc"] = item.MaDanhMuc;
                row["TenDanhMuc"] = item.TenDanhMuc;
                row["MoTa"] = item.MoTa;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
