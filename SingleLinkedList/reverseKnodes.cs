using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class reverseKnodes<T> where T :IComparable
    {
        
        public  static baseList<T> reverseKNodes(baseList<T> a,int k)
        {
            baseList<T> res = new baseList<T>();
            res.Head = reverhelper(a.Head, k);
            return res;
        }

        private  static node<T> reverhelper (node<T> a,int k)
        {
            node<T> prev = null;
            node<T> curr = a;
            node<T> next = null;
            int count = 0;
            while(curr!=null&&count <k)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
                count++;
               
            }
            if(curr!=null)
            {
                a.Next = reverhelper(curr, k);
            }
            return prev;
        }
    }
}
