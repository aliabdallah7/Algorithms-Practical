class Program
{
    static int multiply(int A, int N)
    {
        if (N == 0 || A == 0)
            return 0;

        int M = N / 2;
        int sum = multiply(A, M);
        if (N % 2 == 0)
            return sum + sum;
        else
            return sum + sum + A;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(multiply(5, 6));
    }
}
//Complexity: O(log N)