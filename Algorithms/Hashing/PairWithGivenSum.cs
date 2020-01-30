using System.Collections.Generic;

namespace Algorithms.Hashing
{
    public class PairWithGivenSum
    {
        public bool HasPair(int[] arr,int sum)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.Contains(sum - arr[i]))
                    return true;
                else
                    hash.Add(arr[i]);
            }
            return false;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 3, 2, 3, 3, 2, 54, 3, 2, 3, 2, 3, 45, 3, 3, 2, 3, 4, 3, 3 };
    //        var res = new PairWithGivenSum().HasPair(a, 99);
    //        Console.WriteLine(res);
    //    }
    //}
}
