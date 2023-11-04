using AlgorithmsCSharp.DataStructures.Arrays;


namespace AlgorithmsCS
{
    public class Program
    {
        static public void Main()
        {
            // Brute force: Time Complexity: O(n^2), Space complexity: O(1)
            // ({ 2, 7, 11, 15 }, 9);
            // ({ 3, 2, 4 }, 6);
            // ({ 3, 3 }, 6);
            int[] resultOfBruteForce = TwoSum.TwoSumBruteForce(new int[] { 0, 4, 3, 0 }, 0);
            Console.WriteLine("------------------ BruteForce Solution ------------------");
            Console.WriteLine("--------- Time Complexity: O(n^2), Space complexity: O(1)  ---------");
            Console.WriteLine(string.Join(" ", resultOfBruteForce));

            Console.WriteLine();

            // Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
            // ({ 2, 7, 11, 15 }, 9);
            // ({ 3, 2, 4 }, 6);
            // ({ 3, 3 }, 6);
            int[] resultOfOptimized = TwoSum.TwoSumOptimized(new int[] { 1, 1, 2, 1, 1, 2 }, 4);
            Console.WriteLine("------------------ Optimized Solution ------------------");
            Console.WriteLine("--------- Time Complexity: O(n), Space complexity: O(n)   ---------");
            Console.WriteLine(string.Join(" ", resultOfOptimized));
        }
    }
}