using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_KhachHangRespository
    {
        public static List<KhachHang> GetAllKhachHang()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<KhachHang> KHList = new List<KhachHang>();
                            while (reader.Read())
                            {
                                KhachHang kh = new KhachHang();
                                kh.MaKH = reader["Ma_KH"].ToString();
                                kh.TenKH = reader["Ten_KH"].ToString();
                                kh.NgaySinh = reader["Ngay_Sinh"].ToString().Split(' ')[0];
                                kh.GioiTinh = reader["Gioi_Tinh"].ToString();
                                kh.DiaChi = reader["Dia_Chi"].ToString();
                                kh.SDT = reader["SDT"].ToString();
                                KHList.Add(kh);
                            }
                            return KHList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetAllKhachHang: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetAllKhachHang: " + ex.Message);
                return null;
            }
        }

        public static bool AddKhachHang(KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ten_KH", kh.TenKH);
                        cmd.Parameters.AddWithValue("@Ngay_Sinh", kh.NgaySinh);
                        cmd.Parameters.AddWithValue("@Gioi_Tinh", kh.GioiTinh);
                        cmd.Parameters.AddWithValue("@Dia_Chi", kh.DiaChi);
                        cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL AddKhachHang: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi AddKhachHang: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateKH(KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SuaKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_KH", kh.MaKH);
                        cmd.Parameters.AddWithValue("@Ten_KH", kh.TenKH);
                        cmd.Parameters.AddWithValue("@Ngay_Sinh", kh.NgaySinh);
                        cmd.Parameters.AddWithValue("@Gioi_Tinh", kh.GioiTinh);
                        cmd.Parameters.AddWithValue("@Dia_Chi", kh.DiaChi);
                        cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UpdateKH: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UpdateKH: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteKH(KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XoaKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_KH", kh.MaKH);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL DeleteKH:" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi DeleteKH:" + ex.Message);
                return false;
            }
        }
    }
}
