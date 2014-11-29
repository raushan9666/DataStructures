using Queues;
using SingleLinkedList;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace Startup
{
    class LinkedListMain
    {
        static void Main(string[] args)
        {
            baseList<int> t =  DataLoader.GetLinkedList.IntSingleList(50);
            baseList<int> t2 = DataLoader.GetLinkedList.IntSingleList(50);
            //reverselist<int> t1 = new reverselist<int>(t);
                    
           //MergeSortList<int> t1 = new MergeSortList<int>(t);
            // t1.sort();


           // baseList<int> t2 = DataLoader.GetLinkedList.IntSingleList(3);
           // t1.sorthelper(ref t2.Head);


           // baseList<int> res = MergeTwoSortedList<int>.Merge2(t1);


            // baseList<int> res = MergeTwoSortedList<int>.merge(t1, t2);

            #region list with Next higher  p0inter
            //NextHigherPtr<int> z = new NextHigherPtr<int>();
            //node<int> te = t.Head;
            //while(te!=null)
            //{
            //    z.Add(te.data);
            //    te = te.Next;

            //}
            //z.PrintSortedData();
            #endregion 



            #region list with random pointers

           // CopyRandomPtr<int> t1 = new CopyRandomPtr<int>(t);

           //CopyRandomPtr<int> res= t1.Copy(t1);

           //Console.WriteLine(res.compare(res.head, t1.head));
           

            

#endregion



           #region reverseKnodes

           //t.Display();
           //Console.WriteLine();
           //baseList<int> z =reverseKnodes<int>.reverseKNodes(t, 3);
           //z.Display();
           #endregion

            #region reverse alternate nodes and append at the end

            //t.Display();
            //Console.WriteLine();
            //baseList<int> res =revAlternateAddEnd<int>.reverse(t);
            //res.Display();

            #endregion

            #region PairWise Reverse    
            ///1->2->3->4->5->6->7 then the function should change it to 2->1->4->3->6->5->7,

            //t.Display();
            //Console.WriteLine();
            //baseList<int> res = PairWiseSwap<int>.reverse(t);
            //res.Display();

            #endregion


            #region swap first kth with last kth node
           

            //t.Display();
            //Console.WriteLine();
            //baseList<int> res = swapFirstKthLastKth<int>.swap(t,3);
            //res.Display();

            #endregion


            #region Delete nodes which have a greater value on right side


            //t.Display();
            //Console.WriteLine();
            //baseList<int> res = DeleteNodewithGreaterRight<int>.delete(t);
            //res.Display();

            #endregion
            #region Split into 2 


            //t.Display();
            //Console.WriteLine();
            //baseList<int> res = SplitAlternative<int>.split(t);
            //res.Display();
            //Console.WriteLine();
            //t.Display();
            #endregion


            #region Merge at alternate position


            //t.Display();
            //Console.WriteLine();
            //t2.Display();
            //Console.WriteLine();
            //baseList<int> res = MergeAlternate<int>.merge(t,ref t2);
            //res.Display();
            //Console.WriteLine();
           
            #endregion



            #region Delete N nodes After M nodes


            //t.Display();
            //Console.WriteLine();
            //baseList<int> res = DeleteNafterM<int>.delete(t,1,2);
            //res.Display();
            //Console.WriteLine();

            #endregion

            #region Add Two Numbers


            //baseList<char> x1 = DataLoader.GetLinkedList.CharSingleList(1);// new baseList<char>();
            //x1.Display();
            // baseList<char> x2 = DataLoader.GetLinkedList.CharSingleList(3);
            // x2.Display();
            // baseList<char> result = AddTwoNumber.Add(x1, x2);
            // result.Display();


            #endregion

             #region add in sorted list
             //MergeSortList<int> t1 = new MergeSortList<int>(t);
             //t1.sorthelper(ref t.Head);
             //t.Display();
             //AddInSortedList<int>.Add(ref t, 390);
             //t.Display();
             #endregion 

             #region remove duplicates
             //MergeSortList<int> t1 = new MergeSortList<int>(t);
             //t1.sorthelper(ref t.Head);
             //t.Display();
             //RemoveDuplicate<int>.Sorted(ref t);
             //t.Display();

             //Console.WriteLine("t2");
             //t2.Display();
             //RemoveDuplicate<int>.UnSorted(ref t2);
             //t2.Display();
             #endregion 

            #region Check Palindrome

            baseList<char> c = new baseList<char>();
            c.Add('A');
            c.Add('B');
                 c.Add('C');
            c.Add('B');
            c.Add('A');//DataLoader.CharSingleList_az(5);
            Console.WriteLine(CheckPalindrome<char>.validate(c));
            c.Add('F');
            Console.WriteLine(CheckPalindrome<char>.validate(c));
            #endregion




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


    class TreeMain
    {
        static void Main(string[] args)
        {
            baseTree<int> t = new baseTree<int>();
            t.Add(1);
            t.Add(7);
            t.Add(8);
            t.Add(10);
            t.Add(89);

            t.inorder(t.root);
            Console.ReadLine();
        }
    }



}
