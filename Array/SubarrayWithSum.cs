using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class SubarrayWithSum
    {
        public static void run(int [] arr,int sum)
        {
            if (arr.Length < 1)
                return;
            int currsum = arr[0];
            int sindex=0;
            int i = 1;
           while(sindex<arr.Length)
            {
                if(currsum<sum)
                {
                    currsum += arr[i];
                    i++;

                }
                else if(currsum>sum)
                {
                    currsum -= arr[sindex];
                    sindex++;
                }
               
                if(currsum==sum)
                {
                     while(sindex<i)
                     {
                         Console.Write(arr[sindex]+" ");
                         sindex++;
                     }
                }
            }
            if(currsum!=sum)
            Console.WriteLine("No result found");
        }
    }
}
