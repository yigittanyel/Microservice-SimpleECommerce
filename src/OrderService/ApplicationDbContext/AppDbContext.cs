using Microsoft.EntityFrameworkCore;
using OrderService.Models;

namespace OrderService.ApplicationDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().ToTable("Orders");
        modelBuilder.Entity<Order>().Property(x => x.TotalPrice).HasPrecision(18, 2);

        modelBuilder.Entity<Order>().HasData(
            new Order { Id = 1, CustomerId = 1,ProductId=1, TotalPrice = 100, CreatedAt = DateTime.UtcNow },
            new Order { Id = 2, CustomerId = 1, ProductId = 2, TotalPrice = 200, CreatedAt = DateTime.UtcNow },
            new Order { Id = 3, CustomerId = 2, ProductId = 3, TotalPrice = 300, CreatedAt = DateTime.UtcNow },
            new Order { Id = 4, CustomerId = 3, ProductId = 4, TotalPrice = 400, CreatedAt = DateTime.UtcNow },
            new Order { Id = 5, CustomerId = 4, ProductId = 1, TotalPrice = 500, CreatedAt = DateTime.UtcNow }
      );

    }
}
