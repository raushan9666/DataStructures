using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class NthFromEnd   <T> where T :IComparable
         {

         public static T GetNthValue(baseList<T>a,int n)
        {
              node<T> slow = a.Head;
              node<T> fast = a.Head;
            if (n<1||a.count < n)
                return default(T);
            else
            {
               
                while(n>0)
                {
                    fast = fast.Next;
                    n--;
                }
                while(fast!=null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
            }

            return slow.data;

        }
    }
}
