using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class reverseKnodes<T> where T :IComparable
    {
        private baseList<T> _list;

        public node<T> head;
        public reverseKnodes( baseList<T> t)
        {
            _list = t;
            head = _list.Head;
        }


        public void reverseKNodes()
        {

        }
    }
}
