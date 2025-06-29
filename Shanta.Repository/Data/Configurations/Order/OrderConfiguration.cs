using Microsoft.EntityFrameworkCore;


namespace Shanta.Repository.Data.Configurations.Order
{
    public class OrderConfiguration : IEntityTypeConfiguration<Shanta.Core.Entities.Order.Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Shanta.Core.Entities.Order.Order> builder)
        {
            // Define properties for Order entity
            builder.Property(o => o.OrderDate)
                .IsRequired(); // Date when the order was placed
            builder.Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)"); // Total amount of the order
            builder.Property(o => o.Status)
                .IsRequired(); // Status of the order (e.g., Pending, Completed, Cancelled)
        }
    }
}
