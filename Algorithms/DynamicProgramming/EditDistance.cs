using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public class EditDistance
    {
        /// <summary>
        /// Minimum no of operations needed to convert string a into string b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="m">length of a</param>
        /// <param name="n">length of b</param>
        /// <returns></returns>
        public int MinimumChange(string a,string b,int m,int n)
        {
            if (m == 0)
                return n;
            if (n == 0)
                return m;
            if (a[m - 1] == b[n - 1])
                return MinimumChange(a, b, m - 1, n - 1);
            return 1 + Math.Min(Math.Min(MinimumChange(a, b, m, n - 1), MinimumChange(a, b, m - 1, n))
                                        , MinimumChange(a, b, m - 1, n - 1));
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new EditDistance();
    //        string a = "CUT", b = "CAT";
    //        Console.WriteLine(obj.MinimumChange(a, b, a.Length, b.Length));
    //    }
    //}
}
