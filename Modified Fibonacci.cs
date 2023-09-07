class Program
{
    static int ModifiedFibonacci(int n)
    {
        if (n <= 0)
        {
            Console.WriteLine("Invalid input.");
            return -1;
        }

        if (n <= 3)
        {
            return 1;
        }

        int[] sequence = new int[n];

        sequence[0] = 1;
        sequence[1] = 1;
        sequence[2] = 1;

        for (int i = 3; i < n; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
        }

        return sequence[n - 1];
    }

    static void Main()
    {
        int n = 7;
        int result = ModifiedFibonacci(n);
        Console.WriteLine("Output: " + result);
    }
}
// Complexity: O(n)