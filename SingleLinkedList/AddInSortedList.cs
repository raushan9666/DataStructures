using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class AddInSortedList<T> where T:IComparable
    {
        public static void Add(ref baseList<T> ip,T data)
        {
            if(ip==null)
            {
                ip = new baseList<T>() { Head = new node<T>() { data = data } };
                return;
            }
            if(ip.Head==null)
            {
                ip.Head = new node<T>() { data = data };
                return;
            }
            if(ip.Head.data.CompareTo(data)>0)
            {
                node<T> temp = new node<T>();
                temp.data = data;
                temp.Next = ip.Head;
                ip.Head = temp;
                return;
            }
            node<T> temp1 = ip.Head;
            node<T> prev = null;
            node<T> tt= new node<T>(){data=data};
            while(temp1!=null&&temp1.CompareTo(tt)<0)
            {
                prev = temp1;
                temp1 = temp1.Next;

            }
            prev.Next = tt;
            tt.Next = temp1;
            return;


        }
    }
}
