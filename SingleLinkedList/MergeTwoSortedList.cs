using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class MergeTwoSortedList   <T> where T :IComparable
    {
        
        public static baseList<T> merge(baseList<T> a,baseList<T> b)
        {
            baseList<T> r = new baseList<T>(){Head=null,count=a.count+b.count}               ;
            r.Head =mergehelper(a.Head, b.Head);
            return r;
        }
        private static  node<T> mergehelper(node<T> a, node<T> b)
        {
            node<T> temp = null;
            if (a == null)
                return b;
            else if (b == null)
                return a;
            else
            {
                if(a.CompareTo(b)<=0)
                {
                    temp = a;
                    temp.Next = mergehelper(a.Next, b);
                }
                else
                {
                    temp = b;
                    temp.Next = mergehelper(a, b.Next);

                }
            }
            return temp;

        }




        /// sort list of type 1-2-3-4-5-1-2
        public static  baseList<T> Merge2(baseList<T> a)
        {
            if (a == null)
                return null;
            
            node<T> temp = a.Head;
            if(temp==null ||temp.Next==null)
            {
                return a;
            }
            node<T> temp2 = null;
            while(temp!=null)
            {
                temp2 = temp.Next;
                if(temp2!=null&&temp.CompareTo(temp2)>0)
                {
                    temp.Next = null;
                   
                   a.Head= mergehelper(a.Head, temp2);
                   break;
                }
                else
                {
                    temp = temp.Next;

                }
             
            }
            return a;
        }
        


       
    }
}
