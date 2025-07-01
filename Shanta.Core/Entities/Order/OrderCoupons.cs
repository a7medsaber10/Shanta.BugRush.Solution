using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Order
{
    public class OrderCoupons
    {
        public Guid OrderId { get; set; } // FK to Order entity
        public Order? Order { get; set; } // Navigation property for Order
        public Guid CouponId { get; set; } // FK to Coupon entity
        public Coupon? Coupon { get; set; } // Navigation property for Coupon
        public DateTime AppliedDate { get; set; } // Date when the coupon was applied
    }
}
