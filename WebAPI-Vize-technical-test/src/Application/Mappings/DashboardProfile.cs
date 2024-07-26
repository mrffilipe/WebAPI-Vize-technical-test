using AutoMapper;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class DashboardProfile : Profile
    {
        public DashboardProfile()
        {
            CreateMap<DashboardVO, DashboardResponseDTO>()
                .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.Material))
                .ForMember(dest => dest.Service, opt => opt.MapFrom(src => src.Service));
        }
    }
}