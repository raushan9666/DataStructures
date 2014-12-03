using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class Height_Size<T> where T:IComparable
    {
        public static int Height(treenode<T> ip)
        {
            if (ip == null)
                return 0;

            return (Math.Max(Height(ip.left), Height(ip.right)) + 1);

        }

        public static int Size(treenode<T> root)
        {
            if (root == null)
                return 0;
            return (Size(root.left) + Size(root.right) + 1);
        }





    }
}
