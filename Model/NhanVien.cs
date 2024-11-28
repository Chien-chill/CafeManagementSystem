using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Phan_Mem_Quan_Ly.Model
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        [Required(ErrorMessage ="Tên nhân viên không được trống")]
        public string TenNV { get; set; }
        [Required(ErrorMessage ="CCCD không được trống")]
        public string CCCD { get; set; }
        [Required(ErrorMessage ="Giới Tính chưa chọn")]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage ="Địa chỉ không được trống")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage ="Số điện thoại không được trống")]
        public string SDT { get; set; }

        public static bool KiemTraVN (NhanVien nv, out string errorMessage)
        {
            var context = new ValidationContext(nv);
            var result = new List<ValidationResult>();
            if(!Validator.TryValidateObject(nv,context,result,true))
            {
                errorMessage = string.Join("\n",result.Select(r => r.ErrorMessage));
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}
