using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class Bipartite
    {               
        //do a bfs and assgin color to immediate child as 0 
        public static bool IsBapartite(graph g,int v=0)
        {
            BaseQueue<int> _queue = new BaseQueue<int>();
            short[] colors = new short[g.vertexcount];
            for (int i = 0; i < g.vertexcount; i++)
                colors[i] = -1;
            _queue.enqueue(v);
            colors[v] = 0;
            while(!_queue.IsEmpty())
            {
                int t = _queue.dequeue();
                foreach (int  item in g.adj[t])
                {
                    if (colors[item] == -1)
                    {
                        colors[item] = (short)(1 - colors[t]);
                        _queue.enqueue(item);
                    }
                    else if (colors[item] == colors[t])
                        return false;
                }
            }

                return true;
        }

    }
}
