using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie
{
    public class AutoComplete
    {
        class TrieNode
        {
            public TrieNode[] child = new TrieNode[26];
            public bool isEnd;
        }
        public List<List<string>> Complete(string[] repo, string query)
        {
            int n = repo.Length;
            TrieNode root = new TrieNode();
            for (int i = 0; i < n; i++)
            {
                Insert(root, repo[i]);
            }
            List<List<string>> res = new List<List<string>>();
            for (int i = 2; i <= query.Length; i++)
            {
                res.Add(PrefixSearch(root, query.Substring(0, i)));
            }
            return res;
        }

        private List<string> PrefixSearch(TrieNode root, string v)
        {
            List<string> res = new List<string>();
            TrieNode cur = root;
            for (int i = 0; i < v.Length; i++)
            {
                int ind = v[i] - 'a';
                if (cur.child[ind] == null)
                    return res;
                cur = cur.child[ind];
            }
            FindMatchingWords(cur, res, v);
            return res;
        }

        private void FindMatchingWords(TrieNode cur, List<string> res, string v)
        {
            if (cur.isEnd == true)
            {
                res.Add(v);
            }
            for (int i = 0; i < 26; i++)
            {
                StringBuilder builder = new StringBuilder(v); 
                if (cur.child[i] != null)
                {
                    char c = Convert.ToChar('a' + i);
                    builder.Append(c);
                    FindMatchingWords(cur.child[i], res, builder.ToString());
                }
            }
        }

        private void Insert(TrieNode root, string v)
        {
            TrieNode cur = root;
            for (int i = 0; i < v.Length; i++)
            {
                int ind = v[i] - 'a';
                if (cur.child[ind] == null)
                {
                    cur.child[ind] = new TrieNode();
                }
                cur = cur.child[ind];
            }
            cur.isEnd = true;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] repo = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
    //        //string[] repo = { "bad", "bat", "box" };
    //        var res = new AutoComplete().Complete(repo, "mouse");
    //        res.ForEach(x =>
    //        {
    //            x.ForEach(y => Console.Write(y + " "));
    //            Console.WriteLine();
    //        });

    //    }
    //}
}
