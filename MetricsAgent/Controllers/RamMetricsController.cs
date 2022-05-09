using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/[controller]")]
    [ApiController]
    public class RamMetricsController : Controller
    {
        [HttpGet("available")]
        public IActionResult GetRamMetrics()
        {
            return Ok();
        }
    }
}
