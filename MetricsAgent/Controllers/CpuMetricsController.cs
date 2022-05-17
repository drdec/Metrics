using System.Data.SQLite;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/[controller]")]
    [ApiController]
    public class CpuMetricsController : Controller
    {

        [HttpGet("sql-test")]
        public IActionResult TryToSQLite()
        {
            string cs = "Data Source:=memory:";
            string stm = "SELECT SQLITE_VERSION()";
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using var cmd = new SQLiteCommand(stm, con);
                string version = cmd.ExecuteScalar().ToString();
                con.Close();
                return Ok(version);
            }
        }

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetCpuMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        
    }
}
