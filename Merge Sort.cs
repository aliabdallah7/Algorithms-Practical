public class Program
{
    public static void MergeSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;
            MergeSort(arr, start, mid);
            MergeSort(arr, mid + 1, end);
            Merge(arr, start, mid, end);
        }
    }

    public static void Merge(int[] arr, int start, int mid, int end)
    {
        int n1 = mid - start + 1;
        int n2 = end - mid;
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];
        Array.Copy(arr, start, leftArray, 0, n1);
        Array.Copy(arr, mid + 1, rightArray, 0, n2);
        int i = 0, j = 0, k = start;

        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = rightArray[j];
            j++;
            k++;
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 9, 3, 7, 1, 8, 2, 5, 9, 4, 6 };
        int start = 0;
        int end = arr.Length - 1;

        Console.WriteLine("Original array elements: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        MergeSort(arr, start, end);

        Console.WriteLine("Sorted array elements: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
//Complexity: O(nlogn)
