using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class MergeAlternate<T> where T:IComparable
    {
        public static baseList<T> merge(baseList<T> a,ref baseList<T> b)
        {
            baseList<T> res = new baseList<T>();
            res.count = Math.Min(a.count, b.count)*2;
            node<T> anode = a.Head;
            node<T> bnode = b.Head;
            node<T> anode_next;
            node<T> bnode_next;
            while(anode!=null&&bnode!=null)
            {
                anode_next = anode.Next;
                bnode_next = bnode.Next;

                anode.Next = bnode;
                //if(anode_next==null)
                //{
                //    anode
                //}
                anode = anode_next;
                bnode.Next = anode;
                bnode = bnode_next;

            }
            b.Head = bnode;
            res.Head = a.Head;
            return res;
        }

    }
}
