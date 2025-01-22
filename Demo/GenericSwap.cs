// GenericSwap.cs
// This class contains the generic swap method
public static class GenericSwap
{
    /// <summary>
    /// Generic method to swap two variables of any type.
    /// </summary>
    /// <typeparam name="T">The type of the variables to swap.</typeparam>
    /// <param name="first">Reference to the first variable.</param>
    /// <param name="second">Reference to the second variable.</param>
    public static void Swap<T>(ref T first, ref T second)
    {
        T temp = first;  // Temporary storage for the first variable
        first = second;  // Assign the second variable to the first
        second = temp;   // Assign the temporary value to the second
    }
}
