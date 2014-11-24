using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{

    public class nodeHigher<T> : IComparable<nodeHigher<T>> where T : IComparable
    {
        public nodeHigher<T> next;
        public nodeHigher<T> nextHigher;
        public T Data;

        public int CompareTo(nodeHigher<T> other)
        {
            return this.Data.CompareTo(other.Data);
        }
    }

    public class NextHigherPtr<T> where T:IComparable
    {
      

        public nodeHigher<T> Head;

        public  void Add(T data)
        {
            nodeHigher<T> temp = new nodeHigher<T>() { Data = data };
            if(this.Head==null)
            {
                this.Head = temp;
            }
            else
            {
                nodeHigher<T> smallest = GetSmallest();
                nodeHigher<T> smallestBefore = null;
                smallest= mergehelper(smallest, temp);
                //while(smallest!=null&&smallest.nextHigher!=null&&smallest.CompareTo(temp)<0)
                //{
                //    smallestBefore = smallest;
                //    smallest = smallest.nextHigher;
                //}
                //if (smallestBefore != null)
                //{
                //    smallestBefore.nextHigher = temp;
                //    temp.nextHigher = smallest;
                //}
                //else if(smallestBefore == null||smallest.nextHigher == null)
                //{
                //   // smallest.nextHigher = temp;
                //    //temp.nextHigher = smallest;
                //    if(smallest.CompareTo(temp)>0)
                //    {
                //       temp.nextHigher = smallest;
                       
                //    }
                //    else
                //    {
                //        smallest.nextHigher = temp;
                //     }
                 
                //}
               

                nodeHigher<T> temp1 = this.Head;
                while (temp1.next != null)
                {
                    temp1 = temp1.next;
                }
                temp1.next = temp;
                
                //nodeHigher<T> tempHigher = this.Head;
                //while(tempHigher!=null&&tempHigher.nextHigher!=null&&tempHigher.CompareTo(temp)<0)
                //{
                //    tempHigher = tempHigher.nextHigher;
                //}
                //if(tempHigher.CompareTo(temp)<=0)
                //{
                //    tempHigher.nextHigher = temp;
                //}
                //else
                //{
                //    temp.nextHigher = tempHigher;
                //}


                ////adding new node to the list
                //temp.next = this.Head;
                //this.Head = temp;
            }

           // base.Add(data);
        }

        private static nodeHigher<T> mergehelper(nodeHigher<T> a, nodeHigher<T> b)
        {
            nodeHigher<T> temp = null;
            if (a == null)
                return b;
            else if (b == null)
                return a;
            else
            {
                if (a.CompareTo(b) <= 0)
                {
                    temp = a;
                    temp.nextHigher = mergehelper(a.nextHigher, b);
                }
                else
                {
                    temp = b;
                    temp.nextHigher = mergehelper(a, b.nextHigher);

                }
            }
            return temp;

        }

        private nodeHigher<T> GetSmallest()
        {
            nodeHigher<T> smallest = this.Head;
            nodeHigher<T> temp = this.Head.next;
            while (temp != null)
            {
                if (temp.CompareTo(smallest) < 0)
                {
                    smallest = temp;
                }
                temp = temp.next;
            }
            return smallest;
        }



        public void PrintSortedData()
        {

            nodeHigher<T> smallest = GetSmallest();
          
            while(smallest!=null)
            {
                Console.WriteLine(smallest.Data);
                smallest = smallest.nextHigher;
            }
         
        }

        public node<T> GetSortedData()
        {
            baseList<T> tt = new baseList<T>();
            nodeHigher<T> smallest = GetSmallest();

            while (smallest != null)
            {
                 tt.Add(smallest.Data);
               // Console.WriteLine(smallest.Data);
                smallest = smallest.nextHigher;
            }
            return tt.Head;
        }

        public void display()
        {
            nodeHigher<T> temp = this.Head;
            while(temp!=null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.next;
            }
            temp = temp.next;

        }




    }
}
