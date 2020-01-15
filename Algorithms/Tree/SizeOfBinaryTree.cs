using System;
using System.Collections.Generic;

namespace Algorithms.Tree
{
    public class SizeOfBinaryTree
    {
        //Time - O(n)
        //AS - O(h) where h=height of binary tree
        //Recursive approach
        public int Size(Node root)
        {
            if (root == null)
                return 0;
            return 1 + Size(root.left) + Size(root.right);
        }
        //Time - O(n)
        //AS - O(w) where w=width of binary tree
        //Iterative approach
        public int SizeIterative(Node root)
        {
            if (root == null)
                return 0;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int count = 0;
            while(queue.Count>0)
            {
                Node cur = queue.Dequeue();
                count++;
                if (cur.left != null)
                    queue.Enqueue(cur.left);
                if (cur.right != null)
                    queue.Enqueue(cur.right);
            }
            return count;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new SizeOfBinaryTree();
    //        var root = new Node(1);
    //        root.left = new Node(2);
    //        root.right = new Node(3);
    //        root.left.left = new Node(4);
    //        root.left.right = new Node(5);
    //        Console.WriteLine(obj.SizeIterative(root));
    //    }
    //}
}
