using MizanBro.Application.Features.Brands.Commands.Create;
using MizanBro.Application.Features.Brands.Commands.Update;
using MizanBro.Application.Features.Brands.Queries.GetAllCached;
using MizanBro.Application.Features.Brands.Queries.GetById;
using MizanBro.Web.Areas.Catalog.Models;
using AutoMapper;

namespace MizanBro.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}