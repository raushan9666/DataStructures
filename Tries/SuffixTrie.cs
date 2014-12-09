using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class SuffixTrie
    {
        public Trie root;

        public SuffixTrie()
        {
            root = new Trie(10);
        }
        public void Add(string s)
        {
            foreach (var item in GetAllSuffix(s))
            {
                root.Add(item);
            }

        }
         public bool IsSubString(string s)
        {
            if (root.GetPrefixCount(s) != 0)
                return true;
            return false;
        }
        public bool IsSuffix(string s)
         {
             if (root.GetPrefixCount(s) == 1)
                 return true;
             return false;
         }
        public int Occurances(string s)
        {
            return root.GetPrefixCount(s);
        }
        public string LongestRepeat()
        {
            string s = string.Empty;
             longestRepeatHelper(root.root, string.Empty,0,int.MinValue,ref s);
             return s;

        }
        void longestRepeatHelper(TrieNode t1,string prefix,int length,int maxlength,ref string res)
        {
            if (t1.children == null)
                return ;
            foreach (var t in t1.children.Values)
            {
                string tmp = prefix + t.NodeKey;
                  if(t.NoofPrefix>=2)
                  {
                      if (length > maxlength)
                      {
                          maxlength = length;
                          res = tmp;
                        longestRepeatHelper(t,tmp,length + 1,maxlength,ref res);
                      }
                  }
             
            }
            
        }


       IEnumerable<string> GetAllSuffix(string s)
         {
             string res = String.Empty;
            for(int i=0;i<s.Length;i++)
            {
                 res=s.Substring(i);
                 yield return res;
            }
         }
    }
}
