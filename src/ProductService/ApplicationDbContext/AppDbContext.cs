using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.ApplicationDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(x=>x.Price)
            .HasPrecision(18,2);

        modelBuilder.Entity<Product>()
            .HasData(Enumerable.Range(1, 10).Select(x => new Product
            {
                Id = x,
                Name = $"Product {x}",
                Description = $"Description {x}",
                Stock = x * 10,
                Price = x * 10
              }));
    }
}
