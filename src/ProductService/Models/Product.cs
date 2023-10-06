using ProductService.Models.Shared;

namespace ProductService.Models
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal PriceTotal => Price * Stock;
    }
}
