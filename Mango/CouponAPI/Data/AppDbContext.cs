using CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponAPI.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        } 
        public DbSet<coupon>Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<coupon>().HasData(new coupon
            {
                CouponId = 1,
                CouponCode = "10OFF",
                DiscountAmount = 10,
                MinAmount = 20
            });


            modelBuilder.Entity<coupon>().HasData(new coupon
            {
                CouponId = 2,
                CouponCode = "20OFF",
               DiscountAmount = 20,
                MinAmount = 40
            });
        }
    }
}