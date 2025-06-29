
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

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int? Rating { get; set; }

        public decimal Price { get; set; }

        public int BrandId { get; set; } // FK
        
        public ProductBrand Brand { get; set; } // navigation property [one]

        public int CategoryId { get; set; } // FK
        public ProductCategory Category { get; set; } // navigation property [one]
    }
}
