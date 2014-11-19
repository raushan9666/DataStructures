using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public static class GetStack
    {
        static Random r = new Random();
        public static BaseStack<int>   IntStack(int count)
        {
            BaseStack<int> bstack= new BaseStack<int>();
            for(int i=0;i<count;i++)
            {
                bstack.push(r.Next());
            }
            return bstack;
        }
    }
}
