using System;
using System.Collections.Generic;

namespace Algorithms.Stack
{
    public class NextGreaterElement
    {
        //Inp - { 5,15,10,8,6,12,9,18 }
        //Out - {15,18,12,12,12,18,18,-1}
        public void PrintNextGreaterElement(int[] arr)
        {
            int len = arr.Length;
            Stack<int> stack = new Stack<int>();
            if (len == 0)
                return;
            stack.Push(arr[len - 1]);
            int[] temp = new int[len];
            temp[len - 1] = -1;
            for (int i = len-2; i >= 0; i--)
            {
                while(stack.Count!=0 && stack.Peek()< arr[i])
                {
                    stack.Pop();
                }
                temp[i] = stack.Count != 0 ? stack.Peek() : -1;
                stack.Push(arr[i]);
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(temp[i]+" ");
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new NextGreaterElement();
    //        obj.PrintNextGreaterElement(new int[] { 5, 15, 10, 8, 6, 12, 9, 18 });
    //    }
    //}
}
