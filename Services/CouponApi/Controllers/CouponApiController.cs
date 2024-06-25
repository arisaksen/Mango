using CouponApi.Data;
using CouponApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CouponApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CouponApiController : ControllerBase
{
    private readonly AppDbContext _db;

    public CouponApiController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public object Get()
    {
        try
        {
            IEnumerable<Coupon> coupons = _db.Coupons.ToList();
            return coupons;
        }
        catch (Exception ex)
        {
        }

        return null;
    }

    [HttpGet("{id:int}")]
    public Coupon? Get(int id)
    {
        try
        {
            Coupon? coupon = _db.Coupons.FirstOrDefault(coupon => coupon.CouponId == id);
            return coupon;
        }
        catch (Exception ex)
        {
        }

        return null;
    }
}