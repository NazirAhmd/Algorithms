using System;

namespace Algorithms.DynamicProgramming
{
    public class LongestCommonSubsequence
    {
        /// <summary>
        /// Naive recurive way to find LCS
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <param name="m">First string length</param>
        /// <param name="n">Second string length</param>
        /// <returns></returns>
        public int Recursive(string a, string b, int m, int n)
        {
            if (m == 0 || n == 0)
                return 0;
            if (a[m - 1] == b[n - 1])
                return 1 + Recursive(a, b, m - 1, n - 1);
            return Math.Max(Recursive(a, b, m, n - 1), Recursive(a, b, m - 1, n));
        }

        public int Memoization(string a, string b, int m, int n)
        {
            int[,] memo = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    memo[i, j] = -1;
                }
            }
            return Count(a, b, m, n, memo);
        }

        private int Count(string a, string b, int m, int n, int[,] memo)
        {
            if (memo[m, n] != -1)
                return memo[m, n];
            if (m == 0 || n == 0)
                memo[m, n] = 0;
            else
            {
                if (a[m - 1] == b[n - 1])
                    memo[m, n] = 1 + Count(a, b, m - 1, n - 1, memo);
                else
                    memo[m, n] = Math.Max(Count(a, b, m, n - 1, memo), Count(a, b, m - 1, n, memo));
            }
            return memo[m, n];
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new LongestCommonSubsequence();
    //        string a = "XYZ", b = "XASSDZ";
    //        Console.WriteLine(obj.Memoization(a, b, a.Length, b.Length));
    //    }
    //}
}
