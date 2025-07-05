using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Support
{
    public class SupportTicket : BaseEntity
    {
        public string? Title { get; set; } // Title of the support ticket
        public string? Description { get; set; } // Detailed description of the issue
        public TicketStatus? Status { get; set; } // Status of the ticket (e.g., Open, In Progress, Closed)
        public DateTime CreatedAt { get; set; } // Date and time when the ticket was created
        public DateTime? UpdatedAt { get; set; } // Date and time when the ticket was last updated
        public string? UserId { get; set; } // ID of the user who created the ticket
    }
}
