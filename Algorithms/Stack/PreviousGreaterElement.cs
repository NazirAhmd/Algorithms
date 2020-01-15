using System;
using System.Collections.Generic;

namespace Algorithms.Stack
{
    public class PreviousGreaterElement
    {
        //Inp - {15,10,18,12,4,6,2,8}
        //Out - {-1,15,-1,18,12,12,6,12}
        public void PreviousGreaterItem(int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            int len = arr.Length;
            if (len == 0)
                return;
            Console.Write(-1+" ");
            stack.Push(arr[0]);
            for (int i = 1; i < len; i++)
            {
                while(stack.Count!=0 && stack.Peek()<arr[i])
                {
                    stack.Pop();
                }
                int greaterItem = stack.Count != 0 ? stack.Peek() : -1;
                Console.Write(greaterItem + " ");
                stack.Push(arr[i]);
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new PreviousGreaterElement();
    //        obj.PreviousGreaterItem(new int[] { 15, 10, 18, 12, 4, 6, 2, 8 });
    //    }
    //}
}
