using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {
        //Incorrect
        //public int LisRecursive(int[] arr)
        //{
        //    int globalMax = 1;
        //    Lis(arr, arr.Length, ref globalMax);
        //    return globalMax;
        //}
        //private int Lis(int[] arr, int n,ref int max)
        //{
        //    if (n == 1)
        //        return 1;
        //    int res = 1;
        //    for (int i = 1; i < n; i++)
        //    {
        //        int subRes=Lis(arr, i , ref max);
        //        res = Math.Max(res, subRes+1);
        //    }
        //    max = Math.Max(max, res);
        //    return res;
        //}
    }
}
