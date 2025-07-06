using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shanta.Core.Entities.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.Data.Configurations.Support
{
    public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50); // Title of the support ticket

            builder.Property(t => t.Description)
                .HasMaxLength(500); // Detailed description of the issue

            builder.Property(t => t.Status)
                .IsRequired(); // Status of the ticket (e.g., Open, In Progress, Closed)
        }
    }
}
