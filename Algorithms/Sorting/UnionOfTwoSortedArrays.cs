using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class UnionOfTwoSortedArrays
    {
        public void Union(int[] a, int[] b)
        {
            int n1 = a.Length, n2 = b.Length;
            int l = 0, h = 0;
            while (l < n1 && h < n2)
            {
                int temp;
                if (l > 0 && a[l - 1] == a[l])
                {
                    l++;
                    continue;
                }
                if (h > 0 && b[h - 1] == b[h])
                {
                    h++;
                    continue;
                }
                if (a[l] == b[h])
                {
                    temp = a[l];
                    l++;
                    h++;
                }
                else if (a[l] < b[h])
                {
                    temp = a[l];
                    l++;
                }
                else
                {
                    temp = b[h];
                    h++;
                }
                Console.Write(temp + " ");
            }
            while (l < n1)
            {
                if (l == 0 || (l > 0 && a[l] != a[l - 1]))
                    Console.Write(a[l] + " ");
                l++;
            }
            while (h < n2)
            {
                if (h == 0 || (h > 0 && b[h] != b[h - 1]))
                    Console.Write(b[h] + " ");
                h++;
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new UnionOfTwoSortedArrays();
    //        var a = new int[] { 1, 2, 3, 4, 4, 4 };
    //        var b = new int[] { 3, 4, 4, 5, 6 };
    //        obj.Union(a, b);

    //    }
    //}
}
