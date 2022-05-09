using System;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace MetricsAgentTests
{
    public class CpuMetricsAgentTests
    {
        private CpuMetricsController _cpuMetricsController;
        public CpuMetricsAgentTests()
        {
            _cpuMetricsController = new CpuMetricsController();
        }

        [Fact]
        public void GetCpuMetricsFromAgent_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _cpuMetricsController.GetCpuMetrics(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}