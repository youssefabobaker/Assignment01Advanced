namespace Assignment01;

internal class Container <T>
{
    private T? Value;

    public void Add(T value)
    {
        Value = value;
    }

    public T? Get()
    {
        return Value;
    }

}
