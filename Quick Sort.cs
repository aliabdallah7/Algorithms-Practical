public class Program
{
    // A utility function to swap two elements
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // This function takes the last element as pivot,
    // places the pivot element at its correct position
    // in the sorted array, and places all smaller elements to the left
    // of the pivot and all greater elements to the right of the pivot.
    static int Partition(int[] arr, int low, int high)
    {
        // Choosing the pivot
        int pivot = arr[high];

        // Index of the smaller element and indicates
        // the right position of pivot found so far
        int i = (low - 1);

        for (int j = low; j <= high - 1; j++)
        {
            // If the current element is smaller than the pivot
            if (arr[j] < pivot)
            {
                // Increment the index of the smaller element
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return (i + 1);
    }

    // The main function that implements QuickSort
    // arr[] --> Array to be sorted,
    // low --> Starting index,
    // high --> Ending index
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // pi is the partitioning index, arr[p]
            // is now at the right place
            int pi = Partition(arr, low, high);

            // Separately sort elements before
            // and after the partition index
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    // Driver Code
    public static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        int N = arr.Length;

        // Function call
        QuickSort(arr, 0, N - 1);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < N; i++)
            Console.Write(arr[i] + " ");
    }
}