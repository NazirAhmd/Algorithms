using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Queue
{
    public class GenerateNumbersWithGivenDigits
    {
        public void GenerateNumbers(int[] arr, int genNumbersCount)
        {
            Queue<string> qu = new Queue<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                qu.Enqueue(arr[i].ToString());
            }

            for (int count = 0; count < genNumbersCount; count++)
            {
                string num = qu.Dequeue();
                Console.Write(num + " ");
                for (int i = 0; i < arr.Length; i++)
                {
                    qu.Enqueue(num + arr[i].ToString());
                }
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new GenerateNumbersWithGivenDigits();
    //        obj.GenerateNumbers(new int[] { 5, 6, 7 }, 10);
    //    }
    //}
}
