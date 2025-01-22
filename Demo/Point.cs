// Point.cs
using System;

public struct Point : IEquatable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }

    // Implement IEquatable for strongly-typed equality
    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }

    // Override Equals for object type comparison
    public override bool Equals(object obj)
    {
        if (obj is Point other)
        {
            return Equals(other);
        }
        return false;
    }

    // Override GetHashCode
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    // Override == and != operators
    public static bool operator ==(Point left, Point right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Point left, Point right)
    {
        return !(left == right);
    }
}
