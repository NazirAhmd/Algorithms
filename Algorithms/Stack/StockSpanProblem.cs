using System;
using System.Collections.Generic;

namespace Algorithms.Stack
{
    public class StockSpanProblem
    {
        //Inp - {15,13,12,14,16,8,6,4,10,30}
        //Out - {1,1,1,3,5,1,1,1,4,10}
        public void DisplayStockSpan(int[] inp)
        {
            //Maintain recent greater element index in stack
            Stack<int> stack = new Stack<int>();
            int len = inp.Length;
            if (len == 0)
                return;
            Console.Write(1 + " ");
            stack.Push(0);
            for (int i = 1; i < len; i++)
            {
                while (stack.Count != 0 && inp[stack.Peek()] < inp[i])
                {
                    stack.Pop();
                }
                int span = stack.Count != 0 ? i - stack.Peek() : i + 1;
                Console.Write(span + " ");
                stack.Push(i);
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new StockSpanProblem();
    //        obj.DisplayStockSpan(new int[] { 15, 13, 12, 14, 16, 8, 6, 4, 10, 30 });
    //    }
    //}
}
