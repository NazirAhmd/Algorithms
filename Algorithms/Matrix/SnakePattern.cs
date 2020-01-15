using System;

namespace Algorithms.Matrix
{
    public class SnakePattern
    {
        public void Print(int[,] matrix,int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                if(i%2==0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i,j]+" ");
                    }
                }
                else
                {
                    for (int j = columns-1; j >=0; j--)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
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
    //                        { 13,14,15,16 },
    //                        { 17,18,19,20 } };
    //        new SnakePattern().Print(matrix, 5, 4);
    //    }
    //}
}
