using Phan_Mem_Quan_Ly.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_TaiKhoanRespository
    {
        public static NhanVien CheckTaiKhoan(TaiKhoan tk)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_KiemTraTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Tai_Khoan", tk.Tai_Khoan);
                        cmd.Parameters.AddWithValue("@Mat_Khau", tk.Mat_Khau);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                NhanVien nv = new NhanVien();
                                while (reader.Read())
                                {
                                    nv.TenNV = reader["Ten_NV"].ToString();
                                    nv.AnhNV = (byte[])reader["Anh_NV"];
                                }
                                return nv;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL CheckTaiKhoan: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi CheckTaiKhoan: " + ex.Message);
                return null;
            }
        }
    }
}
