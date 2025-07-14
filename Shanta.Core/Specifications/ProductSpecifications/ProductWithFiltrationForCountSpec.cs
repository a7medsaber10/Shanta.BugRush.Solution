using Shanta.Core.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Specifications.ProductSpecifications
{
    public class ProductWithFiltrationForCountSpec : BaseSpecifications<Product>
    {
        public ProductWithFiltrationForCountSpec(ProductSpecParams specParams) : base
            (
                p => 
                (!specParams.BrandId.HasValue || p.BrandId == specParams.BrandId.Value)
                &&
                (!specParams.CategoryId.HasValue || p.CategoryId == specParams.CategoryId.Value)
            ) { }
    }
}
