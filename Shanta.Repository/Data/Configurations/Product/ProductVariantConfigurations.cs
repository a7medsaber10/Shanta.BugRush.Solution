using Microsoft.EntityFrameworkCore;
using Shanta.Core.Entities.Product;


namespace Shanta.Repository.Data.Configurations.Product
{
    public class ProductVariantConfigurations : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductVariant> builder)
        {
            // Define properties for ProductVariant entity
            builder.Property(pv => pv.AttributeName)
                .IsRequired()
                .HasMaxLength(100);

                builder.Property(pv => pv.AttributeValue)
                .IsRequired().HasMaxLength(100);

            builder.Property(pv => pv.Price)
                .HasColumnType("decimal(18,2)"); // Price of the product variant

            // Define foreign key relationships if needed
            builder.HasOne(pv => pv.product)
                .WithMany(p => p.Variants)
                .HasForeignKey(pv => pv.ProductId);
        }
    }
}
