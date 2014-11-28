using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class RemoveDuplicate<T> where T:IComparable
    {
        public static void Sorted(ref baseList<T> ip)
        {
            if (ip == null || ip.Head == null || ip.Head.Next == null)
                return;
            node<T> curr = ip.Head;
            node<T> next = null;
            while(curr!=null&&curr.Next!=null)
            {
                next = curr.Next;
                while (next!=null&&next.CompareTo(curr) == 0)
                    next = next.Next;
                curr.Next = next;

                curr = curr.Next;

            }

        }

        public static void UnSorted(ref baseList<T> ip)
        {
            HashSet<T> HasOccured = new HashSet<T>();
            if (ip == null || ip.Head == null || ip.Head.Next == null)
                return;
            node<T> curr = ip.Head;
            node<T> prev = null;
            while(curr!=null)
            {
                if(!HasOccured.Contains(curr.data))
                {
                    HasOccured.Add(curr.data);
                    prev = curr;
                }
                else
                {
                    prev.Next = curr.Next;
                }
                curr = curr.Next;
            }

        }
    }
}
