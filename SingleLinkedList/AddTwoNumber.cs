using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
   public static class AddTwoNumber
    {

       public static baseList<char> Add(baseList<char> a,baseList<char> b)
       {
           baseList<char> res = new baseList<char>();
           node<char> result;
           node<char> curr;
           int carry = 0;
           if(a==null ||a.Head==null)
           {
               return b;
           }
           if(b==null||b.Head==null)
           {
               return a;
           }
           int a_size = a.count;
           int b_size = b.count;

           if (a_size == b_size)
           {
               result = AddSameSize(a.Head, b.Head, ref carry);
           }
           else
           {

               int diff = Math.Abs(a_size - b_size);
               if (a_size < b_size)
               {
                   node<char> t = a.Head;
                   a.Head = b.Head;
                   b.Head = t;

               }
               curr = a.Head;
               for (int i = 0; i < diff; i++, curr = curr.Next) ;

               result = AddSameSize(curr, b.Head, ref carry);

               AddRemaining(a.Head, curr, ref carry, ref result);
                             
           }
           if (carry != 0)
           {
               node<char> tt = new node<char>();
               tt.data = (char)(48+carry);
               tt.Next = result;
               result = tt;
           }

           res.Head = result;
           return res;

       }

       private static node<char> AddSameSize(node<char> a ,node<char> b ,ref int carry)
       {
           if (a == null)
               return null;
           int sum;

           node<char> res = new node<char>();

           res.Next=AddSameSize(a.Next,b.Next,ref carry);

           sum = (int)(char.GetNumericValue(a.data) + char.GetNumericValue(b.data) + carry);
           carry = sum / 10;
           sum = sum % 10;
           res.data = (char)(sum+48);
           return res;


       }


       private static void AddRemaining(node<char> a,node<char> cur,ref int carry,ref node<char> result)
       {
           int sum;
           node<char> temp = new node<char>();
           if(a!=cur)
           {
               AddRemaining(a.Next, cur, ref carry, ref result);
               sum = (int)(char.GetNumericValue(a.data) + carry);
               carry = sum / 10;
               sum = sum % 10;
               temp.data = (char)(sum+48);
               temp.Next = result;
               result = temp;
           }
         
       }




    }
}
