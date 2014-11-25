using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    /// <summary>
    /// Given a linked list, reverse alternate nodes and append at the end
    /// Input List:  1->2->3->4->5->6
       /// Output List: 1->3->5->6->4->2
    /// </summary>
    public static class revAlternateAddEnd<T>where T:IComparable
    {
         public static baseList<T>  reverse(baseList<T> a)
        {
            baseList<T> op = new baseList<T>();
            op.Head = revhelper(a.Head);
            return op;

        }
         private static node<T> revhelper(node<T> ip)
        {
            if (ip == null || ip.Next == null || ip.Next.Next == null)
                return null;
            node<T> odd = ip;
            node<T> even = odd.Next;
            odd.Next = odd.Next.Next;
            odd = odd.Next;
            even.Next = null;
          
            while(odd!=null&&odd.Next!=null)
            {
                node<T> temp = odd.Next.Next;
                odd.Next.Next = even;
                even = odd.Next;
                odd.Next = temp;
                if (temp != null)
                    odd = temp;
            }

            odd.Next = even;
            return ip;
          }
    }
}
