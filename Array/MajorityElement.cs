using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class MajorityElement
    {
        public static int get(int [] arr)
        {
            if (arr.Length < 1)
                return -1;
            else if (arr.Length == 1||arr.Length==2)
                return arr[0];
            else
            {
                int count = 0;
                int maj = arr[0];
                for(int i=1;i<arr.Length-1;i++)
                {
                    if (arr[i] == maj)
                        count++;
                    else
                    {
                        if(count<=0)
                        {
                            maj = arr[i];
                            count = 0;
                        }
                        else
                        {
                            count--;
                        }
                    }
                }
                if (count > 0)
                    return maj;
                else
                    return -1;
            }
        }
    }
}
