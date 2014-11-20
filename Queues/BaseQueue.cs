using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class BaseQueue<T> where T : IComparable
    {
        node<T> front;
        node<T> rear;


        public void enqueue(T data)
        {
            node<T> temp = new node<T>() { data = data, Next = null };
            if(rear==null)
            {
                rear = temp;
                front = rear;
            }
            else
            {
                temp.Next = rear;
                rear = temp;
            }

        }
        public T dequeue()
        {
            T data;
            if(front==null)
            {
                return default(T);
            }
            else
            {
                node<T> temp = rear;
                while (temp.Next != front)
                    temp = temp.Next;
                data = temp.data;

                front = temp;
            }
            return data;

        }


    }
}
