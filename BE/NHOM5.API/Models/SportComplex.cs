using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class SportComplex : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string District { get; set; } // Quận/Huyện để khách lọc

        // Khóa ngoại liên kết tới bảng User (Chủ sân)
        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public User Owner { get; set; }

        public bool IsApproved { get; set; } = false; // Admin duyệt sân mới hiển thị

        // 1 Cụm sân có nhiều Sân con
        public ICollection<Pitch> Pitches { get; set; }
    }
}