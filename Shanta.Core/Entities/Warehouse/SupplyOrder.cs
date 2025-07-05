using Shanta.Core.Entities.Identity;
using Shanta.Core.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public class SupplyOrder : BaseEntity
    {
        public DateTime OrderDate { get; set; } // Date when the order was placed
        public decimal TotalPrice { get; set; } // Total amount for the order
        public Status Status { get; set; } // Order status (e.g., Pending, Shipped, Delivered)
        public List<SupplyItem>? SupplyItems { get; set; } // Navigation property for order items


        public string UserId { get; set; } // FK to User entity

        [ForeignKey("UserId")]

        public AppUser? User { get; set; } // Navigation property for User entity

        public Guid WarehouseId { get; set; } // Foreign key to the associated warehouse

        public Warehouse? Warehouse { get; set; } // Navigation property for associated warehouse
    }
}
