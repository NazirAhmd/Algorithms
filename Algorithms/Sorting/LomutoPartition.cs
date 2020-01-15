namespace Algorithms.Sorting
{
    public class LomutoPartition
    {
        public int Partition(int[] arr, int l, int h)
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

        private void Swap(int[] arr, int i, int j)
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
    //        var obj = new LomutoPartition();
    //        //var a = new int[] { 30, 20, 10, 5,15 };
    //        //var a = new int[] { 60, 70, 80, 40, 30 };
    //        var a = new int[] { 30, 40, 20, 50, 80 };
    //        obj.Partition(a, 0, a.Length - 1);
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            Console.Write(a[i] + " ");
    //        }
    //    }
    //}
}
