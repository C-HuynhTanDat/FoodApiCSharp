using Microsoft.EntityFrameworkCore;

namespace FoodApiC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
            modelBuilder.Entity<Order>().HasMany(o => o.OrderItems).WithOne(oi => oi.Order);
            modelBuilder.Entity<FoodItem>().HasMany(f => f.OrderItems).WithOne(oi => oi.FoodItem);

            base.OnModelCreating(modelBuilder);
        }
    }
}
