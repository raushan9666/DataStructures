using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class root2leafWithSum
    {
        public static void find(treenode<int> root,int sum)
        {

            int[] path = new int[10];
            int index = 0;
                                int count=0;
            if(findhelper(root, path, sum, index,ref count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(path[i] + " -> ");
                }
            }
                
                
          
        }
        private static bool findhelper(treenode<int> root,int [] path,int sum,int index,ref int count)
        {
            if (root == null)
                return sum==0;
            else
            {
                path[index] = root.data;
                index++;
                sum -= root.data;

               if (root.left == null && root.right == null)
                {
                        if (root.data.CompareTo(sum) == 0)
                        {
                            count = index;
                            return true;
                        }
                        else
                            return false;
                }
               else
               {
                   return (findhelper(root.left, path, sum, index,ref count) || findhelper(root.right, path, sum, index,ref count));
               }

            }
                     

         
        }
    }
}
