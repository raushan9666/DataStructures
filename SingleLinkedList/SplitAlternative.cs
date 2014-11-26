using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    /// <summary>
    /// Alternating split of a given Singly Linked List
    /// original list is 0->1->0->1->0->1 then one sublist should be 0->0->0 and the other should be 1->1->1.
    /// </summary>
    public static class SplitAlternative<T> where T:IComparable
    {
        public static baseList<T> split(baseList<T> ip)
        {
            baseList<T> res = new baseList<T>();

            node<T> temp = ip.Head;
            if (ip.Head == null || ip.Head.Next == null)
                return null;
            node<T> b = temp.Next;
            res.Head = b;
          
            while(temp!=null&&b!=null)
            {
                temp.Next = b.Next;
                temp = temp.Next;
                if (temp == null)
                    break;
                b.Next = new node<T>();
                b.Next = temp.Next;
                b = b.Next;
                   
            }
            return res;
        }
    }
}
