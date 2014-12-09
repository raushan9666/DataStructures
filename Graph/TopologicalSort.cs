using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class TopologicalSort
    {
        public static BaseStack<int> sort(graph g)
        {
            BaseStack<int> result = new BaseStack<int>();
            bool[] visited = new bool[g.vertexcount];
            for (int i = 0; i < g.vertexcount; i++)
            {
                if (!visited[i])
                    sorthelper(g, i, visited, result);
            }
                
                return result;
        }
        static void sorthelper(graph g,int v,bool [] visited,BaseStack<int> _stack)
        {
            visited[v] = true;
            foreach (int item in g.adj[v])
            {
               if(!visited[item])
               {
                   sorthelper(g, item, visited, _stack);
               }
            }
            _stack.push(v);

        }
    }
}
