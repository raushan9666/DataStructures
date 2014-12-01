using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;

namespace BinaryTree
{
    public class treenode<T>:IComparable<treenode<T>>,IComparable where T:IComparable
    {
        public treenode<T> left;
        public treenode<T> right;
        public T data;

        public int CompareTo(treenode<T> other)
        {
            return this.data.CompareTo(other.data);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
    public class baseTree<T> where T:IComparable
    {
        public treenode<T> root;

        public void Add(T ip)
        {

           
            if (root == null)
            {
                treenode<T> obj = new treenode<T>() { data = ip };
                root = obj;
                return;
            }
            
            BaseQueue<treenode<T>> _queue = new BaseQueue<treenode<T>>();
            _queue.enqueue(root);
            while(!_queue.IsEmpty())
            {
                treenode<T> r = _queue.dequeue();
                if (r.left != null)
                    _queue.enqueue(r.left);
                else
                {
                    r.left = new treenode<T>() { data = ip };
                    return;
                }
                if(r.right!=null)
                {
                    _queue.enqueue(r.right);
                }

                else
                {
                    r.right = new treenode<T>() { data = ip };
                    return;
                }
            }


        }


        public  void AddBST(T ip)
        {
            root =  AddBST_Helper(root,ip);
        }
        private  treenode<T> AddBST_Helper(treenode<T> r1,T ip)
        {

            if (r1 == null)
            {
                treenode<T> obj = new treenode<T>() { data = ip };
                 return obj;
            }
            else if(ip.CompareTo(r1.data)>0)
            {
               r1.right =AddBST_Helper(r1.right,ip);
            }
            else if(ip.CompareTo(r1.data)<=0)
            {
              r1.left =AddBST_Helper(r1.left,ip);
            }
            return r1;
           
        }
        public void  Preorder(treenode<T> temp)
        {
            if (temp == null)
                return;
            Console.WriteLine(temp.data);
            Preorder(temp.left);
            Preorder(temp.right);
        }
        public void inorder(treenode<T> temp)
        {
            if (temp == null)
                return;
            inorder(temp.left);
            Console.WriteLine(temp.data);
            inorder(temp.right);

        }
    }
}
