namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            // What is a generic class? Why use generics? => is a class that can work with any data type. Generics allow you to define a class with placeholders for the data types it operates on, providing type safety and code reusability.
            #endregion

            #region Q3:What are multiple type parameters? Write Pair<TKey, TValue >.
            //What are multiple type parameters? => Multiple type parameters allow a generic class or method to accept more than one type argument, enabling it to work with different types simultaneously. This enhances flexibility and allows for more complex data structures and algorithms.
            //Pair<int, string> pair = new Pair<int, string>();
            #endregion

            #region Q4: What is a generic method? Write Swap<T> method
            //What is a generic method? => A generic method is a method that is defined with type parameters, allowing it to operate on different data types while maintaining type safety. It enables code reuse and flexibility by allowing the same method to work with various types without the need for multiple overloads.
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            //Swap<int>(ref x, ref y);
            //Console.WriteLine($"After Swap: x = {x}, y = {y}");
            #endregion

        }

        //public static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
