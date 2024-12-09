namespace Learning.Generics;

public class InMemoryRepository<T>
    : IRepository<T> where T : class
{
    private readonly Dictionary<int, T> _store = [];
    private int _nextId = 1;

    public void Add(T item)
    {
        _store[_nextId++] = item;
    }

    public T GetById(int id)
    {
        return _store.TryGetValue(id, out T? value) ? value : null;
    }

    public IEnumerable<T> GetAll()
    {
        return _store.Values;
    }
}
