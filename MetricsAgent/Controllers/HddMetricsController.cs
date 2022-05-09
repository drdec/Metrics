using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/[controller]")]
    [ApiController]
    public class HddMetricsController : Controller
    {
        [HttpGet("left")]
        public IActionResult GetHddMetrics()
        {
            return Ok();
        }
    }
}
