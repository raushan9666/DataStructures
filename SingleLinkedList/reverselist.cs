using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class reverselist<T>:baseList<T>
    {
        public reverselist(baseList<T> obj)
        {
            this.Head = obj.Head;
            this.count = obj.count;
            this._current = base._current;
        }
        private reverselist()
        {

        }


        public reverselist<T> Reverse()
        {
            if (Head == null || Head.Next == null)
                return new reverselist<T>();
            node<T> current = new node<T>();
            node<T> prev = null;
            node<T> next = this.Head.Next;
            current = this.Head;

            while (next != null)
            {
                current.Next = prev;
                prev = current;
                current = next;
                next = next.Next;
            }
            current.Next = prev;
            return new reverselist<T> { Head = current, count = this.count };




        }
    }
}
