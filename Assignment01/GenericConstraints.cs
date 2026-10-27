namespace Assignment01;

internal static class GenericConstraints01 <T> where T : struct
{
    private static T Value;
    public static void SetValue(T value)
    {
        Value = value;
    }
    public static T GetValue()
    {
        return Value;
    }
}

internal static class GenericConstraints02<T> where T : class
{
    private static T? Value;
    public static void SetValue(T value)
    {
        Value = value;
    }
    public static T? GetValue()
    {
        return Value;
    }
}

internal static class GenericConstraints03<T> where T : new()
{
    public static T CreateInstance()
    {
        return new T();
    }
}

internal class Cone
{
    public Cone()
    {
        Console.WriteLine("cone class constructor");
    }
}
