using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class SportComplexImage : BaseEntity
    {
        public int SportComplexId { get; set; }
        [ForeignKey("SportComplexId")]
        public SportComplex SportComplex { get; set; }

        [Required]
        [MaxLength(500)]
        public string ImageUrl { get; set; }

        public bool IsCover { get; set; } = false; // Đánh dấu ảnh nào là ảnh bìa chính
    }
}