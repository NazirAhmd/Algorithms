using System;

namespace Algorithms.Matrix
{
    public class BoundaryElements
    {
        public static void Print(int[,] matrix, int rows, int columns, int stR = 0, int stC = 0)
        {
            for (int i = stR; i < stC + columns; i++)
            {
                Console.Write(matrix[stR, i] + " ");
            }
            for (int i = stR + 1; i < stR + rows - 1; i++)
            {
                Console.Write(matrix[i, stC + columns - 1] + " ");
            }
            for (int i = stC + columns - 1; i >= stC; i--)
            {
                Console.Write(matrix[stR + rows - 1, i] + " ");
            }
            for (int i = stR + rows - 2; i >= stR + 1; i--)
            {
                Console.Write(matrix[i, stC] + " ");
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
    //        BoundaryElements.Print(matrix, 4, 4);
    //    }
    //}
}
