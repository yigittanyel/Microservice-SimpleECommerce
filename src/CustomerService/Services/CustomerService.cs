using CustomerService.ApplicationDbContext;
using CustomerService.Exceptions;
using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Services;

public class CustomerService : ICustomerService
{
    readonly AppDbContext _dbContext;

    public CustomerService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Customer> CreateAsync(Customer customer)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return customer;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }    
    }

    public async Task<bool> DeleteAsync(int id)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            var customer = await _dbContext.Customers.FindAsync(id);

            if (customer == null)
                return false;

            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }      
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await _dbContext.Customers.AsNoTracking().ToListAsync();
        
    }

    public async Task<Customer> GetByIdAsync(int id)
    {
        return await _dbContext.Customers.FindAsync(id) ?? throw new NotFoundException("Product", id);
    }

    public async Task<Customer> UpdateAsync(Customer customer)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return customer;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
        
    }
}
