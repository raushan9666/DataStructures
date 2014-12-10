using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;

namespace Startup
{
   public  class ArrayMain
    {
       static void Main(string[] args)
       {
           #region subarray with given sum
          // int [] ar= new int[] {1,2,3,4,5,6,7,8,9,21,1};
           //SubarrayWithSum.run(ar,31);
           #endregion

           #region Array Rotation
           //int[] ar1 = new int[] {5,6,7,1,2,3,4};
           //Console.WriteLine(ar1[ArrayRotation.findPivot(ar1)]);
           //Console.WriteLine("smallest value");
           //Console.WriteLine(ar1[ArrayRotation.FindSmallest(ar1)]);
           //Console.WriteLine("Search");
           //Console.WriteLine(ArrayRotation.search(ar1,6));

           #endregion

           #region majority element
           int[] ar1 = new int[] { 2, 2, 3, 5, 2, 2, 6 };
           Console.WriteLine(MajorityElement.get(ar1));
           #endregion 
           Console.ReadLine();
       }
    }
}
