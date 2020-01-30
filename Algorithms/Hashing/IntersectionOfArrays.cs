using System.Collections.Generic;

namespace Algorithms.Hashing
{
    public class IntersectionOfArrays
    {
        public int Count(int[] a, int[] b)
        {
            HashSet<int> hash = new HashSet<int>();
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                hash.Add(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                if(hash.Contains(b[i]))
                {
                    cnt++;
                    hash.Remove(b[i]);
                }
            }
            return cnt;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] a = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 3, 2, 3, 3, 2, 54, 3, 2, 3, 2, 3, 45, 3, 3, 2, 3, 4, 3, 3 };
    //        int[] b = { 2, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2 };
    //        var res = new IntersectionOfArrays().Count(a, b);
    //        Console.WriteLine(res);
    //    }
    //}
}
