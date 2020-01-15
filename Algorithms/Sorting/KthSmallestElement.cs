using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class KthSmallestElement
    {
        public static int KthSmallest(int[] arr, int l, int h, int k)
        {
            if (l > h)
                return -1;
            int p = LomutoPartition(arr, l, h);
            if (p + 1 == k)
                return arr[p];
            if (p + 1 < k)
                return KthSmallest(arr, p + 1, h, k);
            else
                return KthSmallest(arr, l, p - 1, k);
        }

        public static int KthSmallestIterative(int[] arr, int n, int k)
        {
            int l = 0, h = n - 1;
            while (l <= h)
            {
                int p = LomutoPartition(arr, l, h);
                if (p + 1 == k)
                    return arr[p];
                if (p + 1 < k)
                    l = p + 1;
                else
                    h = p - 1;
            }
            return -1;
        }

        private static int LomutoPartition(int[] arr, int l, int h)
        {
            int pivot = arr[h];
            int i = l - 1;
            for (int j = l; j < h; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, h);
            return i + 1;
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var a = new int[] { 14, 8, 1, 20, 2, 55, 10, 5, 7, 15 };
    //        //var a = new int[] { 60, 70, 80, 90, 100 };
    //        //var a = new int[] { 12, 10, 5, 9 };
    //        //var a = new int[] { 30, 40, 20, 50, 80 };
    //        //var a = new int[] { 5, 3, 8, 4, 2, 7, 1, 10 };
    //        var res = KthSmallestElement.KthSmallestIterative(a, a.Length, 4);
    //        Console.WriteLine(res);
    //    }
    //}
}
