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
    }
}
