namespace Algorithms.Tree
{
    public class ChildrenSumProperty
    {
        //Time - O(n)
        //AS - O(h) where h=height of binary tree
        //Recursive approach
        public bool IsChildrenSum(Node root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;
            int sum = 0;
            if (root.left != null)
                sum += root.left.data;
            if (root.right != null)
                sum += root.right.data;
            if (root.data == sum)
                return IsChildrenSum(root.left) && IsChildrenSum(root.right);
            else
                return false;
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new ChildrenSumProperty();
    //        var root = new Node(5);
    //        root.left = new Node(2);
    //        root.right = new Node(3);
    //        root.right.left = new Node(3);
    //        root.left.left = new Node(2);
    //        root.left.right = new Node(1);
    //        Console.WriteLine(obj.IsChildrenSum(root));
    //    }
    //}
}
