// GenericLinearSearch.cs
// This class contains the generic linear search method
using System;
using System.Collections.Generic;

public static class GenericLinearSearch
{
    /// <summary>
    /// Generic method to perform a linear search in a collection.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the collection.</typeparam>
    /// <param name="collection">The collection to search in.</param>
    /// <param name="item">The item to search for.</param>
    /// <returns>The index of the item if found, or -1 if not found.</returns>
    public static int LinearSearch<T>(IEnumerable<T> collection, T item) where T : IEquatable<T>
    {
        int index = 0; // Index to track the current position in the collection
        foreach (var element in collection)
        {
            if (element.Equals(item)) // Check if the element matches the item
            {
                return index; // Return the index if a match is found
            }
            index++; // Move to the next element
        }
        return -1; // Return -1 if the item is not found
    }
}
