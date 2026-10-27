namespace Assignment01;

internal class Pair<TKey, TValue>
{
    private TKey? Key;
    private TValue? Value;
    public void Add(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
    public TKey? GetKey()
    {
        return Key;
    }
    public TValue? GetValue()
    {
        return Value;
    }

}
