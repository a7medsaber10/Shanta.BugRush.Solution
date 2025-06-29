using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shanta.Core.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.Data.Configurations.Order
{
    public class OrderCouponsConfiguration : IEntityTypeConfiguration<OrderCoupons>
    {
        public void Configure(EntityTypeBuilder<OrderCoupons> builder)
        {
            // Define composite key for OrderCoupons
            builder.HasKey(oc => new { oc.OrderId, oc.CouponId });
        }

    }
}
