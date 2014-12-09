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
        public int vertexcount;
        public List<int>[] adj;

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
    
        
    
    }

}
