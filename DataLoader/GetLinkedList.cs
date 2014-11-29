using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public static class GetLinkedList
    {
        static Random r1 = new Random();
        public static baseList<int> IntSingleList(int rcount)
        {

            baseList<int> obj = new baseList<int>();
            for (int i = 0; i < rcount; i++)
            {
                obj.Add(r1.Next(10));
            }
            return obj;
        }
        public static baseList<char> CharSingleList(int rcount)
        {

            baseList<char> obj = new baseList<char>();
            for (int i = 0; i < rcount; i++)
            {
                obj.Add(Convert.ToChar(r1.Next(9)+48));
            }
            return obj;
        }
        public static baseList<char> CharSingleList_az(int rcount)
        {

            baseList<char> obj = new baseList<char>();
            for (int i = 0; i < rcount; i++)
            {
                obj.Add(Convert.ToChar(r1.Next(3) + 65));
            }
            return obj;
        }

      
    }
}
