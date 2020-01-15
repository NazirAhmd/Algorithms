using System;

namespace Algorithms.Sorting
{
    public class ChocolateDistribution
    {
        public static int Minimize(int[] arr, int m)
        {
            Array.Sort(arr);
            int res = int.MaxValue;
            for (int i = 0; i + m - 1 < arr.Length; i++)
            {
                res = Math.Min(res, Math.Abs(arr[i] - arr[i + m - 1]));
            }
            return res;
        }
    }
}
