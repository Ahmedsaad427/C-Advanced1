#region FirstQ
/*
 The Bubble Sort algorithm can be optimized by adding a flag to check whether any swaps were made during a particular pass through the array. If no swaps are made, it means the array is already sorted, and the algorithm can terminate early, saving unnecessary iterations.

Optimized Bubble Sort Algorithm
Here’s how the optimization works:

Use a bool flag (e.g., swapped) to track whether any swaps occur in a pass.
If no swaps are made during a pass, the algorithm stops early since the array is sorted.
This reduces the number of iterations in cases where the array becomes sorted before completing all passes.
*/

//using System;

//class OptimizedBubbleSort
//{
//    static void BubbleSort(int[] arr)
//    {
//        int n = arr.Length;
//        bool swapped;

//        for (int i = 0; i < n - 1; i++)
//        {
//            swapped = false;

//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (arr[j] > arr[j + 1])
//                {
//                    int temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;

//                    swapped = true; 
//                }
//            }

//            if (!swapped)
//                break;
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
//        Console.WriteLine("Original array:");
//        Console.WriteLine(string.Join(" ", arr));

//        BubbleSort(arr);

//        Console.WriteLine("Sorted array:");
//        Console.WriteLine(string.Join(" ", arr));
//    }
//}

#endregion
#region SecondQ
//using System;
//using RangeNamespace;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var intRange = new Range<int>(10, 20);
//        Console.WriteLine(intRange.IsInRange(15)); // True
//        Console.WriteLine(intRange.IsInRange(25)); // False
//        Console.WriteLine(intRange.Length());      // 10

//        var doubleRange = new Range<double>(1.5, 3.5);
//        Console.WriteLine(doubleRange.IsInRange(2.0)); // True
//        Console.WriteLine(doubleRange.IsInRange(4.0)); // False
//        Console.WriteLine(doubleRange.Length());      // 2.0

//        var charRange = new Range<char>('a', 'f');
//        Console.WriteLine(charRange.IsInRange('c')); // True
//        Console.WriteLine(charRange.IsInRange('z')); // False
//        Console.WriteLine(charRange.Length());      // 6
//    }
//}

#endregion
#region ThirdQ
//using System;
//using System.Collections;

//class Program
//{
//    static void ReverseArrayList(ArrayList list)
//    {
//        int left = 0, right = list.Count - 1;

//        while (left < right)
//        {
//            var temp = list[left];
//            list[left] = list[right];
//            list[right] = temp;

//            left++;
//            right--;
//        }
//    }

//    static void Main(string[] args)
//    {
//        ArrayList arrayList = new ArrayList { "A", "B", "C", "D", "E" };
//        Console.WriteLine("Original ArrayList: " + string.Join(", ", arrayList));

//        ReverseArrayList(arrayList);

//        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList));
//    }
//}


#endregion
#region FourthQ
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static List<int> GetEvenNumbers(List<int> numbers)
//    {
//        List<int> evens = new List<int>();
//        foreach (int number in numbers)
//        {
//            if (number % 2 == 0)
//            {
//                evens.Add(number);
//            }
//        }
//        return evens;
//    }

//    static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        Console.WriteLine("Original List: " + string.Join(", ", numbers));

//        List<int> evenNumbers = GetEvenNumbers(numbers);

//        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
//    }
//}

#endregion
#region FifthQ
//using System;
//using FixedSizeNamespace;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            FixedSizeList<string> list = new FixedSizeList<string>(3);

//            Console.WriteLine($"List capacity: {list.Capacity}");
//            Console.WriteLine($"Current count: {list.Count}");

//            list.Add("Ahmed");
//            list.Add("Mohamed");
//            list.Add("Saad");

//            Console.WriteLine($"Current count after adding elements: {list.Count}");
//            Console.WriteLine($"Element at index 0: {list.Get(0)}");
//            Console.WriteLine($"Element at index 2: {list.Get(2)}");

//            Console.WriteLine("Attempting to add another element...");
//            list.Add("Date");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }

//        try
//        {
//            FixedSizeList<int> numbers = new FixedSizeList<int>(2);

//            numbers.Add(10);
//            numbers.Add(20);

//            Console.WriteLine("Attempting to access an invalid index...");
//            Console.WriteLine(numbers.Get(5));
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

#endregion
#region SixthQ
//using System;
//using System.Collections.Generic;

//class Program
//{
//    public static int FirstNonRepeatedCharacter(string input)
//    {
//        Dictionary<char, int> charCount = new Dictionary<char, int>();

//        foreach (char c in input)
//        {
//            if (charCount.ContainsKey(c))
//            {
//                charCount[c]++;
//            }
//            else
//            {
//                charCount[c] = 1;
//            }
//        }

//        for (int i = 0; i < input.Length; i++)
//        {
//            if (charCount[input[i]] == 1)
//            {
//                return i;
//            }
//        }

//        return -1;
//    }

//    static void Main(string[] args)
//    {
//        string input = "Ahmed";
//        int index = FirstNonRepeatedCharacter(input);
//        Console.WriteLine(index);
//    }
//}

#endregion