using System.Collections.Generic;

namespace Algorithms.Hashing
{
    public class DistinctElements
    {
        public int Count(int[] arr)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                hash.Add(arr[i]);
            }
            return hash.Count;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    //        var res = new DistinctElements().Count(arr);
    //        Console.WriteLine(res);
    //    }
    //}
}
