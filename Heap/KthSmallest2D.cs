using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{

    public class element:IComparable<element>,IComparable
    {
        public int r;
       public  int c;
       public int data;

       public int CompareTo(element other)
       {
           return this.data.CompareTo(other.data);
       }

       public int CompareTo(object obj)
       {
           throw new NotImplementedException();
         
       }
    }


    public static class KthSmallest2D
    {
            public static element Get(int [,] a,int r,int c,int k)
            {
                MinHeap<element> t = new MinHeap<element>();
                for(int i=0;i<c;i++)
                {
                    t.Add(new element() { r = 0, c = i, data = a[0, i] });
                }
                element tmp = null;
                for(int i=0;i<k;i++)
                {
                    tmp = t.ExtractMin();
                    if (tmp.r + 1 < r)
                    {
                        t.Add(new element() { data = a[tmp.r + 1, tmp.c], r = tmp.r + 1, c = tmp.c });
                    }
                    else
                    {
                        t.Add(new element() { r = tmp.r + 1, c = tmp.c, data = int.MaxValue }); ;
                    }
                }
                return tmp;
            }
    }
}
