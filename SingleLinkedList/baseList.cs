using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
     public class node<T>
    {
        public T data;
        public node<T> Next;
    }


    public class baseList<T> : IEnumerable, IEnumerator
    {
        

        public node<T> Head;
        protected node<T> _current;
        public int count;

        public baseList()
        {
            Head = null;
           
            count = 0;
        }


        public void Add(T data)
        {
            node<T> temp = new node<T> { data = data, Next = null };

            if(Head==null)
            {
                Head = temp;
               // _current = Head;
                count = 1;
            }
            else
            {
                node<T> t1 = Head;
                while(t1.Next!=null)
                {
                    t1 = t1.Next;
                }
                t1.Next = temp;
                count++;
            }
        }
        public T Delete()
        {
            T data = default(T);
            if(this.Head!=null)
            {
                data = Head.data;
                Head = Head.Next;
                
            }
            return data;
        }
        public void Display()
        {
            if(this.Head!=null)
            {
                node<T> t = this.Head;
                while(t!=null)
                {
                    Console.WriteLine(t.data);
                    t = t.Next;
                }
            }

        }


        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public object Current
        {
            get { return this._current; }
        }

        public bool MoveNext()
        {
            if (this.Head == null)
                return false;
            
            if (this._current != null)
            {
                this._current = this._current.Next;
                if (this._current == null)
                {
                    
                    return false;
                }
                return true;
            }
            else
            {
                Reset();
                return true;
            }
            
        }

        public void Reset()
        {
            this._current = this.Head;
        }
    }
}
