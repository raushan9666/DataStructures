using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class SCC
    {
        //do a DFS and check if all vertex are covered 
        //then do transpose and again check if all vertex is covered or not
        public static bool IsSSC(graph g)
        {
            bool[] visited = new bool[g.vertexcount];

            dfs(g, visited, 0);

            for(int i=0;i<g.vertexcount;i++)
            {
                if (!visited[i])
                    return false;
            }
            visited = new bool[g.vertexcount];

            transpose(ref g);

            dfs(g, visited, 0);

            for (int i = 0; i < g.vertexcount; i++)
            {
                if (!visited[i])
                    return false;
            }
            return true;


        }



        public static void printssc(graph g)
        {
           BaseStack<int> s=  TopologicalSort.sort(g);
           transpose(ref g);
           bool[] visited = new bool[g.vertexcount];

           int v;
           for (int i = 0; i < g.vertexcount;i++)
           {
               v = s.pop();
               if (!visited[v])
               {
                   printdfs(g, visited, v);
                   Console.WriteLine();
               }
           }
               

        }

        static void printdfs(graph g,bool [] visited,int v)
        {
            visited[v] = true;
            Console.Write(v +" ");
            foreach (int item in g.adj[v])
            {
                if (!visited[item])
                    printdfs(g, visited, item);
            }

        }

        static bool dfs(graph g,bool [] visited,int v)
        {
            visited[v] = true;
            foreach (int item in g.adj[v])
            {
                  if(!visited[item])
                  {
                      dfs(g, visited, item);
                  }
            }
            return false;
        }




         static void transpose(ref graph g)
        {
            List<int> [] adj = new List<int>[g.vertexcount];
            for(int i=0;i<g.vertexcount;i++)
                adj[i]= new List<int>();
            for(int i=0;i<g.vertexcount;i++)
            { 
                foreach (var item in g.adj[i])
                {
                    adj[item].Add(i);
                }
               
            }
            g.adj = adj;
        }



    }
}
