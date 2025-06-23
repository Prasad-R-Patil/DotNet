
namespace GenericRepoCurd;

internal class CommanRepository<T> : ICommonRepository<T> where T : class
{
    public readonly List<T> _list;

    public CommanRepository()
    {
        _list = new List<T>();
    }


    public List<T> GetAll()
    {
        return _list;
    }

    public T getDetails(int id)
    {
        return _list[id];
    }

    public int Insert(T item)
    {
        _list.Add(item);
        return 1;
    }

    public void Update(T item)
    {
        
       
    }
    public void Delete(T item)
    {
        _list.Remove(item);
    }
}
