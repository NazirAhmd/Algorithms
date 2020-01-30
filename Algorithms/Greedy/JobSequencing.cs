using System;
using System.Linq;

namespace Algorithms.Greedy
{
    public struct Job
    {
        public int Deadline { get; set; }
        public int Profit { get; set; }
    }
    public class JobSequencing
    {
        public int MaximizeProfit(Job[] jobs)
        {
            Array.Sort(jobs, (x, y) => y.Profit - x.Profit);
            int[] profits = new int[jobs.Max(x => x.Deadline)];
            for (int i = 0; i < jobs.Length; i++)
            {
                int ind = jobs[i].Deadline - 1;
                while (ind >=0)
                {
                    if(profits[ind] == 0)
                    {
                        profits[ind] = jobs[i].Profit;
                        break;
                    }
                    ind--;
                }
            }
            return profits.Sum();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Job[] arr = { new Job { Profit = 100, Deadline = 3 },
    //        new Job { Profit = 13, Deadline = 3 },
    //        new Job { Profit = 120, Deadline = 3 },
    //        new Job { Profit = 80, Deadline = 3 },
    //        new Job { Profit = 90, Deadline = 3 },
    //        new Job { Profit = 99, Deadline = 3 }};
    //        var obj = new JobSequencing();
    //        Console.WriteLine(obj.MaximizeProfit(arr));
    //    }
    //}
    //public static class Extension
    //{
    //    public static T Max<T>(this Array a, T[] arr, Comparison<T> comparison) where T : IComparable<T>
    //    {
    //        if (arr.Length == 0)
    //            throw new Exception("Array doesn't contain any element");
    //        T res = arr[0];
    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            if (comparison(arr[i], res) < 0)
    //                res = arr[i];
    //        }
    //        return res;
    //    }
    //}
}
