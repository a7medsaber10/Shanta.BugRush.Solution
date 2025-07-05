using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shanta.Core.Entities.Product;
using Shanta.Core.Repository.Contract;

namespace Shanta.APIs.Controllers
{

    public class ProductController : BaseApiController
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductBrand> _brandRepository;
        private readonly IGenericRepository<ProductCategory> _categoryRepository;

        public ProductController
            (
                IGenericRepository<Product> productRepository,
                IGenericRepository<ProductBrand> brandRepository,
                IGenericRepository<ProductCategory> categoryRepository
            )
        {
            _productRepository = productRepository;
            _brandRepository = brandRepository;
            _categoryRepository = categoryRepository;
        }


    }
}
