using CouponApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CouponApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Coupon> Coupons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Coupon>().HasData(new Coupon
        {
            CouponId = 1,
            CouponCode = "10OFF",
            DiscountAmount = 10,
            MinAmount = 20,
            LastUpdated = DateTime.Now
        });
        modelBuilder.Entity<Coupon>().HasData(new Coupon
        {
            CouponId = 2,
            CouponCode = "20OFF",
            DiscountAmount = 20,
            MinAmount = 40,
            LastUpdated = DateTime.Now
        });
    }
}