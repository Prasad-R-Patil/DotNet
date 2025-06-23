namespace GenericRepoCurd;

internal interface ICommonRepository<T>
{
    List<T> GetAll();
    T getDetails(int id);

    int Insert(T item);
    void Update(T item);
    void Delete(T item);
   

}
