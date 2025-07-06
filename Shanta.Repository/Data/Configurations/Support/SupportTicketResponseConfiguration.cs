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
    public class SupportTicketResponseConfiguration : IEntityTypeConfiguration<TicketResponse>
    {
        public void Configure(EntityTypeBuilder<TicketResponse> builder)
        {
            builder.Property(r => r.ResponseText)
                .IsRequired()
                .HasMaxLength(1000); // Text of the response
            builder.Property(r => r.CreatedAt)
                .IsRequired(); // Date when the response was made
        }
    }
}
