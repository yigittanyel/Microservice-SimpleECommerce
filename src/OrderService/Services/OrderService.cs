using Microsoft.EntityFrameworkCore;
using OrderService.ApplicationDbContext;
using OrderService.Models;

namespace OrderService.Services;

public class OrderService : IOrderService
{
    readonly AppDbContext _dbContext;

    public OrderService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Order> CreateOrderAsync(Order order)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return order;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task<Order> DeleteOrderAsync(int id)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            var order = await _dbContext.Orders.FindAsync(id);

            if (order == null)
                return null;

            _dbContext.Orders.Remove(order);
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return order;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task<Order> GetOrderAsync(int id)
    {
        return await _dbContext.Orders.FindAsync(id);
    }

    public async Task<IEnumerable<Order>> GetOrdersAsync()
    {
        return await _dbContext.Orders.AsNoTracking().ToListAsync();
    }

    public async Task<Order> UpdateOrderAsync(int id, Order order)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            _dbContext.Entry(order).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            return order;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}
