using System.ComponentModel.DataAnnotations;

namespace CouponApi.Models;

public class Coupon
{
    [Key] public int CouponId { get; set; }
    [Required] public string CouponCode { get; set; }
    [Required] public double CouponType { get; set; }
    public int DiscountAmount { get; set; }
    public int MinAmount { get; set; }
    public DateTime LastUpdated { get; set; }
}