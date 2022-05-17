namespace MetricsAgent.Services
{
    public interface IRepository<T> where T : class
    {
    IList<T> GeAll();
    T GetById(int id);
    void Create(T item);
    void Update(T item);
    void Delete(T item);
    }
}
