using System;

class Program
{
    static int LongestCommonSubsequenceLength(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        // Create a 2D array to store the LCS lengths
        int[,] dp = new int[m + 1, n + 1];

        // Build the dp array
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        // The length of the LCS is stored in dp[m, n]
        return dp[m, n];
    }

    static void Main(string[] args)
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        int lcsLength = LongestCommonSubsequenceLength(str1, str2);
        Console.WriteLine("Length of Longest Common Subsequence: " + lcsLength);
    }
}
//Complexity: O(mn)