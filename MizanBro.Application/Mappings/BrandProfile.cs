using MizanBro.Application.Features.Brands.Commands.Create;
using MizanBro.Application.Features.Brands.Queries.GetAllCached;
using MizanBro.Application.Features.Brands.Queries.GetById;
using MizanBro.Domain.Entities.Catalog;
using AutoMapper;

namespace MizanBro.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}