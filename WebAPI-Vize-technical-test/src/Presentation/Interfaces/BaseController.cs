using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Vize_technical_test.src.Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult<T> CreateResponse<T>(T result)
        {
            if (result == null)
            {
                return NotFound(new { message = "Resource not found" });
            }

            return Ok(result);
        }

        protected ActionResult HandleException(Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }
}