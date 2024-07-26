using AutoMapper;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class DashboardAdapter : IDashboardAdapter
    {
        private readonly IMapper _mapper;
        private readonly IDashboardService _dashboardService;

        public DashboardAdapter(IMapper mapper, IDashboardService dashboardService)
        {
            _mapper = mapper;
            _dashboardService = dashboardService;
        }

        public async Task<DashboardResponseDTO> GetDashboardAsync()
        {
            var dashboard = await _dashboardService.GetDashboardAsync();

            return _mapper.Map<DashboardResponseDTO>(dashboard);
        }
    }
}