using System.Linq;
using App.API.Dtos;
using App.API.Models;
using AutoMapper;

namespace App.API.Helpers
{
    public class autoMapperProfile : Profile
    {
        public autoMapperProfile()
        {
            CreateMap<User, userForListDto>()
            .ForMember(dest => dest.photoUrl, opt => opt.MapFrom(src => src.photos.FirstOrDefault(p => p.ismain).url))
            .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.dateofbirth.calculateAge()));

            CreateMap<User, userForDetailedDto>()
            .ForMember(dest => dest.photoUrl, opt => opt.MapFrom(src => src.photos.FirstOrDefault(p => p.ismain).url))
            .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.dateofbirth.calculateAge()));

            CreateMap<Photo, photosForDetailedDto>();
        }
    }
}