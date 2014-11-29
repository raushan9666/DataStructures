using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public static class CheckPalindrome<T> where T:IComparable
    {
        public static bool validate(baseList<T> ip)
        {
            node<T> temp = ip.Head;
            return vaidate_helper(ref temp, temp);
        }
        private static bool vaidate_helper(ref node<T> left,node<T> right)
        {
            if (right == null)
                return true;
            bool res = vaidate_helper(ref left, right.Next);
            if (res == false)
                return false;
            res = left.CompareTo(right) == 0 ? true : false;

            left = left.Next;
            return res;
        }
    }
}
