using AutoMapper;
using Shanta.APIs.DTOs;
using Shanta.Core.Entities.Product;

namespace Shanta.APIs.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(d => d.Brand, s => s.MapFrom(o => o.Brand.BrandName))
                .ForMember(d => d.Category, s => s.MapFrom(o => o.Category.CategoryName))
                .ReverseMap();
        }
    }
}
