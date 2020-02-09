using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class MinimumJumps
    {
        public int CountRecursive(int[] jumps, int n = 0)
        {
            if (n == jumps.Length - 1)
                return 0;
            //if (n < 0)
            //    return -1;

            int res = int.MaxValue;
            for (int i = n; i < jumps.Length; i++)
            {
                for (int j = 1; j <= jumps[i]; j++)
                {
                    int subRes = CountRecursive(jumps, n + j);
                    res = subRes != int.MaxValue ? Math.Min(res, subRes + 1) : res;
                }
            }
            return res;
        }
    }
}
