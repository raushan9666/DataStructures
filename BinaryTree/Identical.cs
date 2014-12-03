using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class Identical<T> where T:IComparable
    {
        public static bool IsSame(treenode<T> a,treenode<T> b)
        {
            if (a == null && b == null)
                return true;
            else if(a!=null&&b!=null)
            {
                return (a.CompareTo(b)==0 && IsSame(a.left, b.left) && IsSame(a.right, b.right));
            }
            return false;
        }

    }
}
