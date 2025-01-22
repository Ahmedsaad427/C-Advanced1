// Person.cs
using System;

public class Person : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Override Equals to compare properties for equality
    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return Equals(other);
        }
        return false;
    }

    // Implement IEquatable for strongly-typed equality
    public bool Equals(Person other)
    {
        return other != null && Name == other.Name && Age == other.Age;
    }

    // Override GetHashCode to maintain consistency with Equals
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }

    // Override == and != operators
    public static bool operator ==(Person left, Person right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }

    public static bool operator !=(Person left, Person right)
    {
        return !(left == right);
    }
}
