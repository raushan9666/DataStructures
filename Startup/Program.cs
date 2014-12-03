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
        //    baseTree<int> t = new baseTree<int>();
        //    t.Add(1);
        //    t.Add(7);
        //    t.Add(8);
        //    t.Add(10);
        //    t.Add(89);

        //    t.inorder(t.root);
        //    Console.ReadLine();


            #region LCA of Binary Tree
            //baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(7);
            //t1.inorder(t1.root);
            //Console.WriteLine(LCA<int>.GetLCA(t1, 12, 23));
            //Console.ReadLine();
#endregion

            #region LCA of Binary Search Tree
            //baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinarySearchTree(7);
            //t1.inorder(t1.root);
            //Console.WriteLine(LCAinBST<int>.GetLCA(t1, 12, 23));
            //Console.ReadLine();
            #endregion

            #region Mirror of Binary Tree
            //baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(5);
            //t1.inorder(t1.root);
            //Console.WriteLine();
            //baseTree<int> op = Mirror<int>.GetMirror(t1);
            //op.inorder(op.root);
            //Console.ReadLine();
            #endregion

            #region Height of Binary Tree
            //baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(50);
            //t1.inorder(t1.root);
            //Console.WriteLine();
            //int h = Height_Size<int>.Height(t1.root);
            //Console.WriteLine("Height of tree {0}",h);
            //int h1 = Height_Size<int>.Size(t1.root);
            //Console.WriteLine("size of tree {0}", h1);
            //Console.ReadLine();
            #endregion

            #region Check if two tree are same
            //baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(3);
            //t1.inorder(t1.root);
            //Console.WriteLine();
            //Console.WriteLine("Is Both tree same  {0}",   Identical<int>.IsSame(t1.root,t1.root));
            //baseTree<int> t2 = DataLoader.GetBinaryTree.IntBinaryTree(5);
            //Console.WriteLine("Is Both tree same  {0}", Identical<int>.IsSame(t1.root, t2.root));
            //Console.ReadLine();
            #endregion

            #region find if there is path from root to leaf whose sum is equal to given value
           // baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(7);
           //// baseTree<int> t1 = new baseTree<int>();
           //// t1.Add(8); t1.Add(1); t1.Add(7); t1.Add(1); t1.Add(4); t1.Add(0); t1.Add(5);
           // t1.inorder(t1.root);
           // Console.WriteLine();
           // root2leafWithSum.find(t1.root, 15);
           // Console.ReadLine();
            #endregion
           
            #region find max sum root to leaf path
           // baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(10);
           //// baseTree<int> t1 = new baseTree<int>();
           //// t1.Add(8); t1.Add(1); t1.Add(7); t1.Add(1); t1.Add(4); t1.Add(0); t1.Add(5);
           // t1.inorder(t1.root);
           // Console.WriteLine();
           // root2leafWithMaxSum.getMaxSumPath(t1.root);
           // Console.ReadLine();
            #endregion

           #region Print All Root to Leaf Path
           // baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(10);
           //// baseTree<int> t1 = new baseTree<int>();
           //// t1.Add(8); t1.Add(1); t1.Add(7); t1.Add(1); t1.Add(4); t1.Add(0); t1.Add(5);
           // t1.inorder(t1.root);
           // Console.WriteLine();
           // all_r_2_l_Paths<int>.printPath(t1.root);

           // baseTree<char> t2 = DataLoader.GetBinaryTree.CharBinaryTree_az(1);
           // t2.inorder(t2.root);
           // Console.WriteLine();
           // all_r_2_l_Paths<char>.printPath(t2.root);


           // Console.ReadLine();
            #endregion


            #region Is Height Balanced AVL trees
            baseTree<int> t1 = DataLoader.GetBinaryTree.IntBinaryTree(15);
            // baseTree<int> t1 = new baseTree<int>();
            // t1.Add(8); t1.Add(1); t1.Add(7); t1.Add(1); t1.Add(4); t1.Add(0); t1.Add(5);
            t1.inorder(t1.root);
            Console.WriteLine();
            IsHeightBalanced<int>.Is(t1.root);

            baseTree<int> t2 = DataLoader.GetBinaryTree.IntBinarySearchTree(20);
            t2.inorder(t2.root);
            Console.WriteLine();
            IsHeightBalanced<int>.Is(t2.root);


            Console.ReadLine();
            #endregion
            
                
                



        }
    }



}
