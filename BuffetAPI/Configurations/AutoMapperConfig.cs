using AutoMapper;
using BuffetAPI.Data;
using BuffetAPI.Models.Auth;
using BuffetAPI.Models.Plats;
using System.Diagnostics.Metrics;

namespace BuffetAPI.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Plat, PlatBaseDTO>().ReverseMap();
            CreateMap<Plat, DetailsPlatDTO>().ReverseMap();
            CreateMap<Plat, GetPlatDTO>().ReverseMap();
            CreateMap<Plat, PostPlatDTO>().ReverseMap();
            CreateMap<Plat, PutPlatDTO>().ReverseMap();
        }
    }
}
