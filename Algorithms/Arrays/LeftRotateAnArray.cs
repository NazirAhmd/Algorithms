namespace Algorithms.Arrays
{
    public class LeftRotateAnArray
    {
        public void RotateByOne(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;
        }

        public void RotateByD(int[] arr, int d)
        {
            int[] temp = new int[d];
            for (int i = 0; i < d; i++)
            {
                temp[i] = arr[i];
            }
            for (int i = d; i < arr.Length; i++)
            {
                arr[i - d] = arr[i];
            }
            for (int i = 0; i < d; i++)
            {
                arr[d + 1 + i] = temp[i];
            }

        }
    }
}
