class Program
{
    static bool AreEquivalentStrings(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        string doubledA = a + a;

        return doubledA.Contains(b);
    }

    static void Main()
    {
        // Sample Input 1
        string input1_a = "aaba";
        string input1_b = "abaa";
        bool result1 = AreEquivalentStrings(input1_a, input1_b);
        Console.WriteLine("Sample Output 1: " + result1);  // Should print True

        // Sample Input 2
        string input2_a = "aabb";
        string input2_b = "abab";
        bool result2 = AreEquivalentStrings(input2_a, input2_b);
        Console.WriteLine("Sample Output 2: " + result2);  // Should print False
    }
}
//Complexity: O(n) where n is the length of the string