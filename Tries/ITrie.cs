using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public interface ITrie
    {
        void Add(string s);
        List<string> SearchPrefix(string s,int top);

        int GetPrefixCount(string s);
        bool Contains(string s);
    }
}
