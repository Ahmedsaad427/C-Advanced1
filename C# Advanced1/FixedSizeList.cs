using System;
using System.Collections.Generic;

namespace FixedSizeNamespace
{
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int _count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count >= _items.Length)
            {
                throw new InvalidOperationException("The list is full. Cannot add more elements.");
            }

            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");
            }

            return _items[index];
        }

        public int Count => _count;

        public int Capacity => _items.Length;
    }
}
