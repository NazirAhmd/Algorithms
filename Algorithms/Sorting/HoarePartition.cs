namespace Algorithms.Sorting
{
    public class HoarePartition
    {
        public int Partition(int[] arr, int l, int h)
        {
            int i = l - 1;
            int j = h + 1;
            int pivot = arr[l];
            while (true)
            {
                do
                {
                    i++;
                }
                while (arr[i] < pivot);

                do
                {
                    j--;
                }
                while (arr[j] > pivot);
                if (i >= j)
                    return j;

                Swap(arr, i, j);
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
