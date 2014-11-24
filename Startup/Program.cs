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
                    
           //MergeSortList<int> t1 = new MergeSortList<int>(t);
            // t1.sort();


           // baseList<int> t2 = DataLoader.GetLinkedList.IntSingleList(3);
           // t1.sorthelper(ref t2.Head);


           // baseList<int> res = MergeTwoSortedList<int>.Merge2(t1);


             // baseList<int> res = MergeTwoSortedList<int>.merge(t1, t2);

            NextHigherPtr<int> z = new NextHigherPtr<int>();
            node<int> te = t.Head;
            while(te!=null)
            {
                z.Add(te.data);
                te = te.Next;

            }
            z.PrintSortedData();
            
                t.Display();
            Console.WriteLine();
            t =RotateList<int>.RotateEndToFront(t, 0);
            t.Display();
           // Console.WriteLine(NthFromEnd<int>.GetNthValue(t,0));

            // res.Display();



           
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
