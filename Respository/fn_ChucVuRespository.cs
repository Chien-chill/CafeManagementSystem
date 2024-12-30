using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_ChucVuRespository
    {
        public static List<ChucVu> GetAllChucVu()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiChucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ChucVu> CVList = new List<ChucVu>();
                            while (reader.Read())
                            {
                                ChucVu cv = new ChucVu();
                                cv.MaCV = reader["Ma_CV"].ToString();
                                cv.TenCV = reader["Ten_CV"].ToString();
                                cv.SoLuong = Convert.ToInt16(reader["SoLuong"]);
                                CVList.Add(cv);
                            }
                            return CVList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetAllChucVu: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetAllChucVu: " + ex.Message);
                return null;
            }
        }
        public static ChucVu GetQuyenChucVu(string MaCV)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiQuyenCV", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_CV", MaCV);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ChucVu cv = new ChucVu();
                            while (reader.Read())
                            {
                                cv.MaCV = reader["Ma_CV"].ToString();
                                cv.TenCV = reader["Ten_CV"].ToString();
                                cv.ThaoTacChucVu = Convert.ToInt16(reader["ThaoTacChucVu"]);
                                cv.ThaoTacNhanVien = Convert.ToInt16(reader["ThaoTacNhanVien"]);
                                cv.ThaoTacSanPham = Convert.ToInt16(reader["ThaoTacSanPham"]);
                                cv.ThaoTacDonHang = Convert.ToInt16(reader["ThaoTacDonHang"]);
                                cv.ThaoTacKhachHang = Convert.ToInt16(reader["ThaoTacKhachHang"]);
                                cv.ThaoTacSuKien = Convert.ToInt16(reader["ThaoTacSuKien"]);
                                cv.ThaoTacThongKe = Convert.ToInt16(reader["ThaoTacThongKe"]);
                            }
                            return cv;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetQuyenChucVu: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetQuyenChucVu: " + ex.Message);
                return null;
            }
        }
        public static bool AddChucVu(ChucVu cv)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemChucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ten_CV", cv.TenCV);
                        cmd.Parameters.AddWithValue("@ThaoTacSanPham", cv.ThaoTacSanPham);
                        cmd.Parameters.AddWithValue("@ThaoTacSuKien", cv.ThaoTacSuKien);
                        cmd.Parameters.AddWithValue("@ThaoTacKhachHang", cv.ThaoTacKhachHang);
                        cmd.Parameters.AddWithValue("@ThaoTacNhanVien", cv.ThaoTacNhanVien);
                        cmd.Parameters.AddWithValue("@ThaoTacChucVu", cv.ThaoTacChucVu);
                        cmd.Parameters.AddWithValue("@ThaoTacThongKe", cv.ThaoTacThongKe);
                        cmd.Parameters.AddWithValue("@ThaoTacDonHang", cv.ThaoTacDonHang);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL AddChucVu: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi AddChucVu: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateChucVu(ChucVu cv)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SuaChucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_CV", cv.MaCV);
                        cmd.Parameters.AddWithValue("@Ten_CV", cv.TenCV);
                        cmd.Parameters.AddWithValue("@ThaoTacSanPham", cv.ThaoTacSanPham);
                        cmd.Parameters.AddWithValue("@ThaoTacSuKien", cv.ThaoTacSuKien);
                        cmd.Parameters.AddWithValue("@ThaoTacKhachHang", cv.ThaoTacKhachHang);
                        cmd.Parameters.AddWithValue("@ThaoTacNhanVien", cv.ThaoTacNhanVien);
                        cmd.Parameters.AddWithValue("@ThaoTacChucVu", cv.ThaoTacChucVu);
                        cmd.Parameters.AddWithValue("@ThaoTacThongKe", cv.ThaoTacThongKe);
                        cmd.Parameters.AddWithValue("@ThaoTacDonHang", cv.ThaoTacDonHang);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UpdateChucVu: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UpdateChucVu: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteChucVu(ChucVu cv)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XoaChucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_CV", cv.MaCV);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL DeleteChucVu: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi DeleteChucVu: " + ex.Message);
                return false;
            }
        }
    }
}
