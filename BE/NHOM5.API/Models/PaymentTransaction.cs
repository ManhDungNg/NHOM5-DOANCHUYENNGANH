using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class PaymentTransaction : BaseEntity
    {
        public int BookingId { get; set; }
        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }

        public decimal Amount { get; set; }

        [MaxLength(50)]
        public string PaymentMethod { get; set; } // VNPAY, Momo, VietQR, Cash (Tiền mặt)

        [MaxLength(50)]
        public string TransactionType { get; set; } // Deposit (Cọc), FinalPayment (Thanh toán nốt)

        [MaxLength(50)]
        public string Status { get; set; } // Success, Failed, Pending
    }
}