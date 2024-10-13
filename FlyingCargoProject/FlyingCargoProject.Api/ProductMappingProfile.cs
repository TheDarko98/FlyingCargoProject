using AutoMapper;
using FlyingCargoProject.Api.DTOs;

namespace FlyingCargoProject.Models
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();

            CreateMap<Product, ProductUpdateDTO>().ReverseMap();

            CreateMap<Product, ProductDetailsDTO>();
        }
    }
}