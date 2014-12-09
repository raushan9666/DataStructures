using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MinHeap<T> where T:IComparable<T>
    {
        List<T> list;

        public MinHeap()
        {
            list = new List<T>();
        }
        public void Add(T val)
        {
            list.Add(val);
            int c = list.Count()-1;
            while(c>0&&list[c].CompareTo(list[c/2])<0)
            {
                T temp = list[c];
                list[c] = list[c / 2];
                list[c / 2] = temp;
                c = c / 2;
            }
        }


        public T peek()
        {
            if(list.Count>0)
            return list[0];
            return default(T);
        }
        public int count()
        {
            return list.Count;
        }
        public T ExtractMin()
        {                
            if(list.Count<1)
            {
                 return default(T);
            }
            T min = list[0];
            int count= list.Count - 1;
            int l, r;
            list[0] = list[count];
            list.RemoveAt(count);
           
            int c = 0;
            int min_index=c;
            while (c < count)
            {
                l=2*c+1;
                r=2*c+2;
                if(l<count&&list[l].CompareTo(list[c])<0)
                {
                    min_index = l;
                }
                if(r<count&&list[r].CompareTo(list[min_index])<0)
                {
                    min_index = r;
                }
                if (c != min_index)
                {
                    T tmp = list[c];
                    list[c] = list[min_index];
                    list[min_index] = tmp;
                    c = min_index;
                }
                else
                    break;
            }
            return min;
        }
    }
}
