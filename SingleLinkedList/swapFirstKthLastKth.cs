using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    /// <summary>
    /// Swap Kth node from beginning with Kth node from end in a Linked List
    /// </summary>
    public static class swapFirstKthLastKth<T> where T:IComparable
    {
        public static baseList<T> swap(baseList<T> a,int k)
        {
            baseList<T> res = new baseList<T>();
            res.count = a.count;
            res.Head = swaphelper(a.Head,k);
            return res;
        }
        private static node<T> swaphelper(node<T> a,int k)
        {
            int n = getcount(a);

            if (k > n)
                return a;
            if (2 * k - 1 == n)
                return a;
            // find kth from begin
            node<T> x_prev = null;
            node<T> x = a;
            for(int i=1;i<k;i++)
            {
                x_prev = x;
                x = x.Next;
            }
            
            //find kth from end
            node<T> y_prev = null;
            node<T> y = a;
            for (int i = 1; i < n-k+1; i++)
            {
                y_prev = y;
                y = y.Next;
            }

            if(x_prev!=null)
            x_prev.Next = y;
            if (y_prev!=null)
                y_prev.Next = x;

            node<T> t1 = x.Next;
            x.Next = y.Next;
            y.Next = t1;

            if (k == 1)
                a = y;
            if (k == n)
                a = x;
                    return a;



        }
        private static int getcount(node<T> a)
        {
            int c = 0;
            node<T> temp = a;
            while(temp!=null)
            {
                c++;
                temp = temp.Next;
            }
            return c;
        }
    }
}
