using Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class node<T>
    {
        T val;
    }
    public class graph
    {
        int vertexcount;
        List<int>[] adj;

        public graph(int count)
        {
             vertexcount=count;
              adj = new List<int>[count];
              for (int i = 0; i < count;i++)
              {
                  adj[i] = new List<int>();
              }

        }

        public void addEdge(int s, int e)
        {

            adj[s].Add(e);
        }
    
       public void DFS(int v=-1)
        {
            bool[] visited = new bool[vertexcount];
            for (int i = 0; i < vertexcount; i++)
                visited[i] = false;
           if(v==-1)
           {
               for (int i = 0; i < vertexcount; i++)
               {
                   if (visited[i] == false)
                       DFS_util(visited, i);
               }
           }
           else
           {
               DFS_util(visited, v);
           }
           
        }
       void DFS_util(bool [] visited,int v)
       {
           visited[v] = true;
           Console.WriteLine(v+" ");
           foreach (int v1 in adj[v])
           {
              if(visited[v1]==false)
              {
                  DFS_util(visited,v1);
              }
           }
       }

        public void BFS(int s=0)
       {
           bool[] visited = new bool[vertexcount];
          // for (int i = 0; i < vertexcount; i++)
            //   visited[i] = false;
           BaseQueue<int> _queue = new BaseQueue<int>();
           visited[s] = true;
           _queue.enqueue(s);
            while(!_queue.IsEmpty())
            {
                int s1 = _queue.dequeue();
                Console.WriteLine(s1);
                foreach (var item in adj[s1])
                {
                   if(!visited[item])
                   {
                       visited[item] = true;
                       _queue.enqueue(item);
                   }
                }


            }
       }
    
    
    
    }

}
