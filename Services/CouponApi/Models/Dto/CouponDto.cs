namespace CouponApi.Models;

public class CouponDto
{
    public int CouponId { get; set; }
    public string CouponCode { get; set; }
    public double CouponType { get; set; }
    public int DiscountAmount { get; set; }
    public int MinAmount { get; set; }
    public DateTime LastUpdated { get; set; }
}