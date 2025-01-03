using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_HoaDonRespository
    {
        public static List<HoaDon> GetHoaDonTheoTrangThai(string TrangThai)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiHD", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<HoaDon> lstHD = new List<HoaDon>();
                            while (reader.Read())
                            {
                                HoaDon hd = new HoaDon();
                                hd.MaHD = reader["Ma_HD"].ToString();
                                hd.MaKH = reader["Ma_KH"].ToString();
                                hd.MaNV = reader["Ma_NV"].ToString();
                                hd.MaSK = reader["Ma_SK"].ToString();
                                DateTime dateTime = (DateTime)reader["NgayTao"];
                                hd.NgayTao = dateTime.ToString("dd/MM/yyyy").Split(' ')[0];
                                hd.GioRa = reader["GioRa"].ToString();
                                hd.GioVao = reader["GioVao"].ToString();
                                hd.TongTien = (decimal)reader["TongTien"];
                                hd.TrangThai = reader["TrangThai"].ToString();
                                lstHD.Add(hd);
                            }
                            return lstHD;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetHoaDonTheoTrangThai:" + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetHoaDonTheoTrangThai:" + ex.Message);
                return null;
            }
        }
        public static List<HoaDon> GetHoaDonTheoNgay(DateTime NgayTao)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_BaoCaoNgay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NgayTao", NgayTao);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<HoaDon> lstHD = new List<HoaDon>();
                            while (reader.Read())
                            {
                                HoaDon hd = new HoaDon();
                                hd.MaHD = reader["Ma_HD"].ToString();
                                hd.MaKH = reader["Ma_KH"].ToString();
                                hd.MaNV = reader["Ma_NV"].ToString();
                                hd.MaSK = reader["Ma_SK"].ToString();
                                hd.GioRa = reader["GioRa"].ToString();
                                hd.GioVao = reader["GioVao"].ToString();
                                hd.TongTien = (decimal)reader["TongTien"];
                                lstHD.Add(hd);
                            }
                            return lstHD;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetHoaDonTheoNgay:" + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetHoaDonTheoNgay:" + ex.Message);
                return null;
            }
        }
        public static List<ChiTietHoaDon> GetChiTietHDTheoMa(string MaHD)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HDTheoMa", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_HD", MaHD);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<ChiTietHoaDon> lstcthd = new List<ChiTietHoaDon>();
                            while (reader.Read())
                            {
                                ChiTietHoaDon cthd = new ChiTietHoaDon();
                                cthd.MaSP = reader["Ma_SP"].ToString();
                                cthd.TenSP = reader["Ten_SP"].ToString();
                                cthd.AnhSP = (byte[])reader["Anh_SP"];
                                cthd.SoLuong = Convert.ToInt16(reader["SoLuong"].ToString());
                                cthd.DonGia = Convert.ToDecimal(reader["DonGia"].ToString());
                                cthd.ThanhTien = Convert.ToDecimal(reader["ThanhTien"].ToString());
                                lstcthd.Add(cthd);
                            }
                            return lstcthd;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL GetChiTietHDTheoMa:" + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi GetChiTietHDTheoMa:" + ex.Message);
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
                Debug.WriteLine("Lỗi SQL AddHoaDon : " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi AddHoaDon: " + ex.Message);
                return false;
            }
        }
        public static bool UPDATEHoaDon(HoaDon hd, string HanhDong)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XacNhanHD", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_HD", hd.MaHD);
                        cmd.Parameters.AddWithValue("@HanhDong", HanhDong);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("Lỗi SQL UPDATEHoaDon: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi UPDATEHoaDon: " + ex.Message);
                return false;
            }
        }
    }
}
