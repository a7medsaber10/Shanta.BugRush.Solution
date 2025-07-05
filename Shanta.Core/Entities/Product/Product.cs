
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Product
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int? Rating { get; set; }

        public decimal Price { get; set; }

        public Guid BrandId { get; set; } // FK
        
        public ProductBrand? Brand { get; set; } // navigation property [one]

        public Guid CategoryId { get; set; } // FK
        public ProductCategory? Category { get; set; } // navigation property [one]

        public bool HasVariants { get; set; } // Indicates if the product has variants

        public List<ProductVariant>? Variants { get; set; } // Navigation property for product variants
    }
}
