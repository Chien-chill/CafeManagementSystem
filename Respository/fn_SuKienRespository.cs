using Newtonsoft.Json;
using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_SuKienRespository
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
                Console.WriteLine("Lỗi SQL GETALL: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetALL: " + ex.Message);
                return null;
            }
        }
        public bool AddSuKien(SuKien sk, string skDetails)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemSuKien", conn))
                    {
                        // Install-Package Newtonsoft.Json
                        string Jsonsk = JsonConvert.SerializeObject(skDetails);
                        cmd.Parameters.AddWithValue("Ten_SK", sk.TenSK);
                        cmd.Parameters.AddWithValue("ThoiGian_BD", sk.ThoiGianBD);
                        cmd.Parameters.AddWithValue("ThoiGian_KT", sk.ThoiGianKT);
                        cmd.Parameters.AddWithValue("ChiTietSuKien", Jsonsk);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi ADD SQL : " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ADD : " + ex.Message);
                return false;
            }
        }

    }
}
