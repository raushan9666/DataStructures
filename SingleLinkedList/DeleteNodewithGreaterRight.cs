using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    /// <summary>
    /// Delete nodes which have a greater value on right side
    /// The list 12->15->10->11->5->6->2->3->NULL should be changed to 15->11->6->3->NULL
    /// </summary>
    public static class DeleteNodewithGreaterRight<T> where T:IComparable
    {

        public static baseList<T> delete(baseList<T> a)
        {
            baseList<T> res = new baseList<T>();
            node<T> big =deleteHelper(a.Head,null);
            if(a.Head.CompareTo(big)<0)
            {
                a.Head = big;
            }
            res.Head = a.Head;
            return res;
        }

        public static node<T> deleteHelper(node<T> a,node<T> prev)
        {
            node<T> big = null;
            if (a == null||a.Next==null)
                return a ;
            node<T> curr = a.Next;
            prev = a;
            big =deleteHelper(curr, prev);
            if (big == null)
            {
                big = curr;
            }
            else if(curr.CompareTo(big)>=0)
            {
                big = curr;
            }
            else
            {
                prev.Next = curr.Next;
                curr = null;
            }
            return big;
        }
    }
}
