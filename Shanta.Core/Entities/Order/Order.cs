using Shanta.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Order
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; } // Date when the order was placed
        public decimal TotalPrice { get; set; } // Total amount for the order
        public Status Status { get; set; } // Order status (e.g., Pending, Shipped, Delivered)
        public List<OrderItem>? OrderItems { get; set; } // Navigation property for order items


        public string UserId { get; set; } // FK to User entity

        [ForeignKey("UserId")]

        public AppUser? User { get; set; } // Navigation property for User entity

        public Guid ShipmentId { get; set; } // Foreign key to the associated shipment

        public Shipment.Shipment? Shipment { get; set; } // Navigation property for associated shipment
    }
}
