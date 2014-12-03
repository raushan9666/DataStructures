using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   public static class Mirror<T> where T :IComparable
    {
       public static baseTree<T> GetMirror(baseTree<T> ip)
       {
           baseTree<T> op = new baseTree<T>();
           op.root = MirrorHelper(ip.root);
           return op;
       }
       private static treenode<T> MirrorHelper(treenode<T> root)
       {
           if (root == null)
               return null;
          treenode<T> left =  MirrorHelper(root.left);
          treenode<T> right = MirrorHelper(root.right);
         // treenode<T> temp = left;
          root.left = right;
          root.right = left;
          return root;
       }
    }
}
