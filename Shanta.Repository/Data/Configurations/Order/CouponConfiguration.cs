using Microsoft.EntityFrameworkCore;
using Shanta.Core.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.Data.Configurations.Order
{
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Coupon> builder)
        {
            // Define properties for Coupon entity
            builder.Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(50); // Unique code for the coupon
            builder.Property(c => c.DiscountAmount)
                .IsRequired(); // Amount to be discounted
            builder.Property(c => c.ExpiryDate)
                .IsRequired(); // Expiry date of the coupon
            builder.Property(c => c.IsActive)
                .IsRequired(); // Indicates if the coupon is active

        }
    }
}
