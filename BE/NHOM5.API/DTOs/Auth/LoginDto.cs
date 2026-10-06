#nullable disable
using System.ComponentModel.DataAnnotations;

namespace NHOM5.API.DTOs.Auth
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Vui lòng nhập Email hoặc Số điện thoại")]
        public string Account { get; set; } // Dùng 1 biến để hứng cả SĐT hoặc Email

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }
    }
}