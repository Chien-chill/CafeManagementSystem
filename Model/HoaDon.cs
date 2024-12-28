using System.Data;

namespace Phan_Mem_Quan_Ly.Model
{
    internal class HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string MaSK { get; set; }
        public string NgayTao { get; set; }
        public string GioRa { get; set; }
        public string GioVao { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public DataTable ChiTietHD { get; set; }
        public HoaDon()
        {
            ChiTietHD = new DataTable("ChiTietHD");
            ChiTietHD.Columns.Add("Ma_SP", typeof(string));
            ChiTietHD.Columns.Add("SoLuong", typeof(int));
            ChiTietHD.Columns.Add("DonGia", typeof(decimal));
            ChiTietHD.Columns.Add("ThanhTien", typeof(decimal));
        }
    }
}
