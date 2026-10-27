namespace Assignment01;

internal static class GenericConstraints <T> where T : struct
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
