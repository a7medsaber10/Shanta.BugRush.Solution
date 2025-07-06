using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shanta.APIs.DTOs;
using Shanta.Core.Entities.Product;
using Shanta.Core.Repository.Contract;
using Shanta.Core.Specifications.ProductSpecifications;

namespace Shanta.APIs.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductBrand> _brandRepository;
        private readonly IGenericRepository<ProductCategory> _categoryRepository;
        private readonly IMapper _mapper;

        public ProductController
            (
                IGenericRepository<Product> productRepository,
                IGenericRepository<ProductBrand> brandRepository,
                IGenericRepository<ProductCategory> categoryRepository,
                IMapper mapper
            )
        {
            _productRepository = productRepository;
            _brandRepository = brandRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet("all-products")]
        public async Task<ActionResult<IReadOnlyList<ProductDTO>>> GetProducts()
        {
            var spec = new ProductWithBrandAndCategorySpecifications();
            var products = await _productRepository.GetAllWithSpecAsync(spec);

            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDTO>>(products);

            return Ok(data);
        }




    }
}
