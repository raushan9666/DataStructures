using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public static class GetLinkedList
    {
        static Random r1 = new Random();
        public static baseList<int> IntSingleList(int rcount)
        {

            baseList<int> obj = new baseList<int>();
            for (int i = 0; i < rcount; i++)
            {
                obj.Add(r1.Next());
            }
            return obj;
        }
      
    }
}
