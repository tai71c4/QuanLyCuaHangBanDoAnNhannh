using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace demo
{
    public class Database
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyCuaHangBanDoAnNhanh;Integrated Security=True";
        private SqlConnection conn;

        public Database()
        {
            conn = new SqlConnection(connectionString);
        }

        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetDanhSachMon()
        {
            string query = "SELECT TenSanPham, Gia FROM SanPham";
            return GetData(query);
        }
        public bool ExecuteQuery(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
}
