using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree
{
    public class HeightOfBinaryTree
    {
        //Time - O(n)
        //AS - O(h) where h=height of binary tree
        //Recursive approach
        public int Height(Node root)
        {
            if (root == null)
                return 0;
            return 1 + Math.Max(Height(root.left), Height(root.right));
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new HeightOfBinaryTree();
    //        var root = new Node(1);
    //        root.left = new Node(2);
    //        root.right = new Node(3);
    //        root.left.left = new Node(4);
    //        root.left.right = new Node(5);
    //        Console.WriteLine(obj.Height(root));
    //    }
    //}
}
