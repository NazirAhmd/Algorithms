using Algorithms.Matrix;
using System;

namespace DriverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix ={{ 1,2,3,4 },
                            { 5,6,7,8 },
                            { 9,10,11,12 },
                            { 13,14,15,16 },
                            { 17,18,19,20} };
            SpiralPattern.Print(matrix, 5, 4);
        }
    }
}
