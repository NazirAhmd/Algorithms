using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class CoinChange
    {
        public int CountWays(int[] coins, int sum)
        {
            if (sum == 0)
                return 1;
            int cnt = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                if (sum - coins[i] >= 0)
                {
                    cnt += CountWays(coins, sum - coins[i]);
                }
            }
            return cnt;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new CoinChange();
    //        int[] coins = { 1, 2, 3 };
    //        Console.WriteLine(obj.CountWays(coins, 4));
    //    }
    //}
}
