using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class root2leafWithMaxSum
    {
        public static void getMaxSumPath(treenode<int> root)
        {
                   int maxsum=int.MinValue;
                                 List<int> maxpath = new List<int>();

            getMaxSumPath_helper(root,ref maxsum,0,new int [9],0,ref maxpath);


            foreach (var item in maxpath)
            {
                Console.Write(item+"->");
            }

        }
        private static void   getMaxSumPath_helper(treenode<int> root,ref int maxsum,int currsum,int [] currPath,int i,ref List<int> maxpath)
        {
            if (root == null)
                return;
            else
            {
                currsum+=root.data;
                currPath[i]=root.data;
                i++;
                if (root.left == null && root.right == null)
                {
                    if (currsum > maxsum)
                    {
                        maxsum = currsum;
                        maxpath = currPath.Take(i).ToList();
                    }

                }

                if (root.left != null)
                    getMaxSumPath_helper(root.left, ref maxsum, currsum, currPath, i,ref maxpath);
                if (root.right != null)
                    getMaxSumPath_helper(root.right, ref maxsum, currsum, currPath, i, ref maxpath);

            }
        }

              
    }
}
