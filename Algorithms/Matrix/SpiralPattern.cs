namespace Algorithms.Matrix
{
    public class SpiralPattern
    {
        public static void Print(int[,] matrix, int rows, int columns)
        {
            DisplayRecursive(matrix, rows, columns, 0, 0);
        }

        private static void DisplayRecursive(int[,] matrix, int rows, int columns, int stRow, int stColumn)
        {
            if (rows == 0 || columns == 0)
                return;
            BoundaryElements.Print(matrix, rows, columns, stRow, stColumn);
            DisplayRecursive(matrix, rows - 2, columns - 2, stRow + 1, stColumn + 1);
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] matrix ={{ 1,2,3,4 },
    //                        { 5,6,7,8 },
    //                        { 9,10,11,12 },
    //                        { 13,14,15,16 },
    //                        { 17,18,19,20} };
    //        SpiralPattern.Print(matrix, 5, 4);
    //    }
    //}
}
