using Algorithms.DynamicProgramming;
using Algorithms.Greedy;
using System;

namespace DriverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MaximumCuts();
            //int[] arr = { 3, 4, 2, 8, 10 };
            //int[] arr = { 4, 10, 6, 5, 8, 11, 2, 20 };
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(obj.CountTabulation(5, arr));
        }
    }
}
