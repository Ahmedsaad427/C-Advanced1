using System;
using System.Collections.Generic;

public class PersonComparer : IComparer<Person>
{
    // Compare method to compare two Person objects based on Age
    public int Compare(Person x, Person y)
    {
        if (x == null || y == null)
            return 0;

        return x.Age.CompareTo(y.Age); // Compare based on Age
    }
}
