using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_TaiKhoanRespository
    {
        public static List<TaiKhoan> GetAllTaiKhoan()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<TaiKhoan> TKList = new List<TaiKhoan>();
                            while (reader.Read())
                            {
                                TaiKhoan tk = new TaiKhoan();
                                tk.Tai_Khoan = reader["Tai_Khoan"].ToString();
                                tk.Mat_Khau = reader["Mat_Khau"].ToString();
                                tk.Ma_NV = reader["Ma_NV"].ToString();
                                TKList.Add(tk);
                            }
                            return TKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetAllTaiKhoan: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetAllTaiKhoan: " + ex.Message);
                return null;
            }
        }
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
                                    nv.MaCV = reader["Ma_CV"].ToString();
                                    nv.TenCV = reader["Ten_CV"].ToString();
                                    nv.MaNV = reader["Ma_NV"].ToString();
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
        public static bool AddTaiKhoan(TaiKhoan tk)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_TaoTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Tai_Khoan", tk.Tai_Khoan);
                        cmd.Parameters.AddWithValue("@Mat_Khau", tk.Mat_Khau);
                        cmd.Parameters.AddWithValue("@Ma_NV", tk.Ma_NV);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL AddTaiKhoan: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi AddTaiKhoan: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateTaiKhoan(TaiKhoan tk)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SuaTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Tai_Khoan", tk.Tai_Khoan);
                        cmd.Parameters.AddWithValue("@Mat_Khau", tk.Mat_Khau);
                        cmd.Parameters.AddWithValue("@Ma_NV", tk.Ma_NV);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UpdateTaiKhoan: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UpdateTaiKhoan: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteTaiKhoan(TaiKhoan tk)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XoaTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Tai_Khoan", tk.Tai_Khoan);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL DeleteTaiKhoan: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi DeleteTaiKhoan: " + ex.Message);
                return false;
            }
        }
    }
}
