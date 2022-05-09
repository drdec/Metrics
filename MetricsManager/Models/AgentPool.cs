namespace MetricsManager.Models
{
    public class AgentPool
    {
        private Dictionary<int, AgentInfo> _values;

        public Dictionary<int, AgentInfo> Values
        {
            get => _values;
            set => _values = value;
        }

        public AgentPool()
        {
            _values = new Dictionary<int, AgentInfo>();
        }

        public void Add(AgentInfo agentInfo)
        {
            if (!_values.ContainsKey(agentInfo.AgentId))
            {
                _values.Add(agentInfo.AgentId, agentInfo);
            }
        }

        public AgentInfo[] Get()
        {
            return Values.Values.ToArray();
        }
    }
}
