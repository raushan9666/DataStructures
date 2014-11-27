using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class DeleteNafterM<T> where T:IComparable
    {
        public static baseList<T> delete(baseList<T> a,int m,int n)
        {

            baseList<T> res = new baseList<T>();
            node<T> temp = a.Head;
            int deleted=0;
            int count;
            node<T> prev = null;

            while(temp!=null)
            {
                count = 0;
                while (count < m&&temp!=null)
                {
                    prev = temp;
                    temp = temp.Next;
                    count++;
                }
                count = 0;
                while(count<n&&temp!=null)
                {
                    count++;
                    temp = temp.Next;

                }      
                if(count==n)
                {
                    prev.Next = temp;
                    deleted += n;
                }
                         
            }
            res.Head = a.Head;
            res.count = a.count - deleted;
            return res;

            

        }
    }
}
