using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class MatchPost : BaseEntity
    {
        public int UserId { get; set; } // Người đăng (Đội trưởng)
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int? PitchId { get; set; } // Sân đã đặt (nếu có)
        [ForeignKey("PitchId")]
        public Pitch Pitch { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; } // Lời nhắn, mô tả đội

        public DateTime MatchDate { get; set; }
        public TimeSpan StartTime { get; set; }

        [MaxLength(50)]
        public string SkillLevel { get; set; } // Yếu, Trung bình, Khá, Chuyên nghiệp

        public bool IsResolved { get; set; } = false; // Đã tìm được đối chưa
    }
}