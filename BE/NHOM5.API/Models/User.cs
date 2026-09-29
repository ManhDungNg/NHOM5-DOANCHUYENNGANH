using System.ComponentModel.DataAnnotations;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Role { get; set; } // Sẽ lưu: "Admin", "Owner", "Staff", "Customer"

        public bool IsActive { get; set; } = true; // Để admin khóa/mở tài khoản
    }
}