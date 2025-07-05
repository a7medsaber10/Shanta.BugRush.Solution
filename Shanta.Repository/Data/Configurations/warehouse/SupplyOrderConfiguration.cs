using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shanta.Core.Entities.Warehouse;


namespace Shanta.Repository.Data.Configurations.warehouse
{
    public class SupplyOrderConfiguration : IEntityTypeConfiguration<SupplyOrder>
    {
        public void Configure(EntityTypeBuilder<SupplyOrder> builder)
        {
            builder.Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)"); // Total amount of the order
        }
    }
}
