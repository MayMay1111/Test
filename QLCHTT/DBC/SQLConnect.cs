using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanHangTheThao.DAO
{
    internal class SQLConnect
    {
        SqlConnection connect;
        public static string connectString = "Data Source=LAPTOP-6P25OEGD\\SQLSERVER;Initial Catalog=QuanLyCuaHangDienTu2;Integrated Security=True;";
        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public SQLConnect()
        {
            Connect = new SqlConnection(connectString);
        }
        public void open()
        {
            if (Connect.State == ConnectionState.Closed)
                Connect.Open();
        }
        public void close()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
        }
        public DataTable getDataTable(string conStr)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(conStr, Connect);
            da.Fill(dt);
            return dt;
        }
        public int updateDatabase(string selStr, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(selStr, Connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
        public object GetData(string conStr)
        {
            SqlCommand cmd;
            open();
            cmd = new SqlCommand(conStr, Connect);
            object data = cmd.ExecuteScalar();
            close();
            return data;
        }
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                open();
                SqlCommand cmd = new SqlCommand(query, Connect);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                close();
            }
        }

        public bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                open();
                cmd.Connection = Connect;
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            finally
            {
                close();
            }
        }



    }
}
