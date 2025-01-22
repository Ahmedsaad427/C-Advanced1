using System;
using System.Collections.Generic;

public class PersonC
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class PersonEqualityComparer : IEqualityComparer<Person>
{
    // Equals method to compare two Person objects
    public bool Equals(Person x, Person y)
    {
        if (x == null || y == null) return false;
        return x.Name == y.Name && x.Age == y.Age;
    }

    // GetHashCode method to generate a hash code based on Name and Age
    public int GetHashCode(Person obj)
    {
        if (obj == null) return 0;
        return HashCode.Combine(obj.Name, obj.Age);
    }
}
