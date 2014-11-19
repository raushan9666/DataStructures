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
