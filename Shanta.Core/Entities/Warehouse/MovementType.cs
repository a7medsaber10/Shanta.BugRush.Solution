using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public enum MovementType
    {
        Inbound,      // Stock is being added to the warehouse (e.g., new stock arrival, restocking)
        Outbound,     // Stock is being removed from the warehouse (e.g., order fulfillment, stock transfer)
        Adjustment,   // Stock quantity is being adjusted (e.g., due to damage, loss, or inventory correction)
        Transfer      // Stock is being transferred between warehouses
    }
}
