using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class Trie  :ITrie
    {
        int maxcount = 100;

        public TrieNode root;

        public Trie(int max)
        {
            root = new TrieNode(){NodeKey=' '};
            max = maxcount;

        }


        public void Add(string s)
        {
            TrieNode curr = root;
            TrieNode tmp = null;
            foreach (char item in s)
            {
                  if(curr.children==null)
                  {
                      curr.children = new Dictionary<int, TrieNode>();
                  }
                if(!curr.children.Keys.Contains(item))
                {
                    tmp = new TrieNode() { NodeKey = item };
                    curr.children.Add(item, tmp);
                }
              
                curr = curr.children[item];
                curr.NoofPrefix += 1;
               
            }
            curr.IsWord = true;

        }

        public List<string> SearchPrefix(string s,int top=-1)
        {
            List<string> result = new List<string>();
            bool flag = true;
            TrieNode curr = root;
            string prefix = String.Empty;
            foreach (var item in s)
            {
                 if(curr.children==null)
                 {
                     flag = false;
                     break;
                 }
                if(curr.children.ContainsKey(item))
                {
                    prefix += item;
                    curr = curr.children[item];
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            top=top==-1?maxcount:top;

            if (curr.IsWord && !flag && result.Count < top)
                result.Add(prefix);

            GetMoreWords(curr, result, prefix, top);
            return result;



        }

        private void GetMoreWords(TrieNode curr,List<string> result,string prefix,int count)
        {
            if(curr.children==null)
                return;
            foreach (TrieNode item in curr.children.Values)
	        {
		          string tmp =prefix+item.NodeKey;
                if(item.IsWord)
                {
                    if(result.Count>=count)
                        break;
                    else
                    {
                         result.Add(tmp);
                    }
                }
                GetMoreWords(item,result,tmp,count);
	        }
        }

        public int GetPrefixCount(string s)
        {
            TrieNode curr = root;
            foreach (var item in s)
            {
                if (curr.children.Keys.Contains(item))
                {
                    curr = curr.children[item];
                }
                else
                    return 0;
            }
            return curr.NoofPrefix;
        }


        public bool Contains(string s)
        {
            bool contains = true;
            TrieNode curr = root;
            foreach (var item in s)
            {
                   if(curr.children.ContainsKey(item))
                   {
                       curr = curr.children[item];
                   }
                   else
                   {
                       contains = false;
                       break;
                   }
            }
            return contains;
        }
    }
}
