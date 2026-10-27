
namespace Assignment01;

internal interface IRepository<T>
{
    public void Add(T item);
    public T Get();
}
