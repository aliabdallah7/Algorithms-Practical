class Program
{
    static void Main()
    {
        int[] arr = { 2, 4, 6, 8, 10 };
        int x = 2;

        List<int[]> result = TwoItemsWithDifference(arr, x);

        if (result.Count > 0)
        {
            Console.WriteLine($"Pairs of numbers with a difference of {x}:");
            foreach (var pair in result)
            {
                Console.WriteLine($"({pair[0]}, {pair[1]})");
            }
        }
        else
        {
            Console.WriteLine($"There are no two numbers in the array with a difference of {x}.");
        }
    }

    static List<int[]> TwoItemsWithDifference(int[] arr, int x)
    {
        Array.Sort(arr);

        List<int[]> pairs = new List<int[]>();

        for (int i = 0; i < arr.Length; i++)
        {
            int target = arr[i] + x;
            if (BinarySearch(arr, target, i + 1, arr.Length - 1))
            {
                pairs.Add(new int[] { arr[i], target });
            }
        }

        return pairs;
    }

    static bool BinarySearch(int[] arr, int target, int low, int high)
    {
        if (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return true;
            else if (arr[mid] > target)
                return BinarySearch(arr, target, low, mid - 1);
            else
                return BinarySearch(arr, target, mid + 1, high);
        }

        return false;
    }
}
//Complexity: O(n log n)