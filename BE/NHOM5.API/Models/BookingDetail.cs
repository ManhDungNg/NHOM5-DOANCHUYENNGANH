using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class BookingDetail : BaseEntity
    {
        public int BookingId { get; set; }
        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }

        [Required]
        public DateTime PlayDate { get; set; } // Ngày đá thực tế của ca này

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public decimal Price { get; set; } // Giá tiền cho riêng ca này

        public bool IsCheckIn { get; set; } = false; // Đã đến sân đá chưa
    }
}