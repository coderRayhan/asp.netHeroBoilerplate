using MizanBro.Application.Features.Products.Commands.Create;
using MizanBro.Application.Features.Products.Queries.GetAllCached;
using MizanBro.Application.Features.Products.Queries.GetAllPaged;
using MizanBro.Application.Features.Products.Queries.GetById;
using MizanBro.Domain.Entities.Catalog;
using AutoMapper;

namespace MizanBro.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}