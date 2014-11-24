using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{

    public  class nodeRand<T>:IComparable<nodeRand<T>> where T:IComparable
    {
        public nodeRand<T> next;
        public nodeRand<T> randl;
        public T data;



        public int CompareTo(nodeRand<T> other)
        {
            return this.data.CompareTo(other.data);
        }
    }


    public class CopyRandomPtr<T> where T:IComparable
    {
        public nodeRand<T> head;
        public int count;


        public CopyRandomPtr(baseList<T> list)
        {
            nodeRand<T> t1 = null;
            node<T> temp = list.Head;
            count = list.count;
            while(temp!=null)
            {
               
                 if(head==null)
                 {
                     t1 = new nodeRand<T>() { data = temp.data };
                     head = t1;
                 }
                 else
                 {
                     t1.next = new nodeRand<T>() { data = temp.data };
                     t1 = t1.next;
                 }
                 temp = temp.Next;
                 

            }
            randomise();

        }


        private CopyRandomPtr()
        {

        }


        private void randomise()
        {
            Random r = new Random();
            int n = count;
            int z;
            nodeRand<T> temp = head;
            while(temp!=null)
            {
                nodeRand<T> t1 = head;
                z = r.Next(n);
                while(z>=0)
                {
                    t1 = t1.next;

                    z--;
                }
                temp.randl = t1;
               // n--;
                temp = temp.next;
            }
        }

        public CopyRandomPtr<T> Copy(CopyRandomPtr<T> ip)
        {
            CopyRandomPtr<T> op = new CopyRandomPtr<T>();
            nodeRand<T> temp = ip.head;
            nodeRand<T> t1 = null;
            //insert a copy of each node between current and the next node
            while(temp!=null)
            {
                t1 = new nodeRand<T>() { data = temp.data, next = temp.next };
                temp.next = t1;
                temp = t1.next;
            }

            //copy the arbitary pointers
            temp = ip.head;
            while(temp!=null&&temp.next!=null)
            {
                if(temp.randl==null)
                {
                    temp.next.randl = null;
                }
                else
                {
                    temp.next.randl = temp.randl.next;
                }
                                  
                temp = temp.next.next;

            }
            //restore orginal and the copy
            temp = ip.head;
            op.head = temp.next;
            nodeRand<T> tt = op.head;
            while(temp!=null)
            {
                temp.next = temp.next.next;
                if(tt.next!=null)
                tt.next = tt.next.next;
                temp = temp.next;
                tt = tt.next;

            }
              


            return op;
        }

       public bool compare(nodeRand<T> a,nodeRand<T> b)
        {
           while(a!=null)
           {
               if (a.data.CompareTo(b.data) != 0 || a.randl.data.CompareTo(b.randl.data) != 0)
               {
                   return false;
               }
               a = a.next;
               b = b.next;
           }
            return true;
        }



    }
}
