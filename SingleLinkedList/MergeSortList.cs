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
            node<T> temp1 = obj.Head;
            node<T> temp = new node<T>();
            temp.data = temp1.data;
            temp1 = temp1.Next;
            this.Head = temp;
         
            while(temp1!=null)
            {
                
                temp.Next = new node<T>();
                temp = temp.Next;
                temp.data = temp1.data;
                temp1 = temp1.Next;
             

            }
            //this.Head=obj.Head;
            this.count = obj.count;
            this._current = base._current;
        }
        
        public void sort()
        {

            sorthelper(ref this.Head);
           
        }

        public void sorthelper(ref node<T> head)
        {
            if(head==null ||head.Next==null)
            {
                return;
            }
            node<T> a = null;
            node<T> b = null;
            split(head, ref a, ref b);
            sorthelper(ref a);
            sorthelper(ref b);
           head= merge(a, b);

        }
       
        private void split(node<T> h1,ref node<T> a ,ref node<T> b)
        {
            node<T> slow  ;
            node<T> fast  ;
            if(h1==null||h1.Next==null)
            {
                a=h1;
                b=null;
            }
            else
            {
                slow = h1;
                fast = h1.Next;
                while(fast!=null)
                {
                    fast = fast.Next;
                    if(fast!=null)
                    {
                        fast = fast.Next;
                        slow = slow.Next;
                    }
                }
                a = h1;
                b = slow.Next;
                slow.Next = null;
            }
           
        }

         
        private node<T> merge(node<T> a, node<T> b)
        {
            node<T> r = null;
          
            if (a == null)
                return b;
            else if (b == null)
                return a;
            else
            {

                if (a.CompareTo(b) <= 0)
                {
                    r = a;
                    r.Next = merge(a.Next, b);
                }
                else if (a.CompareTo(b) > 0)
                {
                    r = b;
                    r.Next = merge(a, b.Next);
                }



                //while (a != null && b != null)
                //{
                //    if (a.CompareTo(b) < 0)
                //    {
                //        res = a;
                //        a = a.Next;
                //    }
                //    else if (a.CompareTo(b) > 0)
                //    {
                //        res = b;
                //        b = b.Next;
                //    }
                //    else
                //    {
                //        res= a;
                //        a = a.Next;
                //        b = b.Next;
                //    }
                //    res = res.Next;
                //}
                //while (a != null)
                //{
                //    res = a;
                //    res = res.Next;
                //    a = a.Next;
                //}
                //while (b != null)
                //{
                //    res = b;
                //    res = res.Next;
                //    b = b.Next;
                //}

            }
            return r;
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
