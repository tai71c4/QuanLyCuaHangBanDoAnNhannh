using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyCuaHangBanDoAnNhanh
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
        public bool ExecuteQueryWithParams(string query, SqlParameter[] parameters)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                conn.Close();
                return false;
            }
        }
        public object ExecuteScalar(string query, SqlParameter[] parameters)
{
    object result = null;
    try
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddRange(parameters);
        result = cmd.ExecuteScalar();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Lỗi: " + ex.Message);
    }
    finally
    {
        conn.Close();
    }
    return result;
}
    }
}
