class Program
{
    static int BinarySearch(string input, char target)
    {
        int left = 0, right = input.Length - 1, firstOccurrence = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (input[mid] == target)
            {
                firstOccurrence = mid;
                left = mid + 1;
            }
            else if (input[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return firstOccurrence == -1 ? 0 : firstOccurrence + 1;
    }

    static void Main()
    {
        string input = "Aaaabbbbb";
        int countA = BinarySearch(input, 'a');
        int countB = input.Length - countA;

        Console.WriteLine($"Number of 'a': {countA}");
        Console.WriteLine($"Number of 'b': {countB}");
    }
}

//Complexity: O(log n)