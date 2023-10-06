using OrderService.Models.Shared;

namespace OrderService.Models;

public sealed class Order: BaseEntity
{
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}
