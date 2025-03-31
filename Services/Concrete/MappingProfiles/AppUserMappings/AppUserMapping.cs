using ApiService.Entities.Concrete.AppEntities;
using AutoMapper;
using Dtos.Concrete.AppUserDtos;

namespace QuizApp.Services.Concrete.MappingProfiles.AppUserMappings
{
    public class AppUserMapping : Profile
    {
        public AppUserMapping()
        {
            CreateMap<AppUser, ListAppUserDtos>().ReverseMap();
        }
    }
}
