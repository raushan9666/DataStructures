using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class all_r_2_l_Paths<T> where T:IComparable
    {
        public static void  printPath(treenode<T> root)
        {
            helper(root, new T[10], 0);
        }
        private static void helper(treenode<T> root,T [] path,int c)
        {
            if (root == null)
                return;
            else
            {
                path[c] = root.data;
                c++;
                if (root.left == null && root.right == null)
                {
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write(path[i] + "->");
                    }
                    Console.WriteLine();
                }

                if (root.left != null)
                    helper(root.left, path, c);
                if (root.right != null)
                    helper(root.right, path, c);


            }
        }
    }
}
