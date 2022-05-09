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
    public class DotNetMetricAgentTests
    {
        private DotNetMetricsController _dotNetMetricsController;

        public DotNetMetricAgentTests()
        {
            _dotNetMetricsController = new DotNetMetricsController();
        }

        public void GetDotNetMetricsFromAgent_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _dotNetMetricsController.GetDotNetMetrics(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
