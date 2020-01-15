using System;

namespace Algorithms.Arrays
{
    public class LeaderInAnArray
    {
        public void LeaderEfficient(int[] arr)
        {
            int n = arr.Length;
            int leader = arr[n - 1];
            Console.Write(leader + " ");
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > leader)
                {
                    leader = arr[i];
                    Console.Write(leader + " ");
                }
            }
        }
        public void LeaderNaive(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                bool isLeader = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] >= arr[i])
                    {
                        isLeader = false;
                        break;
                    }
                }
                if (isLeader)
                    Console.Write(arr[i] + " ");
            }
        }

        public int LeaderRecursive(int[] arr, int ind = 0)
        {
            if (ind == arr.Length)
                return int.MinValue;
            int led = LeaderRecursive(arr, ind + 1);
            if (arr[ind] > led)
            {
                Console.Write(arr[ind] + " ");
                return arr[ind];
            }
            return led;
        }
    }
}
