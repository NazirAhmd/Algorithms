using System;

namespace Algorithms.Greedy
{
    public class MinimumNoOfCoins
    {
        public int Count(int[] arr, int amt)
        {
            int cnt = 0;
            Array.Sort(arr, (x, y) => y - x);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= amt)
                {
                    int coins = amt / arr[i];
                    cnt += coins;
                    amt = amt - (coins * arr[i]);
                }
                if (amt == 0)
                    break;
            }
            if (amt == 0)
                return cnt;
            return -1;
        }
    }
}
