using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.ApplicationDbContext;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasData(Enumerable.Range(1, 10).Select(x => new Customer
            {
                Id = x,
                Name = $"Customer {x}",
                Phone = $"05555555555",
                Address = $"Address {x}"
            }));
    }
}
