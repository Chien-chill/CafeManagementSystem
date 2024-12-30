using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_NhanVienRespository
    {
        public static List<NhanVien> GetAllNhanVien()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiNV", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<NhanVien> NVList = new List<NhanVien>();
                            while (reader.Read())
                            {
                                NhanVien nv = new NhanVien();
                                nv.MaNV = reader["Ma_NV"].ToString();
                                nv.TenNV = reader["Ten_NV"].ToString();
                                nv.CCCD = reader["CCCD"].ToString();
                                nv.SDT = reader["SDT"].ToString();
                                nv.GioiTinh = reader["Gioi_Tinh"].ToString();
                                nv.NgaySinh = reader["Ngay_Sinh"].ToString().Split(' ')[0];
                                nv.DiaChi = reader["Dia_Chi"].ToString();
                                nv.AnhNV = (byte[])reader["Anh_NV"];
                                nv.MaCV = reader["Ma_CV"].ToString();
                                nv.TenCV = reader["Ten_CV"].ToString();
                                NVList.Add(nv);
                            }
                            return NVList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetAllNhanVien: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetAllNhanVien: " + ex.Message);
                return null;
            }
        }

        public static bool AddNhanVien(NhanVien nv)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ten_NV", nv.TenNV);
                        cmd.Parameters.AddWithValue("@Anh_NV", nv.AnhNV);
                        cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                        cmd.Parameters.AddWithValue("@Ngay_Sinh", nv.NgaySinh);
                        cmd.Parameters.AddWithValue("@Gioi_Tinh", nv.GioiTinh);
                        cmd.Parameters.AddWithValue("@Dia_Chi", nv.DiaChi);
                        cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                        cmd.Parameters.AddWithValue("@Ma_CV", nv.MaCV);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL AddNhanVien: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi AddNhanVien: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateNV(NhanVien nv)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SuaNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_NV", nv.MaNV);
                        cmd.Parameters.AddWithValue("@Ten_NV", nv.TenNV);
                        cmd.Parameters.AddWithValue("@Anh_NV", nv.AnhNV);
                        cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                        cmd.Parameters.AddWithValue("@Ngay_Sinh", nv.NgaySinh);
                        cmd.Parameters.AddWithValue("@Gioi_Tinh", nv.GioiTinh);
                        cmd.Parameters.AddWithValue("@Dia_Chi", nv.DiaChi);
                        cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                        cmd.Parameters.AddWithValue("@Ma_CV", nv.MaCV);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UpdateNV: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UpdateNV: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteNV(NhanVien nv)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XoaNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_NV", nv.MaNV);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL DeleteNV:" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi DeleteNV:" + ex.Message);
                return false;
            }
        }
    }
}
