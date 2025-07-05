using Shanta.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Support
{
    public class TicketResponse : BaseEntity
    {
        public string ResponseText { get; set; } // The text of the response
        public DateTime CreatedAt { get; set; } // Date and time when the response was created
        public string UserId { get; set; } // ID of the user who provided the response

        public AppUser? User { get; set; } // Navigation property to the user who provided the response
        public Guid TicketId { get; set; } // ID of the associated support ticket
        public SupportTicket? Ticket { get; set; } // Navigation property to the associated support ticket
    }
}