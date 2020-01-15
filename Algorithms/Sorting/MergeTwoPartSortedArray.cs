namespace Algorithms.Sorting
{
    public class MergeTwoPartSortedArray
    {
        //Time - O(n1+n2)+O(n1+n2) = O(n) approx
        //AS - O(n)
        /// <summary>
        /// Merge the two sorted part of array into fully sorted array
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="l">lower index</param>
        /// <param name="m">middle index</param>
        /// <param name="h">upper index</param>
        public void Merge(int[] arr, int l, int m, int h)
        {
            int lftLen = m + 1, rgtLen = h - m;
            int[] lArr = new int[lftLen];
            int[] rArr = new int[rgtLen];
            for (int i = 0; i < lftLen; i++)
            {
                lArr[i] = arr[l+i];
                lArr[i] = arr[l+i];
            }
            for (int i = 0; i < rgtLen; i++)
            {
                rArr[i] = arr[m + 1 + i];
            }
            int low = 0, high = 0, ind = l;
            while (low < lftLen && high < rgtLen)
            {
                if (lArr[low] <= rArr[high])
                {
                    arr[ind++] = lArr[low++];
                }
                else
                {
                    arr[ind++] = rArr[high++];
                }
            }
            while (low < lftLen)
                arr[ind++] = lArr[low++];
            while (high < rgtLen)
                arr[ind++] = rArr[high++];
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new MergeTwoPartSortedArray();
    //        var arr = new int[] { 10, 15, 20, 40, 8, 11, 15, 22, 25 };
    //        obj.Merge(arr, 0, 3, 8);
    //        foreach (var item in arr)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();

    //    }
    //}

}
