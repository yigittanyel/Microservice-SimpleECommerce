using Microsoft.EntityFrameworkCore;
using ProductService.ApplicationDbContext;
using ProductService.Exceptions;
using ProductService.Models;

namespace ProductService.Services;

public class ProductService : IProductService
{
    readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return product;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }

    }

    public async Task<bool> DeleteAsync(int id)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();

        try
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
    public async Task<Product> UpdateAsync(Product product)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();

        try
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return product;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.AsNoTracking().ToListAsync();   
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _context.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id) ?? throw new NotFoundException("Product",id);
    }
}
