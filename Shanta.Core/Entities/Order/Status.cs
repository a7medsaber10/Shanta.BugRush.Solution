using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Order
{
    public enum Status
    {
        UnCompleted,
        Completed,     // Order has been placed but not yet processed
        Processing,    // Order is being prepared or packed
        OutForDelivery,       // Order has been shipped to the customer
        Delivered,     // Order has been delivered to the customer
        Cancelled,     // Order has been cancelled by the customer or seller
        Returned       // Order has been returned by the customer
    }
}
