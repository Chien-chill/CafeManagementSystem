using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Phan_Mem_Quan_Ly.Model
{
    public class TaiKhoan
    {
        [Required(ErrorMessage = "卍 Tài khoản không được để trống !")]
        public string Tai_Khoan { get; set; }
        [Required(ErrorMessage = "卍 Mật khẩu không được để trống !")]
        public string Mat_Khau { get; set; }
        [Required(ErrorMessage = "卍 Mã nhân viên chưa chọn !")]
        public string Ma_NV { get; set; }
        public static bool KiemTraTK(TaiKhoan tk, out string errorMessage)
        {
            var context = new ValidationContext(tk);
            var result = new List<ValidationResult>();
            if (!Validator.TryValidateObject(tk, context, result, true))
            {
                errorMessage = string.Join("\n", result.Select(r => r.ErrorMessage));
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}
