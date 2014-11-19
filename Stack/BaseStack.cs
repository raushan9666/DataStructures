using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
              
    public class  BaseStack<T>//:baseList<T>
    {
        node<T> top;
       
        public void push(T data)
        {
            node<T> temp = new node<T>() { data = data, Next = null };
            if(this.top==null)
            {
                top = temp;
            }
            else
            {
                temp.Next = top;
                top = temp;
            }
            
        }
                  
        public T pop()
        {
            T value;
            if (this.top == null)
                return default(T);
            else
            {      value=this.top.data;
                this.top=this.top.Next;
                
            }
            return value;
        }
        public T peek()
        {
            if (this.top == null)
                return default(T);
            else
            {
                return this.top.data;

            }

        }


    }
    

}

