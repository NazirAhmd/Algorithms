using System;
 
namespace Algorithms.Sorting
{
    public class IntersectionOfTwoSortedArray
    {
        public void FindIntersection(int[] a, int[] b)
        {
            int n1 = a.Length, n2 = b.Length;
            int l = 0, h = 0;
            while (l < n1 && h < n2)
            {
                if (l > 0 && a[l - 1] == a[l])
                {
                    l++;
                    continue;
                }
                if (a[l] == b[h])
                {
                    Console.Write(a[l] + " ");
                    l++;
                    h++;
                }
                else if (a[l] < b[h])
                    l++;
                else
                    h++;
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new IntersectionOfTwoSortedArray();
    //        var a = new int[] { 1, 2, 3, 4, 4, 4 };
    //        var b = new int[] { 3, 4, 4, 5, 6 };
    //        obj.FindIntersection(a, b);

    //    }
    //}
}
