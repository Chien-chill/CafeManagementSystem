using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_ThongKeRespository
    {
        public static List<ThongKe> GetSanPhamBanChay()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_SanPhamBanChay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ThongKe> TKList = new List<ThongKe>();
                            while (reader.Read())
                            {
                                ThongKe tk = new ThongKe();
                                tk.MaSP = reader["Ma_SP"].ToString();
                                tk.TenSP = reader["Ten_SP"].ToString();
                                tk.AnhSP = (byte[])reader["Anh_SP"];
                                tk.TongKhachHangDat = Convert.ToInt16(reader["KhachHangMua"]);
                                tk.TongSoLuong = Convert.ToInt16(reader["TongSoLuong"]);
                                tk.TongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"]);
                                TKList.Add(tk);
                            }
                            return TKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetSanPhamBanChay: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetSanPhamBanChay: " + ex.Message);
                return null;
            }
        }
        public static List<ThongKe> GetThongKeSanPham()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_DoanhThuSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ThongKe> TKList = new List<ThongKe>();
                            while (reader.Read())
                            {
                                ThongKe tk = new ThongKe();
                                tk.MaSP = reader["Ma_SP"].ToString();
                                tk.TenSP = reader["Ten_SP"].ToString();
                                tk.TongSoLuong = Convert.ToInt16(reader["TongSoLuong"]);
                                tk.TongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"]);
                                TKList.Add(tk);
                            }
                            return TKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetThongKeSanPham: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetThongKeSanPham: " + ex.Message);
                return null;
            }
        }
        public static List<ThongKe> GetThongKeDoanhThuNam(int Nam)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_DoanhThuTheoNam", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nam", Nam);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ThongKe> TKList = new List<ThongKe>();
                            while (reader.Read())
                            {
                                ThongKe tk = new ThongKe();
                                tk.Thang_Nam = reader["Thang"].ToString() + "/" + reader["Nam"].ToString();
                                tk.TongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"]);
                                TKList.Add(tk);
                            }
                            return TKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetThongKeDoanhThuNam: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi  GetThongKeDoanhThuNam: " + ex.Message);
                return null;
            }
        }

        public static List<ThongKe> GetThongKeDoanhThuTuan()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_DoanhThuTheoTuan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ThongKe> TKList = new List<ThongKe>();
                            while (reader.Read())
                            {
                                ThongKe tk = new ThongKe();
                                tk.Thu = reader["Thu"].ToString();
                                tk.TongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"]);
                                TKList.Add(tk);
                            }
                            return TKList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetThongKeDoanhThuTuan: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetThongKeDoanhThuTuan: " + ex.Message);
                return null;
            }
        }
    }
}
