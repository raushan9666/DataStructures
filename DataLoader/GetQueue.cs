using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public static class GetQueue
    {

        static Random r = new Random();
        public static BaseQueue<int> IntQueue(int count)
        {
            BaseQueue<int> bstack = new BaseQueue<int>();
            for (int i = 0; i < count; i++)
            {
                bstack.enqueue(r.Next(10000));
            }
            return bstack;
        }


    }
}
