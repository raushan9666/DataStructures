using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class LCAinBST<T> where T:IComparable
    {

        public static T GetLCA(baseTree<T> ip,T a,T b)
        {
            
            T temp;
            if(a.CompareTo(b)>0)
            {
                temp = a;
                a = b;
                b = temp;
            }
              
            treenode<T> op =LCAHelper(ip.root, a, b);
            if(op!=null)
                return op.data;

            return default(T);
           
           
        }
        private static treenode<T> LCAHelper(treenode<T> root,T a,T b)
        {
            if (root == null)
                return null;
          
           
            if(a.CompareTo(root.data)>0&& b.CompareTo(root.data)>0)
               return LCAHelper(root.right,a,b);

             if(a.CompareTo(root.data)<0&& b.CompareTo(root.data)<0)
               return   LCAHelper(root.left,a,b);

             return root;
        }
    }
}
