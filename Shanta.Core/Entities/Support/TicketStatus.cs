using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Support
{
    public enum TicketStatus
    {
        Open,          // Ticket is newly created and awaiting attention
        InProgress,    // Ticket is currently being worked on
        Resolved,      // Issue has been resolved
        Closed,        // Ticket is closed and no further action is needed
        Reopened       // Ticket was closed but has been reopened for further action
    }
}
