using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Order
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; } // FK to User entity
        public DateTime OrderDate { get; set; } // Date when the order was placed
        public decimal TotalPrice { get; set; } // Total amount for the order
        public string Status { get; set; } // Order status (e.g., Pending, Shipped, Delivered)
        public List<OrderItem> OrderItems { get; set; } // Navigation property for order items
    }
}
