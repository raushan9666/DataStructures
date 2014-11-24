using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleLinkedList;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseLinkedlist()
        {
            baseList<int> t = DataLoader.GetLinkedList.IntSingleList(0);
            ReverseHelper(t);
            t = DataLoader.GetLinkedList.IntSingleList(1);
            ReverseHelper(t);
             t = DataLoader.GetLinkedList.IntSingleList(2);
            ReverseHelper(t);
            t = DataLoader.GetLinkedList.IntSingleList(2000);
            ReverseHelper(t);
             


        }
       [TestMethod]
        public void NthHigherPtr()
        {
            baseList<int> t = DataLoader.GetLinkedList.IntSingleList(5);
            MergeSortList<int> t1 = new MergeSortList<int>(t);
             t1.sort();
            NextHigherPtr<int> z = new NextHigherPtr<int>();
            node<int> te = t.Head;
            while (te != null)
            {
                z.Add(te.data);
                te = te.Next;

            }
           
             node<int> actual  = z.GetSortedData();
             node<int> expected = t1.Head;
             while (expected != null)
            {
                Assert.AreEqual(expected.data, actual.data);
               
                actual = actual.Next;
                expected = expected.Next;
            }
        }



        private static void ReverseHelper(baseList<int> t)
        {
            List<int> checker = new List<int>();
            foreach (node<int> item in t)
            {
                checker.Add(item.data);
            }
            reverselist<int> t1 = new reverselist<int>(t);
            var reversed = t1.Reverse();
            checker.Reverse();
            int i = 0;
            foreach (node<int> item in reversed)
            {
                
                if (checker[i] != item.data)
                {
                    throw new Exception();
                }
                i++;
            }
        }
    }
}
