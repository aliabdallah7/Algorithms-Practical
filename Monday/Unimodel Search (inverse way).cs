public class Program
{
    public static int UnimodalSearch(int[] arr, int low, int high)
    {
        if (low == high)
        {
            return low;
        }

        int mid = (low + high) / 2;

        if (arr[mid] < arr[mid - 1] && arr[mid] < arr[mid + 1])
        {
            // Found the peak element
            return mid;
        }
        else if (arr[mid] > arr[mid + 1])
        {
            // Peak is on the right side
            return UnimodalSearch(arr, mid + 1, high);
        }
        else
        {
            // Peak is on the left side
            return UnimodalSearch(arr, low, mid - 1);
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 12, 9, 5, 3, 1, 4, 8, 10, 15 };
        int low = 0;
        int high = arr.Length - 1;
        int peakIndex = UnimodalSearch(arr, low, high);
        int peakElement = arr[peakIndex];

        Console.WriteLine("The peak element is: " + peakElement);
        Console.WriteLine("At the index " + peakIndex);
    }
}
