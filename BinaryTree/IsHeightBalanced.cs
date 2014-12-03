using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   public static class IsHeightBalanced<T> where T:IComparable
    {
       public static void Is(treenode<T> root)
       {
           int height = 0;
           if(helper(root,ref height))
               Console.WriteLine("Height Balance");
           else
               Console.WriteLine("Not a Height Balance");
       }
       private static bool helper(treenode<T> root,ref int height)
       {
           int lh =0;
           int rh = 0;
           if(root==null)
           {
               height = 0;
               return true;
           }
           bool l = helper(root.left, ref lh);
           bool r = helper(root.right, ref rh);

           height = Math.Max(lh, rh) + 1;

           if (Math.Abs(lh-rh) > 1)
               return false;
           return l && r;
       }
    }
}
