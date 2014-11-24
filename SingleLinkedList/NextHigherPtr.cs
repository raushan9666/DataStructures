using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    
    public class NextHigherPtr<T> where T:IComparable
    {
        internal class node<T>:IComparable<node<T>> where T:IComparable
        {
            public node<T> next;
            public node<T> nextHigher;
            public T Data;

            public int CompareTo(node<T> other)
            {
                return this.Data.CompareTo(other.Data);
            }
        }

        public node<T> Head;

        public override void Add(T data)
        {
            node<T> temp = new node<T>() { Data = data };
            if(this.Head==null)
            {
                this.Head = temp;
            }
            else
            {
                node<T> tempHigher = this.Head;
                while(tempHigher!=null&&tempHigher.nextHigher!=null&&tempHigher.CompareTo(temp)<0)
                {
                    tempHigher = tempHigher.nextHigher;
                }
                if(tempHigher.CompareTo(temp)<=0)
                {
                    tempHigher.nextHigher = temp;
                }
                else
                {
                    temp.nextHigher = tempHigher;
                }


                //adding new node to the list
                temp.next = this.Head;
                this.Head = temp;
            }

           // base.Add(data);
        }





    }
}
