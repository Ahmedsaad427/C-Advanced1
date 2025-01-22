using System;

public class PersonI : IComparable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        if (obj is Person otherPerson)
        {
            return Age.CompareTo(otherPerson.Age);
        }

        throw new ArgumentException("Object is not a Person");
    }
}
