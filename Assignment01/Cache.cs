
namespace Assignment01;
internal class Cache <TKey, TValue>
{
    public void Add(TKey key, TValue value)
    {
    }

    public TValue? Get(TKey key)
    {
        return default;
    }

    public void Remove(TKey key)
    {
    }

    public bool Contains(TKey key)
    {
        return false;
    }

    public void SetExpiration(TKey key, TimeSpan expiration)
    {
    }
}
