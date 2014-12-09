using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class CycleDetection
    {
        //if there is a edge to any of the node and the root is other than the parent 
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
        
        // if there  is any edge which goes to any of the ancestor then there is a cycle
        public static bool directedGraph(graph g)
        {
            bool [] visited  = new bool [g.vertexcount];
            bool[] ancestor = new bool[g.vertexcount];

            for (int i = 0; i < g.vertexcount;i++)
            {
                 if(!visited[i]&&directedHelper(g,i,visited,ancestor))
                 {
                     return true;
                 }
            }



                return false;
        }
         static bool directedHelper(graph g,int v,bool [] visited,bool [] ancestor)
        {
            visited[v] = true;
            ancestor[v] = true;
            foreach (int i in g.adj[v])
            {
                 if(!visited[i]&& directedHelper(g,i,visited,ancestor))
                 {
                     return true;
                 }
                 else if(ancestor[i]==true)
                 {
                     return true;
                 }

            }
            ancestor[v] = false;
            return false;
        }

    }
}
