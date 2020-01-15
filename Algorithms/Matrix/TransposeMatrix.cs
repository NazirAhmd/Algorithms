using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Matrix
{
    public class TransposeMatrix
    {
        public void Transpose(int[,] matrix, int rows, int columns)
        {
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }
    }
}
