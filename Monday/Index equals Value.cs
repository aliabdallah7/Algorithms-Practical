internal class Program
{
    static bool isindex(int[] arr, int s, int e)
    {
        int mid;

        if (e >= s)
        {
            mid = (e + s) / 2;
            if (arr[mid] == mid)
            {
                return true;

            }
            else if (arr[mid] > mid)
            {
                return isindex(arr, s, mid - 1);

            }
            else
            {
                return isindex(arr, mid + 1, e);
            }
        }

        return false;
    }

    public static void Main()
    {
        int[] arr = { -1, 1, 4, 5, 20 };
        bool y = isindex(arr, 0, arr.Length - 1);
        Console.WriteLine(y);
    }
}

//Complexity: O(log n)