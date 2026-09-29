using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class ExtraService : BaseEntity
    {
        public int SportComplexId { get; set; }
        [ForeignKey("SportComplexId")]
        public SportComplex SportComplex { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; } // Số lượng tồn kho (nếu là nước uống)

        public bool IsActive { get; set; } = true;
    }
}