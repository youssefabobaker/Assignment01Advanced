
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
            //Helper.Swap<int>(ref x, ref y);
            //Console.WriteLine($"After Swap: x = {x}, y = {y}");
            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value
            //int[] numbers = { 1, 3, 5, 7, 9 };
            //Console.WriteLine($"Max number: {Helper.FindMax(numbers)}");
            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>. 
            //What is a generic interface? => A generic interface is an interface that is defined with type parameters, allowing it to be implemented by classes or structs that specify the actual types to be used. It enables the creation of flexible and reusable interfaces that can work with different data types while maintaining type safety.
            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            //What is the 'struct' constraint? => The 'struct' constraint in C# is used in generic type definitions to specify that the type parameter must be a value type (i.e., a struct). This constraint ensures that only value types can be used as arguments for the generic type.
            //int x = 5;
            //GenericConstraints01<int>.SetValue(x);
            //Console.WriteLine(GenericConstraints01<int>.GetValue());
            #endregion

            #region Q8: What is the 'class' constraint? Write an example. 
            //What is the 'class' constraint?=> The 'class' constraint in C# is used in generic type definitions to specify that the type parameter must be a reference type (i.e., a class). This constraint ensures that only reference types can be used as arguments for the generic type.
            //string x = "Hello";
            //GenericConstraints02<string>.SetValue(x);
            //Console.WriteLine(GenericConstraints02<string>.GetValue());
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            //What is the 'new()' constraint? => The 'new()' constraint in C# is used in generic type definitions to specify that the type parameter must have a public parameterless constructor. This constraint ensures that instances of the type can be created using the 'new' keyword without any arguments.
            //Cone coneInstance = GenericConstraints03<Cone>.CreateInstance();
            #endregion

            #region Q10:  What is the interface constraint? Write an example.
            //What is the interface constraint? => The interface constraint in C# is used in generic type definitions to specify that the type parameter must implement a particular interface.
            //Cone coneInstance = new Cone();
            //GenericConstraints04<Cone>.DrawShape(coneInstance);
            #endregion

            #region Q11: What is the base class constraint? Write an example. 
            // What is the base class constraint? => The base class constraint in C# is used in generic type definitions to specify that the type parameter must inherit from a particular base class.
            //GenericConstraints05<Dog>.Train(new Dog { Name = "abc" });
            #endregion

            #region Q12: How do you apply multiple constraints? Write an example.  
            //How do you apply multiple constraints? => You can apply multiple constraints to a generic type parameter by separating them with commas. 
            //GenericConstraints06<Animal>.DisplayInfo(new Animal { Name = "abc" });
            #endregion






        }


    }
}
