using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class DashboardAdapter : IDashboardAdapter
    {
        private readonly IDashboardService _dashboardService;

        public DashboardAdapter(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<DashboardResponseDTO> GetDashboardAsync()
        {
            throw new NotImplementedException();
        }
    }
}