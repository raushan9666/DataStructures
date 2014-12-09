using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class PriorityQueue<T>
    {
        internal class Node:IComparable<Node>
        {
            public int priority;
            public T Obj;
            public int CompareTo(Node other)
            {
                return this.priority.CompareTo(other.priority);
            }
        }

        MinHeap<Node> _minheap;

        public PriorityQueue()
        {
            _minheap = new MinHeap<Node>();
        }

        public void Add(int priority,T data)
        {
            _minheap.Add(new Node(){ Obj=data,priority=priority});
        }
        public T peek()
        {
            return _minheap.peek().Obj;
        }
        public int count()
        {
            return _minheap.count();

        }
        public T getMin()
        {
            return _minheap.ExtractMin().Obj;
        }

    }
}
