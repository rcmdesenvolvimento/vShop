using AutoMapper;
using vShop.ProductApi.Domain.Models;

namespace vShop.ProductApi.Dtos.Mappins;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
