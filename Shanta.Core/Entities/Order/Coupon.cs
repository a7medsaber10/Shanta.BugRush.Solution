using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Order
{
    public class Coupon : BaseEntity
    {
        public string? Code { get; set; } // Unique code for the coupon

        [Range(0, 100)]
        public int DiscountAmount { get; set; } // Amount to be discounted
        public DateTime ExpiryDate { get; set; } // Expiry date of the coupon
        public bool IsActive { get; set; } // Indicates if the coupon is active
    }
}
