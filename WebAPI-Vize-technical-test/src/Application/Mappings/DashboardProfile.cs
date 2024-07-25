using AutoMapper;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class DashboardProfile : Profile
    {
        public DashboardProfile()
        {
            CreateMap<DashboardVO, DashboardResponseDTO>()
                .ConstructUsing(s => new DashboardResponseDTO(s.Material, s.Service));
        }
    }
}