using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree
{
    public class PrintNodesAtDistance
    {
        //Time - O(n)
        //AS - O(h) where h=height of binary tree
        //Recursive approach
        public void PrintNodesAtDistanceK(Node root, int k)
        {
            if (root == null)
                return;
            if (k == 0)
            {
                Console.Write(root.data + " ");
                return;
            }
            PrintNodesAtDistanceK(root.left, k - 1);
            PrintNodesAtDistanceK(root.right, k - 1);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new PrintNodesAtDistance();
    //        var root = new Node(1);
    //        root.left = new Node(2);
    //        root.right = new Node(3);
    //        root.left.left = new Node(4);
    //        root.left.right = new Node(5);
    //        obj.PrintNodesAtDistanceK(root, 1);
    //    }
    //}
}
