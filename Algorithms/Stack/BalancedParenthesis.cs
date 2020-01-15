using System.Collections.Generic;

namespace Algorithms.Stack
{
    public class BalancedParenthesis
    {
        //Inp - "({}{}[])" 
        //Out - True
        public bool IsBalanced(string inp)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in inp)
            {
                if(item=='(' || item == '{' || item =='[')
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    if (!IsMatching(stack.Peek(),item))
                        return false;
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
                return true;
            return false;
        }

        private bool IsMatching(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '{' && b == '}') || (a == '[' && b == ']');
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string inp = Console.ReadLine();
    //        BalancedParenthesis bp = new BalancedParenthesis();
    //        Console.WriteLine(bp.IsBalanced(inp));
    //    }
    //}
}
