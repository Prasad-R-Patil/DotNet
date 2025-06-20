
namespace GenericRepository;

internal class CommonRespository<T> : ICommonRespository<T> where T : class
{
    private readonly List<T> _list;
    public CommonRespository()
    {
        _list = new List<T>();
    }
    public List<T> GetAll()
    {
        return _list;
    }

    public T GetDetails(int id)
    {
        return _list[0];
    }

    public int Insert(T item)
    {
        _list.Add(item);
        return 1;
    }

    public int Update(T item)
    {
        throw new NotImplementedException();
    }
    public int Delete(T item)
    {
        throw new NotImplementedException();
    }
}
