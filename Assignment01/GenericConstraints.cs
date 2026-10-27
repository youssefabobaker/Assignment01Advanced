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

internal class Cone : IShape
{
    public Cone()
    {
        Console.WriteLine("cone class constructor");
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a cone");
    }
}

internal interface IShape
{
    void Draw();
}

internal static class GenericConstraints04<T> where T : IShape
{
    public static void DrawShape(T shape)
    {
        shape.Draw();
    }
}


