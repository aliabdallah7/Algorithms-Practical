class GuessNumber
{
    static int FindNumber(int low, int high)
    {
        if (low == high)
            return low;

        int mid = low + (high - low) / 2; // Avoid integer overflow

        Console.WriteLine($"Is the number less than or equal {mid}? (YES/NO)");
        string response = Console.ReadLine();

        if (response.ToUpper() == "YES")
            return FindNumber(low, mid);
        else
            return FindNumber(mid + 1, high);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess a Number game!");
        Console.Write("Enter the range start (A): ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Enter the range end (B): ");
        int B = int.Parse(Console.ReadLine());

        int guessedNumber = FindNumber(A, B);

        Console.WriteLine($"Your friend's guessed number is: {guessedNumber}");
    }
}
//Complexity: O(log n)