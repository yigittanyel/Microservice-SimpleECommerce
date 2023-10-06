using CustomerService.Models.Shared;

namespace CustomerService.Models;

public sealed class Customer : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}
