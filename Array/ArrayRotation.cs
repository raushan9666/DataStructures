using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class ArrayRotation
    {
        public static int findPivot(int [] arr)
        {
            if (arr.Length < 1)
                return -1;
            else if (arr.Length == 1)
                return arr[0];
            else
            {
                int l = 0;
                int r = arr.Length-1;
                int mid=-1;
                while(l<=r)
                {
                    mid = l + (r - l) / 2;
                    if(mid <r&&arr[mid]>arr[mid+1])
                    {
                        return mid;
                    }
                    else if(mid>l&&arr[mid-1]>arr[mid])
                    {
                        return mid-1;
                    }
                    else if(arr[l]>=arr[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }


                }
                return mid;
            }

        }

        public static int FindSmallest(int [] arr)
        {
            if (arr.Length < 1)
                return -1;
            else if (arr.Length == 1)
                return arr[0];
            else
            {
                int l = 0;
                int r = arr.Length - 1;
                int mid = -1;
                while(l<=r)
                {
                    mid = l + (r - l) / 2;
                    if(mid<r&&arr[mid]>arr[mid+1])
                    {
                        return mid + 1;
                    }
                    else if(mid>l&&arr[mid]<arr[mid-1])
                    {
                        return mid;
                    }
                    else if(arr[l]>arr[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                return mid;
            }
        }


        public static bool search(int [] arr,int val)
        {
            if (arr.Length < 1)
                return false;
            else if (arr.Length == 1)
                return (arr[0] == val);
            else
            {
                int pivot = findPivot(arr);
                if (pivot == -1)
                    bsearch(arr, 0, arr.Length - 1, val);
                if (arr[pivot] == val)
                    return true;
                else if (arr[0] < val)
                    return bsearch(arr, 0, pivot - 1, val);
                else
                    return bsearch(arr, pivot + 1, arr.Length - 1, val);
               
            }
        }

       static bool bsearch(int [] arr,int l,int r,int val)
        {
            int mid = -1;
           while(l<=r)
           {
               mid = l + (r - l) / 2;
               if (arr[mid] == val)
                   return true;
               else if (arr[mid] > val)
                   r = mid - 1;
               else
                   l = mid + 1;

           }
           return false;
        }


    }
}
