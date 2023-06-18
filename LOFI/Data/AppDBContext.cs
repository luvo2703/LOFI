using LOFI.Controllers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LOFI.Data
{
    public class AppDBContext : IdentityDbContext<LOFIUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<OrderProduct> OrderProducts { get; set; } = null!;

        
    }
}
