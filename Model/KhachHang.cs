using System.ComponentModel.DataAnnotations;

namespace Phan_Mem_Quan_Ly.Model
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được trống")]
        public string TenKH { get; set; }
        [Required(ErrorMessage = "Ngày sinh không được trống")]
        public string NgaySinh { get; set; }
        [Required(ErrorMessage = "Giới tính chưa chọn")]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được trống")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "SĐT không được trống")]
        public string SDT { get; set; }
    }
}
