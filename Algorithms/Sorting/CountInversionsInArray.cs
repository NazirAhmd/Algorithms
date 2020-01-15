namespace Algorithms.Sorting
{
    public class CountInversionsInArray
    {
        public int CountInversions(int[] arr, int l, int h)
        {
            int cnt = 0;
            if (l < h)
            {
                int m = (l + h) / 2;
                cnt += CountInversions(arr, l, m);
                cnt += CountInversions(arr, m + 1, h);
                cnt += CountAndMerge(arr, l, m, h);
            }
            return cnt;
        }

        private int CountAndMerge(int[] arr, int l, int m, int h)
        {
            int n1 = m - l + 1, n2 = h - m;
            int[] lArr = new int[n1];
            int[] rArr = new int[n2];
            for (int i = 0; i < n1; i++)
            {
                lArr[i] = arr[l+i];
            }
            for (int i = 0; i < n2; i++)
            {
                rArr[i] = arr[m + 1 + i];
            }
            int low = 0, high = 0, ind = l;
            int cnt = 0;
            while (low < n1 && high < n2)
            {
                if (lArr[low] <= rArr[high])
                    arr[ind++] = lArr[low++];
                else
                {
                    arr[ind++] = rArr[high++];
                    cnt += n1 - low;
                }
            }
            while (low < n1)
                arr[ind++] = lArr[low++];
            while (high < n2)
                arr[ind++] = rArr[high++];
            return cnt;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new CountInversionsInArray();
    //        var a = new int[] { 2, 4, 1, 3, 5 };
    //        //var a = new int[] { 30,20,10,5};
    //        int res = obj.CountInversions(a, 0, a.Length - 1);
    //        Console.WriteLine(res);

    //    }
    //}
}
