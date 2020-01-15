namespace Algorithms.Tree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node()
        {

        }
        public Node(int d)
        {
            data = d;
        }
        public Node(int d, Node l, Node r)
        {
            data = d;
            left = l;
            right = r;
        }
    }

}
