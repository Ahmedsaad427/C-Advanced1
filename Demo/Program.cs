#region GenericSwap
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Example 1: Swap integers
//        int a = 10, b = 20;
//        Console.WriteLine("Example 1: Swap integers");
//        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
//        GenericSwap.Swap(ref a, ref b); // Calling the generic swap method
//        Console.WriteLine($"After Swap: a = {a}, b = {b}");
//        Console.WriteLine();

//        // Example 2: Swap strings
//        string x = "Ahmed", y = "Saad";
//        Console.WriteLine("Example 2: Swap strings");
//        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
//        GenericSwap.Swap(ref x, ref y); // Calling the generic swap method
//        Console.WriteLine($"After Swap: x = {x}, y = {y}");
//        Console.WriteLine();

//        // Example 3: Swap custom types (e.g., doubles)
//        double p = 3.14, q = 2.71;
//        Console.WriteLine("Example 3: Swap doubles");
//        Console.WriteLine($"Before Swap: p = {p}, q = {q}");
//        GenericSwap.Swap(ref p, ref q); // Calling the generic swap method
//        Console.WriteLine($"After Swap: p = {p}, q = {q}");
//    }
//}

#endregion

#region GenericLinearSearch
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Example 1: Linear search in an integer array
//        int[] numbers = { 10, 20, 30, 40, 50 };
//        Console.WriteLine("Example 1: Linear search in an integer array");
//        int numberToFind = 30;
//        int index = GenericLinearSearch.LinearSearch(numbers, numberToFind);
//        Console.WriteLine(index != -1
//            ? $"Number {numberToFind} found at index {index}."
//            : $"Number {numberToFind} not found.");
//        Console.WriteLine();

//        // Example 2: Linear search in a string array
//        string[] names = { "Ahmed", "Saad", "Youssef", "Mohamed" };
//        Console.WriteLine("Example 2: Linear search in a string array");
//        string nameToFind = "Charlie";
//        index = GenericLinearSearch.LinearSearch(names, nameToFind);
//        Console.WriteLine(index != -1
//            ? $"Name '{nameToFind}' found at index {index}."
//            : $"Name '{nameToFind}' not found.");
//        Console.WriteLine();

//        // Example 3: Linear search in a double array
//        double[] prices = { 1.99, 2.99, 3.99, 4.99 };
//        Console.WriteLine("Example 3: Linear search in a double array");
//        double priceToFind = 3.99;
//        index = GenericLinearSearch.LinearSearch(prices, priceToFind);
//        Console.WriteLine(index != -1
//            ? $"Price {priceToFind} found at index {index}."
//            : $"Price {priceToFind} not found.");
//    }
//}


#endregion

#region ClassAndStructInEquality
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Example 1: Equality in Class
//        var person1 = new Person { Name = "Ahmed", Age = 25 };
//        var person2 = new Person { Name = "Saad", Age = 25 };
//        var person3 = new Person { Name = "Mohamed", Age = 30 };

//        Console.WriteLine("Class Equality:");
//        Console.WriteLine(person1 == person2); // True
//        Console.WriteLine(person1 == person3); // False
//        Console.WriteLine();

//        // Example 2: Equality in Struct
//        var point1 = new Point { X = 5, Y = 10 };
//        var point2 = new Point { X = 5, Y = 10 };
//        var point3 = new Point { X = 10, Y = 15 };

//        Console.WriteLine("Struct Equality:");
//        Console.WriteLine(point1 == point2); // True
//        Console.WriteLine(point1 == point3); // False
//    }
//}

#endregion

#region BubbleSort
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Integer array
//        int[] intArray = { 64, 34, 25, 12, 22, 11, 90 };
//        Console.WriteLine("Original Integer Array:");
//        PrintArray(intArray);

//        BubbleSort.Sort(intArray);
//        Console.WriteLine("Sorted Integer Array:");
//        PrintArray(intArray);

//        // String array
//        string[] stringArray = { "Banana", "Apple", "Cherry", "Mango", "Peach" };
//        Console.WriteLine("\nOriginal String Array:");
//        PrintArray(stringArray);

//        BubbleSort.Sort(stringArray);
//        Console.WriteLine("Sorted String Array:");
//        PrintArray(stringArray);
//    }

//    static void PrintArray<T>(T[] array)
//    {
//        foreach (T item in array)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }
//}

#endregion

#region Icomparable vs GenericIcomparable  
/*
Works with the base object type.
Requires casting the obj parameter to the specific type, which can lead to runtime errors if the type is not compatible.
No compile-time type checking, making it less type-safe.
Common in older C# code, before generics were introduced.
 */
#endregion

#region Generic BuiltIn IEquatable<T>

/*
Allows you to define equality logic specific to the type T.
Provides a strongly-typed alternative to overriding the Equals(object) method.
Avoids boxing/unboxing, improving performance for value types.
When to Use IEquatable<T>
When you want to compare objects of the same type for equality in a type-safe manner.
When you want better performance for value types (compared to the Equals(object) method).
When using objects in collections like dictionaries or sets, which rely on equality checks.
*/
//using System;

//class Program
//{
//    static void Main()
//    {
//        var person1 = new PersonQ { Name = "Ahmed", Age = 30 };
//        var person2 = new PersonQ { Name = "Saad", Age = 30 };
//        var person3 = new PersonQ { Name = "Mohamed", Age = 25 };

//        // Using IEquatable<T> implementation
//        Console.WriteLine(person1.Equals(person2)); // Output: True
//        Console.WriteLine(person1.Equals(person3)); // Output: False

//        // Using Object.Equals (calls overridden Equals)
//        Console.WriteLine(person1.Equals((object)person2)); // Output: True
//    }
//}


#endregion

#region EqualityComparer
/*
 Purpose:
Equals(T x, T y): Compares two objects of type T to determine whether they are equal.
GetHashCode(T obj): Returns a hash code for the object, which is used for efficient searching in hash-based collections like HashSet<T> and Dictionary<TKey, TValue>.
When to Use IEqualityComparer<T>
When you want to define custom equality comparison logic for a specific type.
When working with collections like Dictionary, HashSet, or List<T> where you need to provide a custom method to compare objects for equality.
When the default Equals and GetHashCode are not sufficient or you need more specialized logic for object comparison.
 */

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        var person1 = new Person { Name = "Ahmed", Age = 30 };
//        var person2 = new Person { Name = "Ahmed", Age = 30 };
//        var person3 = new Person { Name = "Karam", Age = 25 };

//        var people = new HashSet<Person>(new PersonEqualityComparer())
//        {
//            person1,
//            person3
//        };

//        // Try adding a person with the same Name and Age as person1
//        bool added = people.Add(person2);

//        Console.WriteLine("Person2 added: " + added); // Output: False (because person2 equals person1 based on custom equality comparer)
//    }
//}

#endregion

#region IcomparerWithBubbleSort
/*
 Purpose:
The Compare(T x, T y) method is used to compare two objects of type T.
Returns:
A value less than 0 if x is less than y.
0 if x equals y.
A value greater than 0 if x is greater than y.
 */

//using System;
//using System.Collections.Generic;

//public class BubbleSort
//{
//    public static void Sort<T>(List<T> list, IComparer<T> comparer)
//    {
//        int n = list.Count;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (comparer.Compare(list[j], list[j + 1]) > 0)
//                {
//                    // Swap elements if they are in the wrong order
//                    T temp = list[j];
//                    list[j] = list[j + 1];
//                    list[j + 1] = temp;
//                }
//            }
//        }
//    }
//}

#endregion

#region GenericConstrains
/*
 Types of Constraints
class: Restricts the type parameter to reference types only (i.e., classes, interfaces, delegates, and arrays).
struct: Restricts the type parameter to value types only (i.e., structs, enums, and primitive types).
new(): Restricts the type parameter to types that have a parameterless constructor.
T : SomeBaseClass: Restricts the type parameter to a type that is derived from a specific base class.
T : ISomeInterface: Restricts the type parameter to types that implement a specific interface.
T : U: Restricts the type parameter to be or derive from another generic type parameter.
*/

/*
 Class :

public class MyClass<T> where T : class
{
    private T _value;

    public MyClass(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}

Struct:

public class MyClass<T> where T : struct
{
    private T _value;

    public MyClass(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}


New:

public class MyClass<T> where T : new()
{
    private T _value;

    public MyClass()
    {
        _value = new T();  // Calls the parameterless constructor
    }

    public T GetValue()
    {
        return _value;
    }
}
T : SomeBaseClass:

public class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

public class MyClass<T> where T : Animal
{
    private T _animal;

    public MyClass(T animal)
    {
        _animal = animal;
    }

    public void CallSpeak()
    {
        _animal.Speak();
    }
}
T : ISomeInterface:

public interface IDriveable
{
    void Drive();
}

public class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Driving a car...");
    }
}

public class MyClass<T> where T : IDriveable
{
    private T _vehicle;

    public MyClass(T vehicle)
    {
        _vehicle = vehicle;
    }

    public void StartDriving()
    {
        _vehicle.Drive();
    }
}
 Multiple Constraints:

public class MyClass<T> where T : class, new(), IComparable<T>
{
    private T _value;

    public MyClass()
    {
        _value = new T();  // T must have a parameterless constructor
    }

    public void CompareValues(T other)
    {
        Console.WriteLine(_value.CompareTo(other));
    }
}


Generic constraints in C# provide a way to enforce specific type requirements for your generics, ensuring that the types passed in meet certain conditions. They offer flexibility and ensure type safety, enabling you to call specific methods and use properties that would otherwise be unavailable for all types. The constraints available include:

class and struct (for reference and value types),
new() (for parameterless constructors),
base class and interface constraints,
and multiple constraints together.

 */
#endregion