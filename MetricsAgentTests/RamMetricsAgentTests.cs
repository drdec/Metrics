using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace MetricsAgentTests
{
    public class RamMetricsAgentTests
    {
        private RamMetricsController _ramMetricsController;

        public RamMetricsAgentTests()
        {
            _ramMetricsController = new RamMetricsController();
        }

        public void GetDotNetMetricsFromAgent_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _ramMetricsController.GetRamMetrics();

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
