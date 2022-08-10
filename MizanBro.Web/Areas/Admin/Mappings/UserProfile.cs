using MizanBro.Infrastructure.Identity.Models;
using MizanBro.Web.Areas.Admin.Models;
using AutoMapper;

namespace MizanBro.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}