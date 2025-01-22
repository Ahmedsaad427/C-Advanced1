using System;

namespace RangeNamespace
{
    public class Range<T> where T : IComparable<T>
    {
        private T _min;
        private T _max;

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Minimum value cannot be greater than the maximum value.");

            _min = min;
            _max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
        }

        public dynamic Length()
        {
            if (typeof(T) == typeof(char))
            {
                return Convert.ToInt32(_max) - Convert.ToInt32(_min) + 1;
            }

            return (dynamic)_max - (dynamic)_min;
        }
    }
}
