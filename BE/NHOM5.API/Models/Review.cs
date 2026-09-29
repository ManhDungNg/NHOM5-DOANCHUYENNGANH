using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class Review : BaseEntity
    {
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public User Customer { get; set; }

        public int SportComplexId { get; set; }
        [ForeignKey("SportComplexId")]
        public SportComplex SportComplex { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; } // Số sao (1 đến 5)

        [MaxLength(1000)]
        public string Comment { get; set; }

        public bool IsHidden { get; set; } = false; // Admin có quyền ẩn nếu đánh giá vi phạm ngôn từ
    }
}