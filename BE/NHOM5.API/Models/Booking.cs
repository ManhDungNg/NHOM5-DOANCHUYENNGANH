using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class Booking : BaseEntity
    {
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public User Customer { get; set; }

        public int PitchId { get; set; }
        [ForeignKey("PitchId")]
        public Pitch Pitch { get; set; }

        [Required]
        public DateTime BookingDate { get; set; } // Ngày đá

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public decimal TotalPrice { get; set; } // Tổng tiền sân
        public decimal DepositAmount { get; set; } // Tiền đã cọc

        [MaxLength(50)]
        public string Status { get; set; } // Pending, Confirmed, Canceled, Completed

        [MaxLength(100)]
        public string CheckInCode { get; set; } // Mã để quét QR Check-in

        public ICollection<ServiceOrder> ServiceOrders { get; set; }
        public ICollection<PaymentTransaction> PaymentTransactions { get; set; }
    }
}