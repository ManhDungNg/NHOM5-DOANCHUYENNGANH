#nullable disable
using System.ComponentModel.DataAnnotations;

namespace NHOM5.API.DTOs.Auth
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; } // Đổi từ PhoneNumber thành Phone

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(6, ErrorMessage = "Mật khẩu phải từ 6 ký tự")]
        public string Password { get; set; }

        public string Role { get; set; } = "Customer";
    }
}