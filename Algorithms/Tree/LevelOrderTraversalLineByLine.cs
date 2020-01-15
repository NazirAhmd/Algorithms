using System;
using System.Collections.Generic;

namespace Algorithms.Tree
{
    public class LevelOrderTraversalLineByLine
    {
        public void LevelOrderByLine(Node root)
        {
            if (root == null)
                return;
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);
            nodes.Enqueue(null);
            while (nodes.Count > 1)
            {
                Node currNode = nodes.Dequeue();

                if (currNode == null)
                {
                    nodes.Enqueue(null);
                    Console.WriteLine();
                    continue;
                }

                Console.Write(currNode.data + " ");

                if (currNode.left != null)
                    nodes.Enqueue(currNode.left);

                if (currNode.right != null)
                    nodes.Enqueue(currNode.right);
            }
        }

        public void LevelOrderByLineUsingCount(Node root)
        {
            if (root == null)
                return;
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                int count = nodes.Count;
                for (int i = 0; i < count; i++)
                {
                    Node currNode = nodes.Dequeue();
                    Console.Write(currNode.data + " ");

                    if (currNode.left != null)
                        nodes.Enqueue(currNode.left);

                    if (currNode.right != null)
                        nodes.Enqueue(currNode.right); 
                }
                Console.WriteLine();
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new LevelOrderTraversalLineByLine();
    //        var root = new Node(1);
    //        root.left = new Node(2);
    //        root.right = new Node(3);
    //        obj.LevelOrderByLine(root);
    //    }
    //}
}
