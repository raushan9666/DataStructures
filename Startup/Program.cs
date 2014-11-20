using Queues;
using SingleLinkedList;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class LinkedListMain
    {
        static void Main(string[] args)
        {
            baseList<int> t =  DataLoader.GetLinkedList.IntSingleList(5);
            //reverselist<int> t1 = new reverselist<int>(t);
                        
            MergeSortList<int> t1 = new MergeSortList<int>(t);
            t1.Display();
             t1.sort();
             //t1.sorthelper(ref t.Head);
             Console.WriteLine();
            t1.Display();
            Console.ReadLine();
        }
    }

    class StackMain
    {
        static void Main(string []args)
        {
            BaseStack<int> t = DataLoader.GetStack.IntStack(5);
            for (int i = 0; i < 4;i++)
            {
                Console.WriteLine(t.pop());
            }
            Console.WriteLine(t.peek());
            t.push(0);
            Console.WriteLine(t.pop());

            Console.ReadLine();
        }
    }

    class QueueMain
    {
        static void Main(string[] args)
        {
            BaseQueue<int> t = DataLoader.GetQueue.IntQueue(5);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(t.dequeue());
            }
          
            t.enqueue(0);
            Console.WriteLine(t.dequeue());

            Console.ReadLine();
        }
    }
}
