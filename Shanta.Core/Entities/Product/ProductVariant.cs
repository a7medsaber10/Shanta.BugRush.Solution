using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Product
{
    public class ProductVariant : BaseEntity
    {
        public VariantAttributes AttributeName { get; set; } // Name of the attribute (e.g., Color, Size)

        public string AttributeValue { get; set; } // Value of the attribute (e.g., Red, Large)

        public decimal Price { get; set; } // Price of the variant, if different from the base product price

        public string? ImageUrl { get; set; } // URL of the variant image, if applicable

        public Guid ProductId { get; set; }
        public Product? product { get; set; }

    }
}
