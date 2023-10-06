using OrderService.Models;

namespace OrderService.Services;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrdersAsync();
    Task<Order> GetOrderAsync(int id);
    Task<Order> CreateOrderAsync(Order order);
    Task<Order> UpdateOrderAsync(int id, Order order);
    Task<Order> DeleteOrderAsync(int id);
}
