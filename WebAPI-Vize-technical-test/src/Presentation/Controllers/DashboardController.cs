using Microsoft.AspNetCore.Mvc;
using WebAPI_Vize_technical_test.src.Application;

namespace WebAPI_Vize_technical_test.src.Presentation
{
    public class DashboardController : BaseController
    {
        private readonly IDashboardAdapter _dashboardAdapter;

        public DashboardController(IDashboardAdapter dashboardAdapter)
        {
            _dashboardAdapter = dashboardAdapter;
        }

        [HttpGet]
        [Route("get-dashboard")]
        public async Task<ActionResult<DashboardResponseDTO>> GetDashboardAsync()
        {
            return Ok(await _dashboardAdapter.GetDashboardAsync());
        }
    }
}