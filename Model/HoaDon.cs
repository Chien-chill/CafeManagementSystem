using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Phan_Mem_Quan_Ly.Model
{
    internal class HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string MaSK { get; set; }
        public DataTable ChiTietHD  { get; set; }
        public HoaDon()
        {
            ChiTietHD = new DataTable("ChiTietHD");
            // Thêm cột vào DataTable
            ChiTietHD.Columns.Add("Ma_SP", typeof(string));    // Mã sản phẩm
            ChiTietHD.Columns.Add("SoLuong", typeof(int));     // Số lượng
            ChiTietHD.Columns.Add("DonGia", typeof(decimal));  // Đơn giá
        }
    }
}
