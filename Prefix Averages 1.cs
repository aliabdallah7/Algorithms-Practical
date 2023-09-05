public class Program
{
    public static double[] PrefixAverages1(int[] X)
    {
        int length = X.Length;
        double[] A = new double[length];

        for (int i = 0; i < length; i++)
        {
            int s = X[0];
            for (int j = 1; j <= i; j++)
            {
                s += X[j];
            }
            A[i] = (double)s / (i + 1);
        }

        return A;
    }

    public static void Main()
    {
        int[] X = { 3, 1, 2, 6 };
        double[] A = PrefixAverages1(X);

        Console.WriteLine("Prefix Averages:");

        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine(A[i]);
        }
    }
}
//Complexity: O(n^2)