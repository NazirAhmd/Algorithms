namespace Algorithms.Common
{
    public static class Utils
    {
        /// <summary>
        /// Swap the elements in an array
        /// </summary>
        /// <param name="arr">Input Array</param>
        /// <param name="a">First index</param>
        /// <param name="b">Second index</param>
        public static void Swap(int[] arr,int a,int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
