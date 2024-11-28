using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Thư viện sử dụng Data Annotation (vào References -> Add)
using System.Runtime.CompilerServices;
namespace Phan_Mem_Quan_Ly.Model
{
    public class SanPham
    {
        public string MaSP { get; set; }
        [Required(ErrorMessage = "卍 Tên không được để trống !")]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "卍 Ảnh chưa được chọn !")]
        public byte[] AnhSP { get; set; }
        [Range(0.00, double.MaxValue, ErrorMessage = "卍 Đơn giá nhập phải >= 0 !")]
        public decimal? DonGia_S { get; set; }
        [Range(0.00, double.MaxValue, ErrorMessage = "卍 Đơn giá nhập phải >= 0 !")]
        public decimal? DonGia_M { get; set; }
        [Range(0.00, double.MaxValue, ErrorMessage = "卍 Đơn giá nhập phải >= 0 !")]
        public decimal? DonGia_L { get; set; }
        [Range(0.00, double.MaxValue, ErrorMessage = "卍 Đơn giá nhập phải >= 0 !")]
        public decimal? DonGia_SP { get; set; }
        public string MoTaSP { get; set; }
        public string MaLoai { get; set; }

        public static bool KiemTraSP(SanPham sp, out string errorMessage)
        {
            var context = new ValidationContext(sp);
            var result = new List<ValidationResult>();
            if (!Validator.TryValidateObject(sp, context, result, true))
            {
                errorMessage = string.Join("\n", result.Select(r => r.ErrorMessage));
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}