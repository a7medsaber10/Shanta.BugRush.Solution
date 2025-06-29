using Microsoft.EntityFrameworkCore;
using Shanta.Core.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.Data.Configurations.Order
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderItem> builder)
        {
            // Define properties for OrderItem entity
            builder.Property(oi => oi.Quantity)
                .IsRequired(); // Quantity of the product in the order item
            builder.Property(oi => oi.Price)
                .HasColumnType("decimal(18,2)"); // Price of the product at the time of order
            // Define foreign key relationships
            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);
        }
    }
}
