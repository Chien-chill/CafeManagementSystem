
using Phan_Mem_Quan_Ly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Phan_Mem_Quan_Ly.Respository
{
    internal class fn_SanPhamRespository
    {

        public static List<SanPham> GetAllSanPham()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<SanPham> SanPhamList = new List<SanPham>();
                            while (reader.Read())
                            {
                                SanPham SP = new SanPham();
                                SP.MaSP = reader["Ma_SP"].ToString();
                                SP.TenSP = reader["Ten_SP"].ToString();
                                SP.AnhSP = (byte[])reader["Anh_SP"];
                                SP.MoTaSP = reader["MoTa_SP"].ToString();
                                SP.MaLoai = reader["Ma_Loai"].ToString();
                                SP.DonGia_S = (reader["DonGia_S"] != DBNull.Value) ? Convert.ToDecimal(reader["DonGia_S"].ToString()) : 0;
                                SP.DonGia_M = (reader["DonGia_M"] != DBNull.Value) ? Convert.ToDecimal(reader["DonGia_M"].ToString()) : 0;
                                SP.DonGia_L = (reader["DonGia_L"] != DBNull.Value) ? Convert.ToDecimal(reader["DonGia_L"].ToString()) : 0;
                                SP.DonGia_SP = (reader["DonGia_SP"] != DBNull.Value) ? Convert.ToDecimal(reader["DonGia_SP"].ToString()) : 0;
                                SanPhamList.Add(SP);
                            }
                            return SanPhamList;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL GetAllSanPham: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetAllSanPham: " + ex.Message);
                return null;
            }
        }
        public static List<SanPham> GetDoUong()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        {
                            throw new Exception("Không thể tạo kết nối đến cơ sở dữ liệu.");
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiDoUong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<SanPham> lstDoUong = new List<SanPham>();
                            while (reader.Read())
                            {
                                SanPham du = new SanPham();
                                du.MaSP = reader["Ma_SP"].ToString();
                                du.TenSP = reader["Ten_SP"].ToString();
                                du.AnhSP = (byte[])reader["Anh_SP"];
                                du.DonGia_S = Convert.ToDecimal(reader["DonGia_S"].ToString());
                                du.DonGia_M = Convert.ToDecimal(reader["DonGia_M"].ToString());
                                du.DonGia_L = Convert.ToDecimal(reader["DonGia_L"].ToString());
                                lstDoUong.Add(du);
                            }
                            return lstDoUong;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL GetDoUong: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetDoUong: " + ex.Message);
                return null;
            }
        }
        public static List<SanPham> GetDoAn()
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    if (conn == null)
                    {
                        throw new Exception("Không thể tạo cơ sở dữ liệu");
                    }
                    using (SqlCommand cmd = new SqlCommand("SP_HienThiDoAn", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<SanPham> lstda = new List<SanPham>();
                            while (reader.Read())
                            {
                                SanPham da = new SanPham();
                                da.MaSP = reader["Ma_SP"].ToString();
                                da.TenSP = reader["Ten_SP"].ToString();
                                da.AnhSP = (byte[])reader["Anh_SP"];
                                da.DonGia_SP = Convert.ToDecimal(reader["DonGia_SP"].ToString());
                                lstda.Add(da);
                            }
                            return lstda;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL GetDoAn: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetDoAn: " + ex.Message);
                return null;
            }
        }
        public static bool AddSanPham(SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_ThemSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ten_SP", sanPham.TenSP);
                        cmd.Parameters.AddWithValue("@Anh_SP", sanPham.AnhSP);
                        cmd.Parameters.AddWithValue("@MoTa_SP", sanPham.MoTaSP ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Ma_Loai", sanPham.MaLoai);
                        cmd.Parameters.AddWithValue("@DonGia_S", sanPham.DonGia_S);
                        cmd.Parameters.AddWithValue("@DonGia_M", sanPham.DonGia_M);
                        cmd.Parameters.AddWithValue("@DonGia_L", sanPham.DonGia_L);
                        cmd.Parameters.AddWithValue("@DonGia_SP", sanPham.DonGia_SP);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL AddSanPham: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi AddSanPham: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateSanPham(SanPham sanPham)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SuaSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_SP", sanPham.MaSP);
                        cmd.Parameters.AddWithValue("@Ten_SP", sanPham.TenSP);
                        cmd.Parameters.AddWithValue("@Anh_SP", sanPham.AnhSP);
                        cmd.Parameters.AddWithValue("@Ma_Loai", sanPham.MaLoai);
                        cmd.Parameters.AddWithValue("@MoTa_SP", sanPham.MoTaSP ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DonGia_S", sanPham.DonGia_S);
                        cmd.Parameters.AddWithValue("@DonGia_M", sanPham.DonGia_M);
                        cmd.Parameters.AddWithValue("@DonGia_L", sanPham.DonGia_L);
                        cmd.Parameters.AddWithValue("@DonGia_SP", sanPham.DonGia_SP);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL UpdateSanPham: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi UpdateSanPham: " + ex.Message);
                return false;
            }
        }
        public static bool DeleteSanPham(SanPham sp)
        {
            try
            {
                using (SqlConnection conn = DataConnect.CreateConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_XoaSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ma_SP", sp.MaSP);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL DeleteSanPham:" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi DeleteSanPham:" + ex.Message);
                return false;
            }
        }
    }
}
