using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetricsManager.Controllers;
using MetricsManager.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace MetricsManagerTests
{
    public class AgentsControllerTests
    {
        private AgentsController _agentsController;
        private AgentPool _agentPool;

        public AgentsControllerTests()
        {
            _agentPool = new AgentPool();
            _agentsController = new AgentsController(_agentPool);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void RegisterAgentTest(int agentId)
        {
            AgentInfo agentInfo = new AgentInfo() {AgentId = agentId, Enable = false};
            IActionResult result = _agentsController.RegisterAgent(agentInfo);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetAgentTest()
        {
            IActionResult actionResult = _agentsController.GetResult();
            OkObjectResult result = Assert.IsAssignableFrom<OkObjectResult>(actionResult);
            Assert.NotNull(result.Value as IEnumerable<AgentInfo>);
            Assert.NotEmpty((IEnumerable<AgentInfo>)result.Value);
        }
    }
}
