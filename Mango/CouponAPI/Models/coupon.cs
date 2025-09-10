using System.ComponentModel.DataAnnotations;

namespace CouponAPI.Models
{
    public class coupon
    {
        [Key]
        public int  CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }

}
