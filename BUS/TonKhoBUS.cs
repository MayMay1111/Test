using QLCHTT.DAO;
using QuanLyBanHangTheThao.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHTT.BUS
{
    internal class TonKhoBUS
    {
        TonKhoDAO tonKhoDAO;
        public TonKhoBUS()
        {
            tonKhoDAO = new TonKhoDAO();
        }
        public DataTable getAll()
        {
            return tonKhoDAO.GetTonKhoData();
        }
        public DataTable timTonKho(string key)
        {
            return tonKhoDAO.timTonKho(key);
        }
        public DataTable Intonkho()
        {
            return tonKhoDAO.Intonkho();
        }
    }
}
