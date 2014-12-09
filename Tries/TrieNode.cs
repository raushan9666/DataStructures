using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class TrieNode   
    {
        public char NodeKey;
        public bool IsWord;
        public int NoofPrefix;
        public Dictionary<int, TrieNode> children;
    }
}
