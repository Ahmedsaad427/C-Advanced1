using System;

public class PersonQ : IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Implementing the Equals method
    public bool Equals(Person other)
    {
        if (other == null) return false;

        return this.Name == other.Name && this.Age == other.Age;
    }

    // Overriding Object.Equals for consistency
    public override bool Equals(object obj)
    {
        if (obj is Person otherPerson)
        {
            return Equals(otherPerson);
        }
        return false;
    }

    // Overriding GetHashCode
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}
