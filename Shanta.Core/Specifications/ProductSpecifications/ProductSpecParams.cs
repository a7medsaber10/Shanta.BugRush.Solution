using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Specifications.ProductSpecifications
{
    public class ProductSpecParams
    {
        public string? Sort { get; set; }

        public Guid? BrandId { get; set; }

        public Guid? CategoryId { get; set; }


    }
}
