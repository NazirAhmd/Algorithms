namespace Algorithms.DynamicProgramming
{
    public class CoinChange
    {
        public int CountWaysRecursive(int[] coins, int n, int sum)
        {
            if (sum == 0)
                return 1;
            if (n == 0)
                return 0;
            int res = CountWaysRecursive(coins, n - 1, sum);
            if (sum - coins[n - 1] >= 0)
                res += CountWaysRecursive(coins, n, sum - coins[n - 1]);
            return res;
        }


        //dp[i,j] = the no. of combinations we can get with sum i and coins from 1 to j
        public int CountWaysDp(int[] c, int n, int sum)
        {
            int[,] dp = new int[sum + 1, n + 1];
            for (int j = 0; j < n + 1; j++)
            {
                dp[0, j] = 1;
            }
            for (int i = 1; i < sum + 1; i++)
            {
                dp[i, 0] = 0;
            }
            for (int i = 1; i < sum + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    dp[i, j] = dp[i, j - 1];
                    if (i >= c[j - 1])
                        dp[i, j] += dp[i - c[j - 1], j];
                }
            }
            return dp[sum, n];
        }
    }
}
