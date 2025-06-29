using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shanta.Core.Entities.Product;


namespace Shanta.Repository.Data.Configurations.Product
{
    public class ProductConfigurations : IEntityTypeConfiguration<Shanta.Core.Entities.Product.Product>
    {
        public void Configure(EntityTypeBuilder<Shanta.Core.Entities.Product.Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.ImageUrl).IsRequired();

            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Brand).WithMany().HasForeignKey(p => p.BrandId);

            builder.HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId);
        }
    }
}
