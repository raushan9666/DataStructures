using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class ChildrenSum
    {
        public static bool IsValid(treenode<int> root)
        {
            if (root == null)
                return true;
            else if (root.left == null && root.right == null)
                return true;
            else
            {     int l=0;int r=0;  
 
                if(root.left!=null)
               l= root.left.data;
                if(root.right!=null)
                r = root.right.data;

                return ((l + r) == root.data && IsValid(root.left) && IsValid(root.right));

            }
        }

        public static treenode<int> Convert(treenode<int> root)
        {
            if (root == null ||(root.left == null && root.right == null)      )
                return root;
            else
            {
                int sum=0;
                treenode<int> l = Convert(root.left);
                treenode<int> r = Convert(root.right);
                if (l != null)
                    sum += l.data;
                if (r != null)
                    sum += r.data;

                int diff=sum-root.data;

                if (diff==0)
                    return root;
                else if(diff>0)
                {
                    root.data +=diff;
                    return root;
                }
                else   // propagated the diff down to the root;
                {
                    treenode<int> temp = root;

                    while (temp != null)
                    {
                        if (temp.left != null)
                        {
                            temp.left.data += Math.Abs(diff);

                            temp = temp.left;

                        }
                        else if (temp.right != null)
                        {
                            temp.right.data += Math.Abs(diff);

                            temp = temp.right;

                        }
                        else
                            break;

                    }
                    return root;

                }



            }
        }
    }
}
