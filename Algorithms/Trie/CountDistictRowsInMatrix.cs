namespace Algorithms.Trie
{
    public class CountDistictRowsInMatrix
    {
        class TrieNode
        {
            public TrieNode[] child = new TrieNode[2];
        }
        int[,] matrix;
        int rows;
        int columns;
        public CountDistictRowsInMatrix(int[,] _matrix, int _rows, int _columns)
        {
            matrix = _matrix;
            rows = _rows;
            columns = _columns;
        }
        public int CountDistinct()
        {
            TrieNode root = new TrieNode();
            int cnt = 0;
            for (int i = 0; i < rows; i++)
            {
                if (IsNewRow(root, i))
                    cnt++;
            }
            return cnt;
        }

        private bool IsNewRow(TrieNode root, int row)
        {
            bool flag = false;
            for (int j = 0; j < columns; j++)
            {
                int index = matrix[row, j];
                if (root.child[index] == null)
                {
                    root.child[index] = new TrieNode();
                    flag = true;
                }
                root = root.child[index];
            }
            return flag;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] matrix ={{ 1,0,1,0 },
    //                        { 1,0,0,1 },
    //                        { 1,0,1,0 },
    //                        { 1,0,0,0 },
    //                        { 1,0,0,1 } };
    //        int res = new CountDistictRowsInMatrix(matrix, 5, 4).CountDistinct();
    //        Console.WriteLine(res);

    //    }
    //}
}
