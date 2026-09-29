using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class PriceRule : BaseEntity
    {
        public int PitchId { get; set; }
        [ForeignKey("PitchId")]
        public Pitch Pitch { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; } // Giờ bắt đầu (VD: 17:00)

        [Required]
        public TimeSpan EndTime { get; set; } // Giờ kết thúc (VD: 19:00)

        public decimal Price { get; set; } // Giá tiền cho khung giờ này

        public bool IsWeekend { get; set; } = false; // Có phải giá cuối tuần không?
        public bool IsGoldenHour { get; set; } = false; // Có phải giờ vàng không?
    }
}