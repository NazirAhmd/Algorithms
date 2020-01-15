using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Queue
{
    public class ReverseQueue
    {
        public void ReverseIterative(Queue<int> qu)
        {
            Stack<int> stack = new Stack<int>();
            while(qu.Count!=0)
            {
                stack.Push(qu.Dequeue());
            }
            while(stack.Count!=0)
            {
                qu.Enqueue(stack.Pop());
            }
        }

        public void ReverseRecursive(Queue<int> qu)
        {
            if (qu.Count == 0)
                return;
            int val = qu.Dequeue();
            ReverseRecursive(qu);
            qu.Enqueue(val);
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new ReverseQueue();
    //        var qu = new Queue<int>();
    //        qu.Enqueue(10);
    //        qu.Enqueue(15);
    //        qu.Enqueue(20);
    //        qu.Enqueue(30);
    //        obj.ReverseRecursive(qu);
    //        while (qu.Count != 0)
    //        {
    //            Console.Write(qu.Dequeue() + " ");
    //        }
    //    }
    //}
}
