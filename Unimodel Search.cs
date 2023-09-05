public class Program
{
    public static int UnimodalSearch(int[] arr, int low, int high)
    {
        if (low == high)
        {
            return low;
        }

        int mid = (high + low) / 2;

        if (arr[mid - 1] < arr[mid] && arr[mid] > arr[mid + 1])
        {
            return mid;
        }
        else if (arr[mid] > arr[mid - 1])
        {
            return UnimodalSearch(arr, mid + 1, high);
        }
        else
        {
            return UnimodalSearch(arr, low, mid - 1);
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 10, 9, 7, 2 };
        int low = 0;
        int high = arr.Length - 1;

        int maxIndex = UnimodalSearch(arr, low, high);
        int maxElement = arr[maxIndex];

        Console.WriteLine("The maximum element is: " + maxElement);
        Console.WriteLine("At the index : " + maxIndex);
    }
}

//Complexity: O(log n)