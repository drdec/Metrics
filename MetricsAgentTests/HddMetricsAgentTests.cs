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
    public class HddMetricsAgentTests
    {
        private HddMetricsController _hddMetricsController;

        public HddMetricsAgentTests()
        {
            _hddMetricsController = new HddMetricsController();
        }

        public void GetDotNetMetricsFromAgent_ReturnOk()
        {
            IActionResult result = _hddMetricsController.GetHddMetrics();

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
