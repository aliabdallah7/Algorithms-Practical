class MaxDifference
{
    // Helper function to find the maximum of two integers
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // Helper function to find the minimum of two integers
    static int Min(int a, int b)
    {
        return (a < b) ? a : b;
    }

    // Recursive function to find the maximum difference in the array
    static int FindMaxDifference(int[] arr, int left, int right, out int maxVal, out int minVal)
    {
        if (left == right)
        {
            maxVal = arr[left];
            minVal = arr[left];
            return 0;
        }

        int mid = (left + right) / 2;
        int leftMax, leftMin, rightMax, rightMin;

        // Recursively find the maximum difference in the left and right subarrays
        int leftDiff = FindMaxDifference(arr, left, mid, out leftMax, out leftMin);
        int rightDiff = FindMaxDifference(arr, mid + 1, right, out rightMax, out rightMin);

        // Combine the results
        maxVal = Max(leftMax, rightMax);
        minVal = Min(leftMin, rightMin);

        // Calculate the maximum difference between left and right subarrays
        int crossDiff = leftMax - rightMin;

        // Return the maximum of the three differences
        return Max(Max(leftDiff, rightDiff), crossDiff);
    }

    // Main function to find the maximum difference in the array
    static int FindMaxDifference(int[] arr)
    {
        if (arr == null || arr.Length < 2)
        {
            throw new ArgumentException("Array should contain at least 2 elements.");
        }

        int maxVal, minVal;
        return FindMaxDifference(arr, 0, arr.Length - 1, out maxVal, out minVal);
    }

    static void Main()
    {
        int[] arr = { 2, 3, 18, 6, 4, 8, 1 };
        int maxDifference = FindMaxDifference(arr);
        Console.WriteLine("Maximum Difference: " + maxDifference); // Output: Maximum Difference: 9
    }
}
//Complexity: O(nlogn)