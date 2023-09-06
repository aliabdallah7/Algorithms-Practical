class Program
{
    static int fibbonacci(int N)
    {
        if (N <= 1)
            return 1;

        else
            return fibbonacci(N - 1) + fibbonacci(N - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The fibbonacci sequence of {N} is :\n{fibbonacci(N)}");
    }
}
//Complexity: O(2^n)