using Algorithms.Common;

namespace Algorithms.Arrays
{
    public class ReverseAnArray
    {
        public void Reverse(int[] arr)
        {
            int st = 0;
            int en = arr.Length - 1;
            while (st < en)
            {
                Utils.Swap(arr, st, en);
                st++;
                en--;
            }
        }
    }
}
