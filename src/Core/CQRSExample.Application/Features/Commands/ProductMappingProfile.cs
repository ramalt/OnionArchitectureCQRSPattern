using AutoMapper;
using CQRSExample.Application.Dto;
using CQRSExample.Application.Features.Commands.Product;

namespace CQRSExample.Application.Features.Commands
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Domain.Entities.Product, ProductDto>().ReverseMap();
            CreateMap<Domain.Entities.Product, AddProductCommand>().ReverseMap();

        }
    }
}