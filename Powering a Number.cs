public class Program
{
    public static double PowNum(double A, int N)
    {
        if (N == 1)
        {
            return A;
        }
        else if (N == 0)
        {
            return 1;
        }

        int M = N / 2;
        double P = PowNum(A, M);

        if (N % 2 != 0)
        {
            return P * P * A;
        }
        else
        {
            return P * P;
        }
    }

    public static void Main(string[] args)
    {
        double A = 2.5;
        int N = 5;
        double result = PowNum(A, N);
        Console.WriteLine("The result is: " + result);
    }
}
//Complexity: O(log(n))