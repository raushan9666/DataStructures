using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class LCA<T> where T:IComparable
    {
        public static T GetLCA(baseTree<T> ip,T a,T b)
        {
            bool a_flag=false;
            bool b_flag=false;
            treenode<T> res =GetLCA_Helper(ip.root,a,b,ref a_flag,ref b_flag);
            if ((a_flag && b_flag)||( a_flag&&Find(res,b)) || (b_flag&&Find(res,a)))
                return res.data;
            else
                return default(T);


        }
        private static treenode<T> GetLCA_Helper(treenode<T> root,T a,T b,ref bool a_flag,ref bool b_flag)
        {
            if(root==null)
                return null;
            if(root.data.CompareTo(a)==0)
            {
                a_flag=true;
                return root;

            }
            if(root.data.CompareTo(b)==0)
            {
                b_flag=true;
                return root;
            }

            treenode<T> left=GetLCA_Helper(root.left,a,b,ref a_flag,ref b_flag);
            treenode<T> right =GetLCA_Helper(root.right,a,b,ref a_flag,ref b_flag);

            if(left!=null&&right!=null)
                return root;
            return left!=null?left:right;


        }



        private static bool Find(treenode<T> root,T data)
        {
            if (root == null)
                return false;
            else
                return (root.data.CompareTo(data) == 0 || Find(root.left, data) || Find(root.right, data));

        }
    }
}
