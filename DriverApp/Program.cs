using Algorithms.DynamicProgramming;
using Algorithms.Greedy;
using System;

namespace DriverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new KnapsackProblem();
            int[] w = { 5, 4, 6, 3 };
            int[] v = { 10, 40, 30, 50 };
            Console.WriteLine(obj.KnapSackRecursive(10, w, v, w.Length));
        }
    }
}
