using ActionCzernowitz.BLL.DTOs.Users;
using ActionCzernowitz.DAL.Entities;
using AutoMapper;

namespace ActionCzernowitz.BLL.Mapping
{
    public partial class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<UserDto, User>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<User, UserDto>()
                .ForMember(uDto => uDto.FullName, opts => opts.MapFrom(u => string.Format($"{u.FirstName} {u.LastName}")))
                .ReverseMap();

            CreateMap<RegistrationDto, User>();

            CreateMap<LoginDto, User>();
        }
    }
}
