
namespace Assignment01;

internal static class Helper
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static T FindMax<T>(T[] values) where T : IComparable<T>
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.", nameof(values));
        }
        T max = values[0];
        foreach (T value in values)
        {
            if (value.CompareTo(max) > 0)
            {
                max = value;
            }
        }
        return max;
    }
}
