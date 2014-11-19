using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            baseList<int> t =  DataLoader.GetLinkedList.IntSingleList(5);
            reverselist<int> t1 = new reverselist<int>(t);

            t1.Display();
            reverselist<int> reversed = t1.Reverse();

            reversed.Display();
            Console.ReadLine();
        }
    }
}
