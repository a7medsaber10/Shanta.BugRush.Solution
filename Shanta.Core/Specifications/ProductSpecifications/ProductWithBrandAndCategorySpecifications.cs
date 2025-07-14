using Shanta.Core.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Specifications.ProductSpecifications
{
    public class ProductWithBrandAndCategorySpecifications : BaseSpecifications<Product>
    {
        public ProductWithBrandAndCategorySpecifications(ProductSpecParams specParams) : base
            (
                p =>
                // Search
                (string.IsNullOrEmpty(specParams.Search) || p.Name.ToLower().Contains(specParams.Search.ToLower()))
                &&
                // Filteration
                (!specParams.BrandId.HasValue || p.BrandId == specParams.BrandId.Value)
                &&
                (!specParams.CategoryId.HasValue || p.CategoryId == specParams.CategoryId.Value)
            )
        {
            // Includes
            Includes.Add(p => p.Brand);
            Includes.Add(p => p.Category);

            // Sort
            if (!string.IsNullOrEmpty(specParams.Sort))
            {
                switch (specParams.Sort)
                {
                    case "price":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesc(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
            else
            {
                AddOrderBy(p => p.Name);
            }

            // Pagination
            ApplyPagination((specParams.PageIndex - 1) * specParams.PageSize, specParams.PageSize);
        }

        public ProductWithBrandAndCategorySpecifications(Guid id) : base(p => p.Id == id)
        {
            Includes.Add(p => p.Brand);
            Includes.Add(p => p.Category);
        }
    }
}
