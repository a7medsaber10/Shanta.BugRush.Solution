using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shanta.APIs.DTOs;
using Shanta.APIs.Errors;
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


        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(Guid id)
        {
            var spec = new ProductWithBrandAndCategorySpecifications(id);
            var product = await _productRepository.GetWithSpecAsync(spec);

            if (product == null)
            {
                return NotFound(new APIResponse(404, "Product Not Found!"));
            }

            return Ok(_mapper.Map<Product, ProductDTO>(product));
        }




    }
}
