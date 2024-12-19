using Newtonsoft.Json;
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
                                sk.ThoiGianBD = (DateTime)reader["ThoiGian_BD"];
                                sk.ThoiGianKT = (DateTime)reader["ThoiGian_KT"];
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
                                sk.ctsk_SanPham.MaSP = reader["Ma_SP"].ToString();
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
                        Debug.WriteLine("JSON Sent: " + Jsonsk);
                        cmd.Parameters.AddWithValue("@Ten_SK", sk.TenSK);
                        cmd.Parameters.AddWithValue("@ThoiGian_BD", sk.ThoiGianBD);
                        cmd.Parameters.AddWithValue("@ThoiGian_KT", sk.ThoiGianKT);
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

    }
}
