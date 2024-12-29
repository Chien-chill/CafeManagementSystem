using Phan_Mem_Quan_Ly.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_ChucVuRespository
    {
        public static bool AddChucVu(ChucVu cv, ChiTietChucVu cvDetails)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemChucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ten_CV", cv.TenCV);
                        cmd.Parameters.AddWithValue("@ThaoTacSanPham", cvDetails.ThaoTacSanPham);
                        cmd.Parameters.AddWithValue("@ThaoTacSuKien", cvDetails.ThaoTacSuKien);
                        cmd.Parameters.AddWithValue("@ThaoTacKhachHang", cvDetails.ThaoTacKhachHang);
                        cmd.Parameters.AddWithValue("@ThaoTacNhanVien", cvDetails.ThaoTacNhanVien);
                        cmd.Parameters.AddWithValue("@ThaoTacChucVu", cvDetails.ThaoTacChucVu);
                        cmd.Parameters.AddWithValue("@ThaoTacThongKe", cvDetails.ThaoTacThongKe);
                        cmd.Parameters.AddWithValue("@ThaoTacDonHang", cvDetails.ThaoTacDonHang);
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
    }
}
