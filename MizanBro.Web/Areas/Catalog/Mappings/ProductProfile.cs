using MizanBro.Application.Features.Products.Commands.Create;
using MizanBro.Application.Features.Products.Commands.Update;
using MizanBro.Application.Features.Products.Queries.GetAllCached;
using MizanBro.Application.Features.Products.Queries.GetById;
using MizanBro.Web.Areas.Catalog.Models;
using AutoMapper;

namespace MizanBro.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}