using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Vize_technical_test.src.Application;

namespace WebAPI_Vize_technical_test.src.Presentation
{
    [Authorize]
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
            try
            {
                var result = await _dashboardAdapter.GetDashboardAsync();
                return CreateResponse(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
    }
}