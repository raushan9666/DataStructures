using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class bfs_dfs
    {
        public static void DFS(graph g,  int v = -1)
        {
            bool[] visited = new bool[g.vertexcount];
            for (int i = 0; i < g.vertexcount; i++)
                visited[i] = false;
            if (v == -1)
            {
                for (int i = 0; i < g.vertexcount; i++)
                {
                    if (visited[i] == false)
                        DFS_util(g,visited, i);
                }
            }
            else
            {
                DFS_util(g,visited, v);
            }

        }
        static void DFS_util(graph g,bool[] visited, int v)
        {
            visited[v] = true;
            Console.WriteLine(v + " ");
            foreach (int v1 in g.adj[v])
            {
                if (visited[v1] == false)
                {
                    DFS_util(g,visited, v1);
                }
            }
        }

        public static void BFS(graph g,int s = 0)
        {
            bool[] visited = new bool[g.vertexcount];
            // for (int i = 0; i < vertexcount; i++)
            //   visited[i] = false;
            BaseQueue<int> _queue = new BaseQueue<int>();
            visited[s] = true;
            _queue.enqueue(s);
            while (!_queue.IsEmpty())
            {
                int s1 = _queue.dequeue();
                Console.WriteLine(s1);
                foreach (var item in g.adj[s1])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        _queue.enqueue(item);
                    }
                }


            }
        }

    }
}
