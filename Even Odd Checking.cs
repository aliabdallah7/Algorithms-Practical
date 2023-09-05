using System;

public class Program
{
    public static bool IsEvenOdd(int[] arr, int start, int end)
    {
        // Base case: when the array contains only one element
        if (start == end)
        {
            return arr[start] % 2 == 0;
        }

        // Divide: split the array into two halves
        int mid = (start + end) / 2;

        // Conquer: recursively check the two halves
        bool a = IsEvenOdd(arr, start, mid);
        bool b = IsEvenOdd(arr, mid + 1, end);

        // Combine: check the returned status from the two halves
        return a != b; // even + odd = odd
    }

    public static void Main(string[] args)
    {
        int[] arr = { 2, 4, 6, 8, 1, 3, 5, 7 };
        int start = 0;
        int end = arr.Length - 1;
        bool isEvenOdd = IsEvenOdd(arr, start, end);

        Console.WriteLine("The array contains an even number of even and odd elements: " + isEvenOdd);
    }
}
//Complexity: O(n)