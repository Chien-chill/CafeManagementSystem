using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_HoaDonRespository
    {
        public static List<HoaDon> GetHDChuaXuLy()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_HDChoXuLy"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        List<HoaDon> lstHHD = new List<HoaDon>();
                        while (reader.Read())
                        {
                            HoaDon hd = new HoaDon();
                            hd.MaHD = reader["Ma_HD"].ToString();
                            hd.MaKH = reader["Ma_KH"].ToString();
                            hd.MaNV = reader["Ma_NV"].ToString();
                            hd.NgayTao = (DateTime)reader["NgayTao"];
                            hd.TongTien =(decimal)reader["TongTien"];
                            hd.TrangThai = reader["TrangThai"].ToString();
                        }
                        return lstHHD;
                    }
                }    
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL :"+ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi :" + ex.Message);
                return null;
            }
        }
        public static bool AddHoaDon(HoaDon hd)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemHoaDon", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_NV", hd.MaNV);
                        cmd.Parameters.AddWithValue("@Ma_KH", hd.MaKH);
                        cmd.Parameters.AddWithValue("@Ma_SK", hd.MaSK);
                        SqlParameter chitietPara = cmd.Parameters.AddWithValue("@ChiTiet", hd.ChiTietHD);
                        chitietPara.SqlDbType = SqlDbType.Structured;
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL ADD hihi: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ADD: " + ex.Message);
                return false;
            }
        }
    }
}
