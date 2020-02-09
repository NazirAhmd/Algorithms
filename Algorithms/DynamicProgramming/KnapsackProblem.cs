using System;

namespace Algorithms.DynamicProgramming
{
    /// <summary>
    /// Return maximum value attainable in a knapsack for an item having some value
    /// </summary>
    public class KnapsackProblem
    {
        public int KnapSackRecursive(int wt, int[] w, int[] v, int n)
        {
            if (wt == 0 || n == 0)
                return 0;
            if (w[n - 1] > wt)
                return KnapSackRecursive(wt, w, v, n - 1);
            else
                return Math.Max(KnapSackRecursive(wt, w, v, n - 1), 
                    v[n - 1] + KnapSackRecursive(wt - w[n - 1], w, v, n - 1));
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new KnapsackProblem();
    //        int[] w = { 5, 4, 6, 3 };
    //        int[] v = { 10, 40, 30, 50 };
    //        Console.WriteLine(obj.KnapSackRecursive(10, w, v, w.Length));
    //    }
    //}
}
