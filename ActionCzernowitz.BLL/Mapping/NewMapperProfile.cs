using ActionCzernowitz.BLL.DTOs;
using ActionCzernowitz.DAL.Entities;
using AutoMapper;

namespace ActionCzernowitz.BLL.Mapping
{
    public class NewMapperProfile : Profile
    {
        public NewMapperProfile()
        {
            CreateMap<NewDto, New>()
                .ReverseMap();
        }
    }
}
