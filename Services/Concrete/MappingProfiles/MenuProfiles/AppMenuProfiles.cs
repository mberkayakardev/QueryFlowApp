using AutoMapper;
using Core.Entities.Concrete.AppEntities;
using Dtos.Concrete.AppMVCMenusDto;

namespace Services.Concrete.MappingProfiles.MenuProfiles
{
    public class AppMenuProfiles : Profile
    {
        public AppMenuProfiles()
        {
            CreateMap<ListAppMVCMenusDto, AppMVCMenus>().ReverseMap();
        }

    }
}
