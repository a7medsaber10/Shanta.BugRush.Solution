using AutoMapper;
using AutoMapper.Execution;
using Shanta.APIs.DTOs;
using Shanta.Core.Entities.Product;

namespace Shanta.APIs.Helpers
{
    public class ProductImageUrlResolver : IValueResolver<Product, ProductDTO, string>
    {
        private readonly IConfiguration _configuration;

        public ProductImageUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(Product source, ProductDTO destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ImageUrl))
            {
                return $"{_configuration["APIBaseURL"]}/{source.ImageUrl}";
            }
            return string.Empty;
        }
    }
}
