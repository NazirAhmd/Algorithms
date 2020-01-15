namespace Algorithms.Matrix
{
    public class RotateMatrixCounterClockwise90
    {
        public void Rotate(int[,] matrix,int rows, int columns)
        {
            new TransposeMatrix().Transpose(matrix, rows, columns);
            int l = 0, h = rows - 1;
            while(l<h)
            {
                for (int j = 0; j < columns; j++)
                {
                    int temp = matrix[l, j];
                    matrix[l, j] = matrix[h, j];
                    matrix[h, j] = temp;
                }
                l++;
                h--;
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] matrix ={{ 1,2,3,4 },
    //                        { 5,6,7,8 },
    //                        { 9,10,11,12 },
    //                        { 13,14,15,16 }};
    //        new RotateMatrixCounterClockwise90().Rotate(matrix, 4, 4);
    //        for (int i = 0; i < 4; i++)
    //        {
    //            for (int j = 0; j < 4; j++)
    //            {
    //                Console.Write(matrix[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}
}
