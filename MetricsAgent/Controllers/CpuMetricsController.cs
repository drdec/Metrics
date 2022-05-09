using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/[controller]")]
    [ApiController]
    public class CpuMetricsController : Controller
    {
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetCpuMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        //[HttpGet("from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        //public IActionResult GetCpuMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] ??? percentile)
        //{
        //    percentile - я так и не сообразил, что это такое, поэтому не добавлял
        //    return Ok();
        //}
    }
}
