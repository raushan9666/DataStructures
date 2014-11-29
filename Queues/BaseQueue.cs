using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class BaseQueue<T> where  T:IComparable
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
                if (front == rear)
                {
                    data = front.data;
                    front = null; rear = null;
                }
                else
                {
                    node<T> temp = rear;
                    while (temp != null && temp.Next != front)
                        temp = temp.Next;
                    data = front.data;

                    front = temp;
                }
            }
            return data;

        }

       public bool IsEmpty()
       {
           if (front == null && rear == null)
               return true;
           return false;
       }

       public int CompareTo(T other)
       {
           return 1;
       }
    }
}
