using Shanta.Core.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public class Stock : BaseEntity
    {
        public int Quantity { get; set; } // Quantity of the stock item
        public Guid WarehouseId { get; set; } // Foreign key to the warehouse
        public Guid ProductId { get; set; } // Foreign key to the product

        public Guid? ProductVariantId { get; set; }

        public ProductVariant? productVariant { get; set; }

        public Warehouse? Warehouse { get; set; } // Navigation property to the warehouse

        public Product.Product? Product { get; set; } // Navigation property to the product

        public UnitMeasure UnitMeasure { get; set; }
    }
}
