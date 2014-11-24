using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
     public static class RotateList   <T> where T :IComparable
         {


         public static baseList<T>  RotateFrontToEnd(baseList<T> a,int n)
         {
             a.Head =RotateHelper(a.Head, n, false);
             return a;
         }
         public static baseList<T>  RotateEndToFront(baseList<T> a,int n)
         {
             a.Head =RotateHelper(a.Head, n, true);
             return a;
         }
         private static node<T> RotateHelper(node<T> h,int n,bool backtofront)
         {
             int count;
             if (h == null)
                 return null;
             node<T> temp = h;
             count = 1;
             while(temp.Next!=null)
             {
                 count++;
                 temp = temp.Next;
             }
               int r;
             temp.Next = h;
                  
             if(backtofront)
             { 
                 r = count-n-1; 
             }
             else
             {
                r=n-1;
             }

              node<T> temp1=h;
                 while(r>0)
                 {
                     temp1 = temp1.Next;
                     r--;
                 }
                 h = temp1.Next;
                 temp1.Next = null;
                 return h;
         }

    }
}
