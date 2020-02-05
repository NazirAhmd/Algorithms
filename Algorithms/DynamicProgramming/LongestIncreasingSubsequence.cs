using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {
        public int LIS(int[] arr,int l,int h)
        {
            if (l == h)
                return 1;
            int max = LIS(arr, l + 1, h);
            if (arr[l] < arr[l + 1])
                return 1 + max;
            return max;
        }
    }
}
