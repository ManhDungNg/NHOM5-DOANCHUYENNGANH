using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NHOM5.API.Models.Common;

namespace NHOM5.API.Models
{
    public class ServiceOrder : BaseEntity
    {
        public int BookingId { get; set; }
        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }

        public int ExtraServiceId { get; set; }
        [ForeignKey("ExtraServiceId")]
        public ExtraService ExtraService { get; set; }

        public int Quantity { get; set; } // Số lượng mua/thuê
        public decimal UnitPrice { get; set; } // Giá lúc mua (phòng trường hợp sau này giá dịch vụ đổi)
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}