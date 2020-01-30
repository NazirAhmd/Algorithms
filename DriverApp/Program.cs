using Algorithms.DynamicProgramming;
using Algorithms.Greedy;
using System;

namespace DriverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new LongestCommonSubsequence();
            string a = "XYZ", b = "XASSDZ";
            Console.WriteLine(obj.Memoization(a, b, a.Length, b.Length));
        }
    }
}
