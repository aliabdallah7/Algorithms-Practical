public class Program
{
    static int BinarySearch(int[] arr, int l, int r, int x)
    {
        if (r >= l)
        {
            int mid = l + (r - l) / 2;

            // If the element is present at the middle itself
            if (arr[mid] == x)
                return mid;

            // If the element is smaller than mid, then it can only be present in the left subarray
            if (arr[mid] > x)
                return BinarySearch(arr, l, mid - 1, x);

            // Else the element can only be present in the right subarray
            return BinarySearch(arr, mid + 1, r, x);
        }

        // We reach here when the element is not present in the array
        return -1;
    }

    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40, 50 };
        int n = arr.Length;
        int x = 10;

        int result = BinarySearch(arr, 0, n - 1, x);

        if (result == -1)
            Console.WriteLine("Element is not present in the array");
        else
            Console.WriteLine("Element is present at index " + result);

        //Complexity: O(log n)
    }
}
