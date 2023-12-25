using AutoMapper;
using MBS.Infrastructure.Entities;
using MBS.Web.Areas.Admin.Models;

namespace MBS.Web.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<MBS.Infrastructure.Entities.Blog, MBS.Web.Areas.Admin.Models.Blog>()
                .ReverseMap();
        }
    }
}
