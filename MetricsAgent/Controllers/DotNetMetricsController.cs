using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/[controller]")]
    [ApiController]
    public class DotNetMetricsController : Controller
    {
        [HttpGet("errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetDotNetMetrics([FromRoute]TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
