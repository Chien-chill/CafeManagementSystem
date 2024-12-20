using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Phan_Mem_Quan_Ly.Model
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        [Required(ErrorMessage = "卍 Tên khách hàng không được trống")]
        public string TenKH { get; set; }
        [Required(ErrorMessage = "卍 Ngày sinh không được trống")]
        public string NgaySinh { get; set; }
        [Required(ErrorMessage = "卍 Giới tính chưa chọn")]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "卍 Địa chỉ không được trống")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "卍 SĐT không được trống")]
        public string SDT { get; set; }

        public static bool KiemTraKH(KhachHang kh, out string errorMessage)
        {
            var context = new ValidationContext(kh);
            var result = new List<ValidationResult>();
            if (!Validator.TryValidateObject(kh, context, result, true))
            {
                errorMessage = string.Join("\n", result.Select(r => r.ErrorMessage));
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}
