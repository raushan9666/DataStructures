using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class PairWiseSwap<T> where T:IComparable
    {
        public static baseList<T> reverse(baseList<T> a)
        {
            baseList<T> res = new baseList<T>();
            res.Head = reversehelper(a.Head);
            return res;
        }
        private static node<T> reversehelper( node<T> a)
        {
            if (a == null)
                return null;
            if(a.Next==null)
            { return a; }
            node<T> next = a.Next;
            a.Next = reversehelper(next.Next);
            next.Next = a;
            return next;

        }

    }
}
