using Shanta.Core.Entities.Identity;
using Shanta.Core.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Shipment
{
    public class Shipment : BaseEntity
    {
        public DateTime ShipmentDate { get; set; } // Date when the shipment was created
        public DateTime? DeliveryDate { get; set; } // Optional date when the shipment was delivered
        public Status Status { get; set; } // Current status of the shipment (e.g., Pending, Shipped, Delivered)

        public List<Order.Order>? orders { get; set; } // Navigation property for associated orders

        public string DeliveryGuyId { get; set; } // Foreign key to the delivery guy (if applicable)
        [ForeignKey("DeliveryGuyId")]
        public AppUser? DeliveryGuy { get; set; } // Navigation property for the delivery guy
    }
}
