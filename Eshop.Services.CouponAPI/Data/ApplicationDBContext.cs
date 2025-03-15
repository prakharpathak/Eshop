using Eshop.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Services.CouponAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "Sale20",
                DiscountAmount = 20,
                MinimumAmount = 100,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "Sale40",
                DiscountAmount = 40,
                MinimumAmount = 150,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode = "Sale60",
                DiscountAmount = 60,
                MinimumAmount = 200,
            });
        }
    }
}
