using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class MaximumCuts
    {
        public int CountRecursive(int n, int[] cuts)
        {
            if (n == 0)
                return 0;
            if (n < 0)
                return -1;
            int max = Math.Max(Math.Max(CountRecursive(n - cuts[0], cuts), CountRecursive(n - cuts[1], cuts)),
                            CountRecursive(n - cuts[2], cuts));
            return max >= 0 ? max + 1 : -1;
        }

        public int CountTabulation(int n, int[] cuts)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                dp[i] = -1;
                for (int j = 0; j < cuts.Length; j++)
                {
                    if (i >= cuts[j])
                    {
                        int subRes = dp[i - cuts[j]];
                        if (subRes != -1)
                            dp[i] = Math.Max(dp[i], subRes + 1);
                    }
                }
            }
            return dp[n];
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new MaximumCuts();
    //        //int[] arr = { 3, 4, 2, 8, 10 };
    //        //int[] arr = { 4, 10, 6, 5, 8, 11, 2, 20 };
    //        int[] arr = { 1, 2, 3 };
    //        Console.WriteLine(obj.CountRecursive(5, arr));
    //    }
    //}
}
