using Shanta.Core.Entities.Product;

namespace Shanta.APIs.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int? Rating { get; set; }

        public decimal Price { get; set; }

        public Guid BrandId { get; set; } 

        public string Brand { get; set; } 

        public Guid CategoryId { get; set; } 
        public string Category { get; set; } 

        public bool HasVariants { get; set; } 

        public List<string> Variants { get; set; } 

        public bool OutOfStock { get; set; } 

        public int TotalStock { get; set; }
    }
}
