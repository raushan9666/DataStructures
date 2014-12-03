using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
   public static class GetBinaryTree
    {
        static Random r1 = new Random();
        public static baseTree<int> IntBinaryTree(int rcount)
        {

            baseTree<int> obj = new baseTree<int>();
            for (int i = 0; i < rcount; i++)
            {
                obj.Add(r1.Next(100));
            }
            return obj;
        }
        public static baseTree<int> IntBinarySearchTree(int rcount)
        {

            baseTree<int> obj = new baseTree<int>();
            for (int i = 0; i < rcount; i++)
            {
                obj.AddBST(r1.Next(100));
            }
            return obj;
        }

        public static baseTree<char> CharBinaryTree_az(int rcount)
        {

            baseTree<char> obj = new baseTree<char>();
            for (int i = 0; i < rcount; i++)
            {
                obj.Add(Convert.ToChar(r1.Next(26) + 65));
            }
            return obj;
        }
    }
}
