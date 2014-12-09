using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class CycleDetection
    {
        public static bool undirectedGraph(graph g)
        {
            bool[] visited = new bool[g.vertexcount];
            for(int i=0;i<g.vertexcount;i++)
            {
                if(!visited[i]&& undirectedHelper(g,i,-1,visited))
                {
                    return true;
                }
            }
            return false;
        }
        static bool undirectedHelper(graph g,int s,int p,bool [] visited)
        {
            visited[s] = true;
            foreach (int i in g.adj[s])
            {
                if (!visited[i])
                {
                    if (undirectedHelper(g, i,s, visited))
                    {
                        return true;
                    }
                }
                else if (i != s)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool directedGraph(graph g)
        {
            return false;
        }

    }
}
