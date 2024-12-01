using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Mem_Quan_Ly
{
    internal class DataConnect
    {
        public static string GetConnectionString()
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                Console.WriteLine(AppDomain.CurrentDomain.GetData("DataDirectory"));
                return conn;
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Lỗi cấu hình: " + ex.Message);
                return null;
            }

        }

        public static SqlConnection CreateConnection()
        {
            try
            {
                string connectionString = GetConnectionString();
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception("Chuỗi kết nối không hợp lệ hoặc không tìm thấy.");
                }
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                return null;
            }
        }
        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Đã đóng kết nối");
            }
        }
    }
}
