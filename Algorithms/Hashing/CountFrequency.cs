using System.Collections.Generic;
 
namespace Algorithms.Hashing
{
    public class CountFrequency
    {
        public Dictionary<int,int> Count(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 0);
                }
                dict[arr[i]] += 1;
            }
            return dict;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 3, 2, 3, 3, 2, 54, 3, 2, 3, 2, 3, 45, 3, 3, 2, 3, 4, 3, 3 };
    //        var res = new CountFrequency().Count(arr);
    //        foreach (var item in res.Keys)
    //        {
    //            Console.WriteLine("{0} - {1}", item, res[item]);
    //        }
    //    }
    //}
}
