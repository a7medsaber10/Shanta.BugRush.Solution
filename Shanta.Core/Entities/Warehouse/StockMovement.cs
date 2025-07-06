using Shanta.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public class StockMovement : BaseEntity
    {
        public Guid StockId { get; set; } // Foreign key to the stock item
        public Stock? Stock { get; set; } // Navigation property to the stock item
        public int Quantity { get; set; } // Quantity of the stock movement (positive for addition, negative for removal)
        public DateTime MovementDate { get; set; } // Date of the stock movement

        public MovementType Movement { get; set; } // Type of movement (e.g., Addition, Removal, Transfer)

        public Guid WarehouseId { get; set; } // Foreign key to the warehouse where the movement occurred

        public Warehouse? Warehouse { get; set; } // Navigation property to the warehouse

        public string? UserId { get; set; } // Optional foreign key to the user who performed the movement
        public AppUser? User { get; set; } // Navigation property to the user who performed the movement
    }
}
