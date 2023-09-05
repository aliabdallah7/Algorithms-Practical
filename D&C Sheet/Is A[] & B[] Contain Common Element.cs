class CommonElementsFinder
{
    public static bool ContainsCommonElements(int[] A, int[] B)
    {
        // Step 1: Sort array A in O(n log n) time
        Array.Sort(A);

        // Step 2: Initialize a flag to check if a common element is found
        bool commonElementFound = false;

        // Step 3: Iterate through array B and perform binary search on A
        for (int i = 0; i < B.Length; i++)
        {
            int target = B[i];

            // Use binary search to check if target exists in A
            int left = 0;
            int right = A.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (A[mid] == target)
                {
                    // Common element found
                    commonElementFound = true;
                    break;
                }
                else if (A[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            // If a common element is found, break the loop
            if (commonElementFound)
            {
                break;
            }
        }

        // Step 4: Return true if a common element was found, otherwise false
        return commonElementFound;
    }

    public static void Main()
    {
        int[] A = { 3, 1, 4, 2, 5 };
        int[] B = { 4, 5, 6 };

        bool hasCommonElements = ContainsCommonElements(A, B);

        if (hasCommonElements)
        {
            Console.WriteLine("Common elements found between A and B.");
        }
        else
        {
            Console.WriteLine("No common elements found between A and B.");
        }
    }
}
//Complexity: O(n log n) + O(m log n) = O((n + m) log n) = O(n log n) where n is the length of A and m is the length of B.