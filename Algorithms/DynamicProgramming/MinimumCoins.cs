using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class MinimumCoins
    {
        public int CountRecursive(int[] coins, int v)
        {
            if (v == 0)
                return 0;
            int minCoins = int.MaxValue;
            for (int i = 0; i < coins.Length; i++)
            {
                if (v >= coins[i])
                {
                    int subRes = CountRecursive(coins, v - coins[i]);
                    if (subRes != minCoins)
                        minCoins = Math.Min(minCoins, subRes + 1);
                }
            }
            return minCoins;
        }

        public int CountTabulation(int[] coins, int v)
        {
            int[] dp = new int[v + 1];
            dp[0] = 0;
            for (int i = 1; i <= v; i++)
            {
                dp[i] = int.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i >= coins[j])
                    {
                        int subRes = dp[i - coins[j]];
                        if (subRes != int.MaxValue)
                            dp[i] = Math.Min(dp[i], subRes + 1);
                    }

                }
            }
            return dp[v];
        }
    }
}
