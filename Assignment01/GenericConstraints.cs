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
