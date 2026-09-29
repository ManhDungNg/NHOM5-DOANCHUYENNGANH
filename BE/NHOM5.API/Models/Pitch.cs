using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class Pitch : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int PitchType { get; set; } // Lưu số 5, 7 hoặc 11 (Loại sân)

        // Khóa ngoại liên kết tới Cụm sân
        public int SportComplexId { get; set; }
        [ForeignKey("SportComplexId")]
        public SportComplex SportComplex { get; set; }

        public bool IsActive { get; set; } = true;
    }
}