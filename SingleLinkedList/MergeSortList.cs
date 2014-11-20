using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class MergeSortList<T> : baseList<T> where T : IComparable
    {
        public MergeSortList(baseList<T> obj)
        {
            this.Head = obj.Head;
            this.count = obj.count;
            this._current = base._current;
        }


        public baseList<T> sort(baseList<T> ip)
        {

        }
        private void breakList(baseList<T> ip)
        {

        }

        private baseList<T> merge(baseList<T> ip1, baseList<T> ip2)
        {
           
            if (ip1 == null)
                return ip2;
            else if (ip2 == null)
                return ip1;
            else
            {
                if(ip1.Head.CompareTo(ip2.Head)>0)
                {
                    node<T> temp = ip1.Head;
                    ip1.Head = ip2.Head;
                    ip2.Head = temp;
                    int cc = ip1.count;
                    ip1.count = ip2.count;
                    ip2.count = cc;
                }
                while(ip1!=null&&ip2!=null)
                {
                   
                }
            }
        }



        public void Display()
        {
            node<T> temp = new node<T>();
            temp = this.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Next;
            }
        }
    }
}
