using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SegregateTwoTypes
    {
        public static void SegregateNegativePositive(int[] arr)
        {
            Partition(arr, 0, arr.Length - 1, (x, pivot) =>
            {
                if ((pivot < 0 && x < 0) || (pivot > 0 && x > 0))
                    return true;
                else
                    return false;
            });
        }

        public static void SegregateEvenOdd(int[] arr)
        {
            Partition(arr, 0, arr.Length - 1, (x, pivot) =>
            {
                if ((pivot % 2 == 0 && x % 2 == 0) || (pivot % 2 != 0 && x % 2 != 0))
                    return true;
                else
                    return false;
            });
        }

        public static void SegregateBinaryArray(int[] arr)
        {
            Partition(arr, 0, arr.Length - 1, (x, pivot) =>
            {
                if ((pivot == 0 && x == 0) || (pivot == 1 && x == 1))
                    return true;
                else
                    return false;
            });
        }

        private static int Partition(int[] arr, int l, int h, Func<int, int, bool> condition)
        {
            int pivot = arr[h];
            int i = l - 1;
            for (int j = l; j < h; j++)
            {
                if (condition(arr[j], pivot))
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
}
