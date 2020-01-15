using System;
using System.Collections.Generic;

namespace Algorithms.Tree
{
    public class MaximumValueInBinaryTree
    {
        //Time - O(n)
        //As - O(h)
        public int MaximumValue(Node root)
        {
            if (root == null)
                return int.MinValue;
            return Math.Max(root.data,
                            Math.Max(MaximumValue(root.left), MaximumValue(root.right)));
        }
        //Iterative approach using Level order traversal
        //Time - O(n)
        //As - O(w)
        //If tree is skewed then this will perform better in terms of As
        public int MaximumValueIterative(Node root)
        {
            int res = int.MinValue;
            if (root == null)
                return res;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node cur = queue.Dequeue();
                res = Math.Max(res, cur.data);

                if (cur.left != null)
                    queue.Enqueue(cur.left);
                if (cur.right != null)
                    queue.Enqueue(cur.right);
            }
            return res;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new MaximumValueInBinaryTree();
    //        var root = new Node(10000);
    //        root.left = new Node(2);
    //        root.right = new Node(30);
    //        root.left.left = new Node(4000);
    //        root.left.right = new Node(5);
    //        Console.WriteLine(obj.MaximumValueIterative(root));
    //    }
    //}
}
