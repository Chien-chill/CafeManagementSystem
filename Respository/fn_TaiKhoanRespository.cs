using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_TaiKhoanRespository
    {
        public static void CheckTaiKhoan(TaiKhoan tk)
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
                                ToastMSS mss = new ToastMSS("Đăng nhập thành công !", "SUCCESS");
                                mss.Show();
                                frmTrangChu tt = new frmTrangChu();
                                tt.TenNV = reader["Ten_NV"].ToString();
                                tt.AnhNV = MainFn.ByteArrayToImage((byte[])reader["Anh_NV"]);
                            }
                            else
                            {
                                ToastMSS mss = new ToastMSS("Tài khoản hoặc mật khẩu sai !", "INFO");
                                mss.Show();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL CheckTaiKhoan: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi CheckTaiKhoan: " + ex.Message);
            }
        }
    }
}
