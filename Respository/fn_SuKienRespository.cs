﻿using Newtonsoft.Json;
using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace Phan_Mem_Quan_Ly.Respository
{
    public class fn_SuKienRespository
    {
        public static List<SuKien> GetAllSuKien()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiSK", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<SuKien> SKList = new List<SuKien>();
                            while (reader.Read())
                            {
                                SuKien sk = new SuKien();
                                sk.MaSK = reader["Ma_SK"].ToString();
                                sk.TenSK = reader["Ten_SK"].ToString();
                                sk.TrangThai = reader["TrangThai"].ToString();
                                SKList.Add(sk);
                            }
                            return SKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetAllSuKien: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetAllSuKien: " + ex.Message);
                return null;
            }
        }
        public static List<LichSuSuKien> GetAllLichSuSuKien()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiLSSK", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<LichSuSuKien> SKList = new List<LichSuSuKien>();
                            while (reader.Read())
                            {
                                LichSuSuKien sk = new LichSuSuKien();
                                sk.MaSK = reader["Ma_SK"].ToString();
                                sk.ThoiGianBD = reader["ThoiGian_BD"].ToString();
                                sk.ThoiGianKT = (reader["ThoiGian_KT"] != DBNull.Value) ? reader["ThoiGian_KT"].ToString() : "Chưa Kết Thúc";
                                SKList.Add(sk);
                            }
                            return SKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetAllLichSuSuKien: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetAllLichSuSuKien: " + ex.Message);
                return null;
            }
        }
        public static List<ChiTietSuKien> GetChiTietSKTheoMa(string MaSK)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiChiTietSK", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_SK", MaSK);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ChiTietSuKien> SKList = new List<ChiTietSuKien>();
                            while (reader.Read())
                            {
                                ChiTietSuKien sk = new ChiTietSuKien();
                                sk.Ma_SP = reader["Ma_SP"].ToString();
                                sk.Giam_Gia = Convert.ToInt16(reader["Giam_Gia"]);
                                SKList.Add(sk);
                            }
                            return SKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetChiTietSKTheoMa: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetChiTietSKTheoMa: " + ex.Message);
                return null;
            }
        }
        public static bool AddSuKien(SuKien sk, List<ChiTietSuKien> skDetails)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemSuKien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Install-Package Newtonsoft.Json
                        string Jsonsk = JsonConvert.SerializeObject(skDetails);
                        cmd.Parameters.AddWithValue("@Ten_SK", sk.TenSK);
                        cmd.Parameters.AddWithValue("@TrangThai", sk.TrangThai);
                        cmd.Parameters.AddWithValue("@ChiTietSuKien", Jsonsk);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL AddSuKien: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi AddSuKien: " + ex.Message);
                return false;
            }
        }
        public static bool UPDSuKien(SuKien sk, List<ChiTietSuKien> skDetails)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SuaSuKien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        string Jsonsk = JsonConvert.SerializeObject(skDetails);
                        cmd.Parameters.AddWithValue("@Ma_SK", sk.MaSK);
                        cmd.Parameters.AddWithValue("@Ten_SK", sk.TenSK);
                        cmd.Parameters.AddWithValue("@TrangThai", sk.TrangThai);
                        cmd.Parameters.AddWithValue("@ChiTietSuKien", Jsonsk);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UPDSuKien: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UPDSuKien: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteSuKien(SuKien sk)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XoaSuKien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_SK", sk.MaSK);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UPDSuKien: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UPDSuKien: " + ex.Message);
                return false;
            }
        }
        public static bool KiemTraSuKien(string MaSK)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_KiemTraSuKien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_SK", MaSK);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL KiemTraSuKien: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi KiemTraSuKien: " + ex.Message);
                return false;
            }
        }
        public static string LayMaSuKien()
        {
            string MaSK = null;
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LayMaSuKien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MaSK = reader["MaSK"].ToString();
                            }
                        }
                        return MaSK;
                    }
                }

            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL LayMaSuKien: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi LayMaSuKien: " + ex.Message);
                return null;
            }
        }
    }
}
