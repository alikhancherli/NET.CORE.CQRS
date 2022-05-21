using AppService.Cqrs.Api.Dtos.User;
using AutoMapper;
using Domain.Cqrs.Api.Entities.User;

namespace Infra.Cqrs.Api.Mapper
{
    public class MapperBootstraper : Profile
    {
        public MapperBootstraper()
        {
            CreateMap<Users, UserDto>()
                .ForMember(src => src.FullName, dst => dst.MapFrom(a => $"{a.Name} {a.Family}"));
        }
    }
}
