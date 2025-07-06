using Shanta.Core.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public class SupplyItem : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
        public Guid SupplyOrderId { get; set; }
        public SupplyOrder SupplyOrder { get; set; }
        public Guid ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }
        public int Quantity { get; set; }
    }
}
