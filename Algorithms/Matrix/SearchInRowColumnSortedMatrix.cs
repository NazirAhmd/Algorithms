namespace Algorithms.Matrix
{
    public class SearchInRowColumnSortedMatrix
    {
        public bool Search(int[,] matrix, int rows, int columns, int n)
        {
            int i = 0, j = columns - 1;
            while (i < rows && j < columns)
            {
                if (matrix[i, j] == n)
                    return true;
                if (matrix[i, j] > n)
                    j--;
                else
                    i++;
            }
            return false;
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
    //        var res = new SearchInRowColumnSortedMatrix().Search(matrix, 4, 4, 18);
    //        Console.WriteLine(res);
    //    }
    //}
}
