namespace GenericRepository;

// T - Type

internal interface ICommonRespository<T>
{
    List<T> GetAll();
    T GetDetails(int id);
    int Insert(T item);
    int Update(T item);
    int Delete(T item);
}
