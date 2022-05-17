namespace MetricsManager.Services
{
    public interface IAgentPool<T>
    {
        void Add(T agentInfo);
        T[] Get();
        Dictionary<int, T> Values { get; set; }
    }
}
