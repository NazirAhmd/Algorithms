using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree
{
    public class PrintLeftViewOfBinaryTree
    {
        //Time - O(n)
        //AS - O(h) where h=height of binary tree
        //Recursive approach
        public void PrintLeftView(Node root, int level,ref int maxLevel)
        {
            if (root == null)
                return;
            if (level > maxLevel)
            {
                Console.Write(root.data + " ");
                maxLevel = level;
            }
            PrintLeftView(root.left, level + 1,ref maxLevel);
            PrintLeftView(root.right, level + 1,ref maxLevel);
        }
        //Time - O(n)
        //AS - O(w) where w=width of binary tree
        //Iterative approach
        public void PrintLeftViewIterative(Node root)
        {
            if (root == null)
                return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                int cnt = queue.Count;
                for (int i = 0; i < cnt; i++)
                {
                    Node currNode = queue.Dequeue();
                    if (i == 0)
                    {
                        Console.Write(currNode.data + " ");
                    }
                    if (currNode.left != null)
                        queue.Enqueue(currNode.left);

                    if (currNode.right != null)
                        queue.Enqueue(currNode.right);
                }
            }
        }

    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new PrintLeftViewOfBinaryTree();
    //        var root = new Node(1);
    //        root.left = new Node(2);
    //        root.right = new Node(3);
    //        root.right.left = new Node(6);
    //        root.left.left = new Node(4);
    //        root.left.right = new Node(5);
    //        int maxL = 0;
    //        obj.PrintLeftView(root, 1, ref maxL);
    //        Console.WriteLine();
    //        obj.PrintLeftViewIterative(root);
    //    }
    //}
}
